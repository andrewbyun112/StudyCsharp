using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BookRentalShopApp2020.SubItems
{
    public partial class BooksMngForm : MetroForm
    {
        readonly string strTblName = "booksTbl";

        BaseMode myMode = BaseMode.NONE; // 기본 상태
        public BooksMngForm()
        {
            InitializeComponent();
        }

        private void DivMngForm_Load(object sender, EventArgs e)
        {
            
            UpdateComboDivision();

            UpdateDate();
            InitControls();
        }

        private void UpdateComboDivision()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT Division, Names FROM divTbl ";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> temps = new Dictionary<string, string>();
                temps.Add("선택", "");
                while (reader.Read())
                {
                    temps.Add(reader[1].ToString(), reader[0].ToString());
                }
                CboDivision.DataSource = new BindingSource(temps, null);
                CboDivision.DisplayMember = "Key";
                CboDivision.ValueMember = "Value";
                //CboDivision.SelectedIndex = -1;
            }
        }

        private void UpdateDate()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT b.Idx, " +
                                             "               b.Author, " +
                                             "               b.Division, " +
                                             "               d.Names AS DivisionName, " +
                                             "               b.Names, " +
                                             "               b.ReleaseDate, " +
                                             "               b.ISBN, " +
                                             "               b.Price " +
                                             "     FROM bookstbl AS b " +
                                             "    INNER JOIN divtbl AS d " +
                                             "          ON b.Division = d.Division " +
                                             "   ORDER BY b.Idx ASC ";
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
                //MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                adapter.Fill(ds, strTblName);

                GrdBookstbl.DataSource = ds;
                GrdBookstbl.DataMember = strTblName;
            }

            SetColumnHeaders();

        }

        private void SetColumnHeaders()
        {
            DataGridViewColumn column;

            column = GrdBookstbl.Columns[0];
            column.Width = 50;
            column.HeaderText = "번호";

            column = GrdBookstbl.Columns[1];
            column.Width = 120;
            column.HeaderText = "저자명";

            column = GrdBookstbl.Columns[2];
            column.Visible = false;

            column = GrdBookstbl.Columns[3]; // 구분코드명
            column.Width = 100;
            column.HeaderText = "장르";

            column = GrdBookstbl.Columns[4]; // 이름
            column.Width = 200;
            column.HeaderText = "이름";

            column = GrdBookstbl.Columns[5]; // 출간일
            column.Width = 150;
            column.HeaderText = "출간일";

            column = GrdBookstbl.Columns[6]; // ISBN
            column.Width = 150;
            column.HeaderText = "ISBN";

            column = GrdBookstbl.Columns[7]; // 가격
            column.Width = 100;
            column.HeaderText = "가격";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (myMode != BaseMode.UPDATE)
            {
                MetroMessageBox.Show(this, "삭제할 데이터를 선택하세요", "알림");
                return;
            }

            myMode = BaseMode.DELETE;
            SaveData();
            InitControls();
        }

        private void InitControls()
        {
            TxtIdx.Text = TxtAuthor.Text = string.Empty;
            TxtISBN.Text = TxtNames.Text = TxtPrice.Text = string.Empty;
            CboDivision.SelectedIndex = 0;
            TxtIdx.Focus();
            TxtIdx.ReadOnly = true;

            DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
            DtpReleaseDate.Value = DateTime.Now;

            myMode = BaseMode.NONE;

            #region 콤보 박스 데이터바인딩
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("선택", "00");
            //dic.Add("서울특별시", "11");
            //dic.Add("부산광역시", "21");
            //dic.Add("대구광역시", "22");
            //dic.Add("인천광역시", "23");
            //dic.Add("광주광역시", "24");
            //dic.Add("대전광역시", "25");

            //CboDivision.DataSource = new BindingSource(dic, null);
            //CboDivision.DisplayMember = "Key";
            //CboDivision.ValueMember = "Value";
            #endregion
        }

        #region 삭제처리 제거
        //private void DeleteProcess()
        //{
        //    try
        //    {
        //        using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
        //        {
        //            conn.Open();
        //            MySqlCommand cmd = new MySqlCommand();
        //            cmd.Connection = conn;
        //            cmd.CommandText = "DELETE FROM divtbl " +
        //                                              "WHERE Division = @Division ";
        //            MySqlParameter paramDivision = new MySqlParameter("@Division", MySqlDbType.VarChar);
        //            paramDivision.Value = TxtDivision.Text;
        //            cmd.Parameters.Add(paramDivision);

        //            var result = cmd.ExecuteNonQuery();

        //            MetroMessageBox.Show(this, $"{result}건이 삭제되었습니다.", "삭제");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MetroMessageBox.Show(this, $"에러발생 {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        UpdateDate();
        //    }
        //}
        #endregion
        private void BtnNew_Click(object sender, EventArgs e)
        {
            InitControls();

            myMode = BaseMode.INSERT; // 신규 입력 모드
        }

        /// <summary>
        /// DB 업데이트 및 입력 처리
        /// </summary>
        private void SaveData()
        {
            // 빈 값 비교 NULL 체크
            if (string.IsNullOrEmpty(TxtAuthor.Text) ||
                CboDivision.SelectedIndex < 1 ||
                string.IsNullOrEmpty(TxtNames.Text) ||
                string.IsNullOrEmpty(TxtISBN.Text))
            {
                MetroMessageBox.Show(this, "빈 값은 넣을 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (myMode == BaseMode.NONE)
            {
                MessageBox.Show(this, "신규등록시 신규버튼을 눌러주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
                {
                    conn.Open(); //using안쓰면 밑에 close해줘야함
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;


                    if (myMode == BaseMode.UPDATE)
                    {
                        cmd.CommandText = "UPDATE bookstbl " +
                                                           "       SET " +
                                                           "              Author                = @Author, " +
                                                           "              Division              = @Division, " +
                                                           "              Names               = @Names, " +
                                                           "              ReleaseDate      = @ReleaseDate, " +
                                                           "              ISBN                   = @ISBN, " +
                                                           "              Price                  = @Price " +
                                                           " WHERE Idx                      = @Idx ";
                    }
                    else if (myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = " INSERT INTO bookstbl " +
                                                            "( " +
                                                            "Author, " +
                                                            "Division, " +
                                                            "Names, " +
                                                            "ReleaseDate, " +
                                                            "ISBN, " +
                                                            "Price) " +
                                                            "VALUES " +
                                                            "( " +
                                                            "@Author, " +
                                                            "@Division, " +
                                                            "@Names, " +
                                                            "@ReleaseDate, " +
                                                            "@ISBN, " +
                                                            "@Price) ";
                    }
                    //Author
                    MySqlParameter paramAuthor = new MySqlParameter("@Author", MySqlDbType.VarChar, 45)
                    {
                        Value = TxtAuthor.Text
                    };
                    cmd.Parameters.Add(paramAuthor);
                    //Division
                    MySqlParameter paramDivision = new MySqlParameter("@Division", MySqlDbType.VarChar, 4)
                    {
                        Value = CboDivision.SelectedValue
                    };
                    cmd.Parameters.Add(paramDivision);
                    //Names
                    MySqlParameter paramNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 100)
                    {
                        Value = TxtNames.Text
                    };
                    cmd.Parameters.Add(paramNames);
                    //ReleaseDate
                    MySqlParameter paramReleaseDate = new MySqlParameter("@ReleaseDate", MySqlDbType.Date)
                    {
                        Value = DtpReleaseDate.Value
                    };
                    cmd.Parameters.Add(paramReleaseDate);
                    //ISBN
                    MySqlParameter paramISBN = new MySqlParameter("@ISBN", MySqlDbType.VarChar, 13)
                    {
                        Value = TxtISBN.Text
                    };
                    cmd.Parameters.Add(paramISBN);
                    //Price
                    MySqlParameter paramPrice = new MySqlParameter("@Price", MySqlDbType.Decimal)
                    {
                        Value = TxtPrice.Text
                    };
                    cmd.Parameters.Add(paramPrice);

                    if(myMode == BaseMode.UPDATE)
                    {
                        //IDX : PK
                        MySqlParameter paramIdx = new MySqlParameter("@Idx", MySqlDbType.Int32)
                        {
                            Value = TxtIdx.Text
                        };
                        cmd.Parameters.Add(paramIdx);
                    }

                    var result = cmd.ExecuteNonQuery();

                    if (myMode == BaseMode.INSERT)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 신규입력되었습니다.", "신규입력");
                    }
                    else if (myMode == BaseMode.UPDATE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 수정되었습니다.", "수정");
                    }
                    //else if (myMode == BaseMode.DELETE)
                    //{
                    //    MetroMessageBox.Show(this, $"{result}건이 삭제되었습니다.", "삭제");
                    //}
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"에러발생 {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UpdateDate();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            InitControls();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            InitControls();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GrdDivtbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdBookstbl.Rows[e.RowIndex];
                // To Do : 클릭 시 입력컨트롤에 데이터 할당
                TxtIdx.Text = data.Cells[0].Value.ToString();
                TxtAuthor.Text = data.Cells[1].Value.ToString();

                // 로맨스, 추리 등 디스플레이되는 글자로 인덱스 찾기
                //CboDivision.SelectedIndex = CboDivision.FindString(data.Cells[3].Value.ToString());

                //코드 값을 그대로 할당 B001, B002
                CboDivision.SelectedValue = data.Cells[2].Value;

                TxtNames.Text = data.Cells[4].Value.ToString();
                // 출간일 날짜픽커 Cells[5]
                DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
                DtpReleaseDate.Format = DateTimePickerFormat.Custom;
                DtpReleaseDate.Value = DateTime.Parse(data.Cells[5].Value.ToString());


                TxtISBN.Text = data.Cells[6].Value.ToString();
                TxtPrice.Text = data.Cells[7].Value.ToString();

                TxtIdx.ReadOnly = true; //pk는 바꾸면 난리나니까 바꾸지 못하게 설정
                TxtIdx.Focus();
                myMode = BaseMode.UPDATE; // 수정 모드 변경
            }
        }

        
    }
}
