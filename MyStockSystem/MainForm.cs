using MetroFramework.Forms;
using MyStockSystem.SubItems;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyStockSystem
{
    public partial class MainForm : MetroForm //Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MtlSearchItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            SearchItemForm searchItem = new SearchItemForm();
            searchItem.Location = this.Location;
            searchItem.ShowDialog();

            this.Close();
        }
    }
}
