using System;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using MetroFramework.Forms;

namespace TrafficInfo.SubItems
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            WebClient wc = null;
            XmlDocument doc = null;

            wc = new WebClient() { Encoding = Encoding.UTF8 };
            doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://apis.data.go.kr/6260000/IncidentHistoryService/getIncidentHistoryList");
            str.Append("?serviceKey=Nvajuv%2BuNyZAo90FChDLxeqL65FaAsYMo%2B2Pq%2FS8MjPQi7OhfjD8xbdJFTgpOBgi%2F8CIdxs9JSoH1hskIVxNiQ%3D%3D");
            str.Append($"&resultCode={TxtSearchItem.Text}"); // 검색어
            str.Append("&numOfRows=200"); // 읽어올 데이터수
            str.Append("&pageNo=1"); // 페이지번호

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");
            DgvSearchItems.Rows.Clear();

            try
            {
                foreach (XmlNode item in items)
                {
                    DgvSearchItems.Rows.Add(item["INCIDENTDESC"].InnerText, //교통사고 개요
                                                               item["REGISTDATE"].InnerText, //교통사고 시간
                                                              // item["INSTITUTION"] == null ? string.Empty : item["INSTITUTION"].InnerText, // 유관기관명
                                                               item["INCIDENTCODE"].InnerText, // 돌발상황 유형
                                                               item["X"].InnerText, //X좌표
                                                               item["Y"].InnerText, //Y좌표
                                                               item["TITLE"].InnerText // 교통사고 위치
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
            if (e.KeyChar == (char)13)
            {
                BtnSearch_Click(sender, new EventArgs());
            }
        }

        private void MtlBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm main = new MainForm();
            main.Location = this.Location;
            main.ShowDialog();

            this.Close();
        }
    }
}
