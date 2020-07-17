using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http.Headers;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BookRentalShopApp20.Subitems
{
    public partial class RentalMngForm : MetroForm
    {
        #region 멤버 변수 영역

        readonly string strTblName = "membertbl";
        BaseMode myMode = BaseMode.NONE;        //commons의 enum,최초는 기본상태

        #endregion

        #region 생성자 영역
        public RentalMngForm()
        {
            InitializeComponent();
        }

        private void DivMngForm_Load(object sender, EventArgs e)
        {
            UpdateComboMember();
            UpdateComboBook();

            UpdataData();

            InitControls();
        }

        
        #endregion


        #region 사용자 메소드 영역

        private void UpdateComboMember()  //콤보박스 데이터 넣는 함수
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT Idx, Names " +
                                              "FROM membertbl ";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();   //where절같은게 없으니 바로날림


                //인덱스 구문
                Dictionary<string, string> temps = new Dictionary<string, string>();
                temps.Add("선택", ""); //첫번째 들어가서 값 제대로 나옴

                while (reader.Read())
                {
                    temps.Add(reader[1].ToString(), reader[0].ToString());
                }

                CboMember.DataSource = new BindingSource(temps, null);
                CboMember.DisplayMember = "Key";
                CboMember.ValueMember = "Value";
                //CboDivision.SelectedIndex = -1;

            }
        }

        private void UpdataData()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT b.Idx, " +     //길게해놓으면 불편하기때문에 하나씩 잘라서쓰기
                                   "      b.Author, " +
                                   "      b.Division, " +
                                   "      d.Names AS DivisionName, " +
                                   "      b.Names, " +
                                   "      b.ReleaseDate, " +
                                   "      b.ISBN, " +
                                   "      b.Price " +
                                   "   FROM bookstbl AS b" +
                                   "  INNER JOIN divtbl AS d " +
                                   "    ON b.Division = d.Division " +
                                   "  ORDER BY b.Idx ASC ";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = strQuery;

                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
                //adapter가 connand parameter DataReader 다 가능
                DataSet ds = new DataSet();
                adapter.Fill(ds, strTblName);

                GrdRentalTbl.DataSource = ds;
                GrdRentalTbl.DataMember = strTblName;
            }
            SetColumnHeaders();     //열 제목줄 수정!
        }

        private void SetColumnHeaders() //컬럼 이름 조정 
        {
            DataGridViewColumn column;
            column = GrdRentalTbl.Columns[0];
            column.Width = 50;
            column.HeaderText = "순번";

            column = GrdRentalTbl.Columns[1];
            column.Width = 50;
            column.HeaderText = "이름";

            column = GrdRentalTbl.Columns[2];
            column.Visible = true;              //열 표시 여부
            column.HeaderText = "등급";

            column = GrdRentalTbl.Columns[3];
            column.Width = 100;
            column.HeaderText = "주소";

            column = GrdRentalTbl.Columns[4];
            column.Width = 100;
            column.HeaderText = "핸드폰";

            column = GrdRentalTbl.Columns[5];
            column.Width = 150;
            column.HeaderText = "이메일";

        }

        private void UpdateComboBook()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT b.Idx, b.Names, " +
                                              "(SELECT Names FROM divtbl WHERE Division = b.Division) AS Division " +
                                              "FROM bookstbl AS b; ";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();   //where절같은게 없으니 바로날림

                Dictionary<string, string> temps = new Dictionary<string, string>();
                temps.Add("선택", ""); //첫번째 들어가서 값 제대로 나옴

                while (reader.Read())
                {
                    temps.Add($"[{reader[2]}] {reader[1]}" , $"{reader[0]}");
                }

                CboBook.DataSource = new BindingSource(temps, null);
                CboBook.DisplayMember = "Key";
                CboBook.ValueMember = "Value";
                //CboDivision.SelectedIndex = -1;
            }
        }


        private void InitControls()     //초기화하는 구문
        {
            //TxtIdx.Text = TxtNames.Text = string.Empty;
            //TxtEmail.Text = TxtAddr.Text = TxtMobile.Text = string.Empty;
            CboBook.SelectedIndex = 0; //save하고나서 인덱스0으로바뀜

            TxtIdx.Focus();
            TxtIdx.ReadOnly = true;



            myMode = BaseMode.NONE; //아무것도 아닌상태

            #region 콤보박스 데이터바인딩
            ////콤보 박스 데이터 바인딩
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("선택", "00");
            //dic.Add("서울특별시", "11");//key value
            //dic.Add("부산광역시", "21");
            //dic.Add("대구광역시", "22");
            //dic.Add("인천광역시", "23");
            //dic.Add("광주광역시", "24");
            //dic.Add("대전광역시", "25");

            //CboDivision.DataSource = new BindingSource(dic,null); //폼의 데이터 소스 캡슐화
            //CboDivision.DisplayMember = "key";
            //CboDivision.ValueMember = "Value";

            #endregion
        }


        #region 삭제처리제거
        //private void DeleteProcess()
        //{
        //    try
        //    {
        //        using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
        //        {
        //            conn.Open(); //using문사용시 자동으로 conn.close해줌 원래는 conn.close해줘야함!
        //            MySqlCommand cmd = new MySqlCommand();
        //            cmd.Connection = conn;
        //            cmd.CommandText = "DELETE FROM divtbl " +
        //                              "  WHERE Division = @Division ";
        //            MySqlParameter paramDivision = new MySqlParameter(@"Division", MySqlDbType.VarChar);
        //            paramDivision.Value = TxtDivision.Text;
        //            cmd.Parameters.Add(paramDivision);

        //            var result = cmd.ExecuteNonQuery();


        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MetroMessageBox.Show(this, $"에러발생 {ex.Message}", "에러",
        //                         MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        UpdataData();
        //    }
        //}
        #endregion



        /// <summary>
        /// DB 업데이트 및 입력 처리
        /// </summary>

        private void SaveData()
        {
            //빈값비교 NULL체크, 인덱스가 1이거나 -1이면 안된다
            //if (string.IsNullOrEmpty(TxtNames.Text) || CboBook.SelectedIndex < 1 || string.IsNullOrEmpty(TxtAddr.Text) || string.IsNullOrEmpty(TxtEmail.Text))
            //{
            //    MetroMessageBox.Show(this, "빈값은 넣을 수 없습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return;
            //}
            if (myMode == BaseMode.NONE)
            {
                MetroMessageBox.Show(this, "신규 등록시 신규 버튼을 눌러주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
                {
                    conn.Open(); //using문사용시 자동으로 conn.close해줌 원래는 conn.close해줘야함!
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    if (myMode == BaseMode.UPDATE)
                    {
                        cmd.CommandText = "UPDATE membertbl " +
                                          " SET Names = @Names, " +
                                          "     Levels = @Levels, " +
                                          "     Addr = @Addr, " +
                                          "     Mobile = @Mobile, " +
                                          "     Email = @Email " +
                                          " WHERE Idx   = @Idx ";
                    }
                    else if (myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = " INSERT INTO membertbl " +
                                          " (Names, " +
                                          " Levels, " +
                                          " Addr, " +
                                          " Mobile, " +
                                          " Email) " +
                                          " VALUES " +
                                          " (@Names, " +
                                          " @Levels, " +
                                          " @Addr, " +
                                          " @Mobile, " +
                                          " @Email) ";
                    }

                    else if (myMode == BaseMode.DELETE)
                    {
                        cmd.CommandText = " ";
                    }


                    //MySqlParameter paramNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 45)
                    //{
                    //    Value = TxtNames.Text
                    //};
                    //cmd.Parameters.Add(paramNames);

                    MySqlParameter paramLevels = new MySqlParameter("@Levels", MySqlDbType.VarChar, 4)
                    {
                        Value = CboBook.SelectedValue   //cbo는 selectedvalue사용
                    };
                    cmd.Parameters.Add(paramLevels);

                    //MySqlParameter paramAddr = new MySqlParameter("@Addr", MySqlDbType.VarChar, 100)
                    //{
                    //    Value = TxtAddr.Text
                    //};
                    //cmd.Parameters.Add(paramAddr);

                    //MySqlParameter paramMobile = new MySqlParameter("@Mobile", MySqlDbType.VarChar, 100)
                    //{
                    //    Value = TxtMobile.Text
                    //};
                    //cmd.Parameters.Add(paramMobile);

                    //MySqlParameter paramEmail = new MySqlParameter("@Email", MySqlDbType.Date)
                    //{
                    //    Value = TxtMobile.Text
                    //};
                    //cmd.Parameters.Add(paramEmail);




                    if (myMode == BaseMode.UPDATE)
                    {
                        MySqlParameter paramIdx = new MySqlParameter("@Idx", MySqlDbType.Int32)
                        {
                            Value = TxtIdx.Text
                        };
                        cmd.Parameters.Add(paramIdx);
                    }


                    var result = cmd.ExecuteNonQuery();
                    if (myMode == BaseMode.INSERT)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 신규 입력되었습니다.", "신규입력");
                    }
                    else if (myMode == BaseMode.UPDATE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 수정되었습니다", "수정");
                    }
                    else if (myMode == BaseMode.DELETE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 삭제되었습니다", "삭제");
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"에러발생 {ex.Message}", "에러",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UpdataData();
            }

        }
        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdRentalTbl.Rows[e.RowIndex];
                // 클릭시 입력컨트롤에 데이터 할당
                TxtIdx.Text = data.Cells[0].Value.ToString();
                //TxtNames.Text = data.Cells[1].Value.ToString();
                CboBook.SelectedValue = data.Cells[2].Value.ToString();

                // TODO : 장르 콤보 박스 cells[2]
                //TxtAddr.Text = data.Cells[3].Value.ToString();
                //TxtMobile.Text = data.Cells[4].Value.ToString();
                //TxtEmail.Text = data.Cells[5].Value.ToString();

                //TxtIdx.ReadOnly = true;  InitControls에 이미 true임
                myMode = BaseMode.UPDATE;   //수정 모드 변경
            }


        }
        #endregion


        #region 이벤트 핸들러 영역
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (myMode != BaseMode.UPDATE)   //데이터열누르면 수정모드가 되므로!
            {
                MetroMessageBox.Show(this, "삭제할 데이터를 선택하세요", "알림");
                return;
            }
            myMode = BaseMode.DELETE;
            SaveData();
            InitControls();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            InitControls();

            myMode = BaseMode.INSERT;   //신규 입력 모드 변경

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

        #endregion
    }
}
