using System;
using System.Windows.Forms;
using BookRentalShopApp2020.SubItems;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShopApp2020
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result =  MetroMessageBox.Show(this, "종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes) //프로그램 종료
            {
                e.Cancel = false;
                Environment.Exit(0); //완전 종료
            }
            else //프로그램 종료 안함
            {
                e.Cancel = true;
            }
        }

        private void MnuMng_Click(object sender, EventArgs e)
        {
            DivMngForm form = new DivMngForm();
            ShowFormControl(form, "구분코드 관리");
        }

        private void MnuItemExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MnuItemBooksMng_Click(object sender, EventArgs e)
        {
            BooksMngForm form = new BooksMngForm();
            ShowFormControl(form, "도서 관리");
        }

        private void ShowFormControl(Form form, string title)
        {
            form.MdiParent = this;
            form.Text = title;
            form.Dock = DockStyle.Fill;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }
    }
}
