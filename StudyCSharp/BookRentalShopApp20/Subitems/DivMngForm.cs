using System;
using System.Data;
using System.Net.Http.Headers;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BookRentalShopApp20.Subitems
{
    public partial class DivMngForm : MetroForm
    {
        readonly string strTblName = "divtbl";
        BaseMode myMode = BaseMode.NONE;        //commons의 enum,최초는 기본상태
        public DivMngForm()
        {
            InitializeComponent();
        }

        private void DivMngForm_Load(object sender, EventArgs e)
        {
            UpdataData();
        }

        private void UpdataData()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"select Division,Names from {strTblName};";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = strQuery;

                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
                //adapter가 connand parameter DataReader 다 가능
                DataSet ds = new DataSet();
                adapter.Fill(ds, strTblName);

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = strTblName;
            }
            SetColumnHeaders();     //열 제목줄 수정!
        }

        private void SetColumnHeaders()
        {
            DataGridViewColumn column;
            column = GrdDivTbl.Columns[0];
            column.Width = 100;
            column.HeaderText = "구분코드";

            column = GrdDivTbl.Columns[1];
            column.Width = 150;
            column.HeaderText = "이름";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(myMode != BaseMode.UPDATE)   //데이터열누르면 수정모드가 되므로!
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
            TxtDivision.Text = TxtNames.Text = string.Empty;
            TxtDivision.Focus();

            myMode = BaseMode.NONE;
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

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtDivision.Text = TxtNames.Text = string.Empty;
            TxtDivision.ReadOnly = false;
            myMode = BaseMode.INSERT;   //신규 입력 모드 변경

        }

        /// <summary>
        /// DB 업데이트 및 입력 처리
        /// </summary>
        private void SaveData()
        {
            if (string.IsNullOrEmpty(TxtDivision.Text) || string.IsNullOrEmpty(TxtNames.Text))
            {
                MetroMessageBox.Show(this, "빈값은 넣을 수 없습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(myMode == BaseMode.NONE)
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
                        cmd.CommandText = "UPDATE divtbl " +
                                          "     SET Names = @Names " +
                                          " WHERE Division = @Division ";
                    }
                    else if(myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = " INSERT INTO " +
                                          " divtbl (Division, Names) " +
                                          " VALUES (@Division, @Names) ";
                    }
                    
                    else if(myMode == BaseMode.DELETE)
                    {
                        cmd.CommandText = "DELETE FROM divtbl " +
                                          "  WHERE Division = @Division ";
                    }

                    if(myMode == BaseMode.INSERT || myMode == BaseMode.UPDATE)
                    {
                        MySqlParameter paramNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 45);
                        paramNames.Value = TxtNames.Text;
                        cmd.Parameters.Add(paramNames);//delete문은 names가 없으므로 따로분기!
                    }

                   
                    MySqlParameter paramDivision = new MySqlParameter("@Division", MySqlDbType.VarChar);
                    paramDivision.Value = TxtDivision.Text;
                    cmd.Parameters.Add(paramDivision);

                    var result = cmd.ExecuteNonQuery();
                    if(myMode == BaseMode.INSERT)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 신규 입력되었습니다.", "신규입력");
                    }
                    else if(myMode == BaseMode.UPDATE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 수정되었습니다", "수정");
                    }
                    else if(myMode == BaseMode.DELETE)
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            InitControls();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            InitControls();
        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex];
                TxtDivision.Text = data.Cells[0].Value.ToString();
                TxtNames.Text = data.Cells[1].Value.ToString();

                TxtDivision.ReadOnly = true;
                myMode = BaseMode.UPDATE;   //수정 모드 변경
            }
        }
    }
}
