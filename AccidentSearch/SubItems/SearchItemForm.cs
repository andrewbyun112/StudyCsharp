using MetroFramework.Forms;
using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace AccidentSearch.SubItems
{
    public partial class SearchItemForm : MetroForm
    {
        public SearchItemForm()
        {
            InitializeComponent();
        }

        private void SearchItemForm_Load(object sender, EventArgs e)
        {

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
            str.Append("http://openapi.animal.go.kr/openapi/service/rest/recordAgencySrvc/recordAgency");
            str.Append("?serviceKey=Z3K62vdCuIDC2FkIVI5z6sV1KWEFL%2B6CoVJPKxLwVevzTk2WmwYdGfmUhaCC%2Bx932u%2B7ITe3s9n8qnv473lDEg%3D%3D");
            str.Append("&pageNo=1");
            str.Append("&numOfRows=10");
            str.Append($"&addr={TxtSearchItem.Text}");

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");
            DgvSearchItems.Rows.Clear();

            try
            {
                foreach (XmlNode item in items)
                {
                    DgvSearchItems.Rows.Add(item["orgNm"].InnerText,
                                                                item["memberNm"].InnerText,
                                                                item["orgAddr"].InnerText,
                                                                item["orgAddrDtl"] == null ? string.Empty : item["orgAddrDtl"].InnerText,
                                                                item["tel"].InnerText
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
    }
}
