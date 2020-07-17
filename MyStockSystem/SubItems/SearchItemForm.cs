using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyStockSystem.SubItems
{
    public partial class SearchItemForm : MetroForm
    {
        public SearchItemForm()
        {
            InitializeComponent();
        }

        private void SearchItemForm_Load(object sender, EventArgs e)
        {
            DgvSearchItems.Font = new Font(@"NanumGothic", 9, FontStyle.Regular);
        }

        private void MtlBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm main = new MainForm();
            main.Location = this.Location;
            main.ShowDialog();

            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            WebClient wc = null;
            XmlDocument doc = null;

            wc = new WebClient() { Encoding = Encoding.UTF8 };
            doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://api.seibro.or.kr/openapi/service/StockSvc/getStkIsinByNmN1"); // OpenAPI 기본
            str.Append("?serviceKey=Z3K62vdCuIDC2FkIVI5z6sV1KWEFL%2B6CoVJPKxLwVevzTk2WmwYdGfmUhaCC%2Bx932u%2B7ITe3s9n8qnv473lDEg%3D%3D"); // 인증키
            str.Append($"&secnNm={TxtSearchItem.Text}"); // 검색어
            str.Append("&numOfRows=200"); // 읽어올 데이터수
            str.Append("&pageNo=1"); // 페이지번호
            str.Append("&martTpcd=11"); // 주식시장종류 11=유가증권

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");
            DgvSearchItems.Rows.Clear();

            try
            {
                foreach (XmlNode item in items)
                {
                    DgvSearchItems.Rows.Add(item["isin"].InnerText, //isin 표준 코드
                                                               item["issuDt"] == null ? string.Empty : item["issuDt"].InnerText, //주식발행일자
                                                                  //item["issuDt"].InnerText,
                                                               item["korSecnNm"].InnerText, //한글종목명
                                                               item["secnKacdNm"].InnerText, //보통주/우선주
                                                               item["shotnIsin"].InnerText //단축코드
                                                               );
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"에러발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            DgvSearchItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void TxtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                BtnSearch_Click(sender, new EventArgs());
            }
        }
    }
}
