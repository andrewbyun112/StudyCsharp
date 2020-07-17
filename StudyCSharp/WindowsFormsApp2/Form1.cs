using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("EventHandler maden!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += Button1_Click;
            textBox1.KeyPress += TextBox1_KeyPress;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                textBox2.Focus(); //엔터치면 커서가 textbox2로 내려감
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ClickEvent occurred");
            return;
        }
    }
}
