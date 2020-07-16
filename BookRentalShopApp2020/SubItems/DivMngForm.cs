using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BookRentalShopApp2020.SubItems
{
    public partial class DivMngForm : MetroForm
    {
        readonly string strTblName = "divTbl";

        BaseMode myMode = BaseMode.NONE; // 기본 상태
        public DivMngForm()
        {
            InitializeComponent();
        }

        private void DivMngForm_Load(object sender, EventArgs e)
        {
            UpdateDate();
        }

        private void UpdateDate()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT Division,Names FROM {strTblName} ";
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "divTbl");

                GrdDivtbl.DataSource = ds;
                GrdDivtbl.DataMember = strTblName;
            }

            SetColumnHeaders();

        }

        private void SetColumnHeaders()
        {
            DataGridViewColumn column;

            column = GrdDivtbl.Columns[0];
            column.Width = 100;
            column.HeaderText = "구분코드";

            column = GrdDivtbl.Columns[1];
            column.Width = 150;
            column.HeaderText = "이름";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(myMode != BaseMode.UPDATE)
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
            TxtDivision.Text = TxtNames.Text = string.Empty;
            TxtDivision.ReadOnly = false;
            TxtDivision.Focus();

            myMode = BaseMode.INSERT; // 신규 입력 모드
        }

        /// <summary>
        /// DB 업데이트 및 입력 처리
        /// </summary>
        private void SaveData()
        {
            if (string.IsNullOrEmpty(TxtDivision.Text) || string.IsNullOrEmpty(TxtNames.Text))
            {
                MetroMessageBox.Show(this, "빈 값은 넣을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    

                    if(myMode == BaseMode.UPDATE)
                    {
                        cmd.CommandText = "UPDATE divtbl " +
                                                          "       SET Names = @Names " +
                                                          " WHERE Division = @Division "; // UPDATE문
                    }
                    else if(myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = "INSERT INTO " +
                                                         "    divtbl (Division, Names) " +
                                                         " VALUES(@Division, @Names) ";
                    }
                    else if(myMode == BaseMode.DELETE)
                    {
                        cmd.CommandText = "DELETE FROM divtbl " +
                                                      "WHERE Division = @Division ";
                    }

                    if(myMode ==BaseMode.INSERT || myMode == BaseMode.UPDATE)
                    {
                        MySqlParameter paramNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 45);
                        paramNames.Value = TxtNames.Text;
                        cmd.Parameters.Add(paramNames);
                    }
                    
                    
                    MySqlParameter paramDivision = new MySqlParameter("@Division", MySqlDbType.VarChar);
                    paramDivision.Value = TxtDivision.Text;
                    cmd.Parameters.Add(paramDivision);

                    var result = cmd.ExecuteNonQuery();

                    if(myMode == BaseMode.INSERT)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 신규입력되었습니다.", "신규입력");
                    }
                    else if(myMode == BaseMode.UPDATE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 수정되었습니다.", "수정");
                    }
                    else if (myMode == BaseMode.DELETE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 삭제되었습니다.", "삭제");
                    }
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
                DataGridViewRow data = GrdDivtbl.Rows[e.RowIndex];
                TxtDivision.Text = data.Cells[0].Value.ToString();
                TxtNames.Text = data.Cells[1].Value.ToString();

                TxtDivision.ReadOnly = true; //pk는 바꾸면 난리나니까 바꾸지 못하게 설정
                TxtDivision.Focus();
                myMode = BaseMode.UPDATE; // 수정 모드 변경
            }
        }
    }
}
