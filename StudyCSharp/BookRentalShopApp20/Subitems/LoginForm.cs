using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BookRentalShopApp20.Subitems
{
    public partial class LoginForm : MetroForm
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void LoginProcess()
        {
            //빈 값 비교 처리
            if(string.IsNullOrEmpty(TxtUserID.Text)|| string.IsNullOrEmpty(TxtUserPW.Text))
            {
                MetroMessageBox.Show(this,"아이디나 패스워드를 입력하세요!", "로그인",
                                MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            //실제 DB처리
            string resultId = string.Empty; //""

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
                {
                    conn.Open();
                    //MetroMessageBox.Show(this, $"DB접속성공!!");
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT userID FROM userTBL " +   //스페이스주의!!!!
                                      " WHERE userID = @userID " +
                                      "  AND password = @password ";

                    MySqlParameter paramUserId = new MySqlParameter("@userID", MySqlDbType.VarChar, 45);
                    paramUserId.Value = TxtUserID.Text.Trim();
                    MySqlParameter paramPassword = new MySqlParameter("@password", MySqlDbType.VarChar);
                    //암호화 구문 MD5
                    var md5Hash = MD5.Create();
                    var cryptoPassword = Commons.GetMd5Hash(md5Hash, TxtUserPW.Text.Trim());
                    paramPassword.Value = cryptoPassword;

                    cmd.Parameters.Add(paramUserId);
                    cmd.Parameters.Add(paramPassword);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if (!reader.HasRows)
                    {
                        MetroMessageBox.Show(this, "아이디나 패스워드를 정확히 입력하세요", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtUserID.Text = TxtUserPW.Text = string.Empty;
                        TxtUserID.Focus();
                        return;
                    }
                    else
                    {
                        resultId = reader["userID"] != null ? reader["userID"].ToString() : string.Empty;
                        MetroMessageBox.Show(this, $"{resultId}로그인 성공");
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"DB접속에러 : {ex.Message}", "로그인에러",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(resultId))
            {
                MetroMessageBox.Show(this, "아이디나 패스워드를 정확히 입력하세요", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserID.Text = TxtUserPW.Text = string.Empty;
                TxtUserID.Focus();
                return;
            }
            else
            {
                this.Close();   //폼을 닫습니다
            }

        }

        private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                TxtUserPW.Focus();
            }
        }

        private void TxtUserPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Button_OK_Click(sender, new EventArgs());
            }
        }

        private void Button_Cancle_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    //종료
        }
    }
}
