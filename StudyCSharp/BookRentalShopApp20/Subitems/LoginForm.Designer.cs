namespace BookRentalShopApp20.Subitems
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtUserID = new MetroFramework.Controls.MetroTextBox();
            this.TxtUserPW = new MetroFramework.Controls.MetroTextBox();
            this.Button_OK = new MetroFramework.Controls.MetroButton();
            this.Button_Cancle = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(13, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 33);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(13, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(145, 23);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "PASSWORD";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtUserID
            // 
            // 
            // 
            // 
            this.TxtUserID.CustomButton.Image = null;
            this.TxtUserID.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.TxtUserID.CustomButton.Name = "";
            this.TxtUserID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtUserID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUserID.CustomButton.TabIndex = 1;
            this.TxtUserID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUserID.CustomButton.UseSelectable = true;
            this.TxtUserID.CustomButton.Visible = false;
            this.TxtUserID.Lines = new string[0];
            this.TxtUserID.Location = new System.Drawing.Point(164, 91);
            this.TxtUserID.MaxLength = 45;
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.PasswordChar = '\0';
            this.TxtUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUserID.SelectedText = "";
            this.TxtUserID.SelectionLength = 0;
            this.TxtUserID.SelectionStart = 0;
            this.TxtUserID.ShortcutsEnabled = true;
            this.TxtUserID.Size = new System.Drawing.Size(236, 23);
            this.TxtUserID.TabIndex = 0;
            this.TxtUserID.UseSelectable = true;
            this.TxtUserID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUserID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserID_KeyPress);
            // 
            // TxtUserPW
            // 
            // 
            // 
            // 
            this.TxtUserPW.CustomButton.Image = null;
            this.TxtUserPW.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.TxtUserPW.CustomButton.Name = "";
            this.TxtUserPW.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtUserPW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUserPW.CustomButton.TabIndex = 1;
            this.TxtUserPW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUserPW.CustomButton.UseSelectable = true;
            this.TxtUserPW.CustomButton.Visible = false;
            this.TxtUserPW.Lines = new string[0];
            this.TxtUserPW.Location = new System.Drawing.Point(164, 120);
            this.TxtUserPW.MaxLength = 32767;
            this.TxtUserPW.Name = "TxtUserPW";
            this.TxtUserPW.PasswordChar = '＊';
            this.TxtUserPW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUserPW.SelectedText = "";
            this.TxtUserPW.SelectionLength = 0;
            this.TxtUserPW.SelectionStart = 0;
            this.TxtUserPW.ShortcutsEnabled = true;
            this.TxtUserPW.Size = new System.Drawing.Size(236, 23);
            this.TxtUserPW.TabIndex = 1;
            this.TxtUserPW.UseSelectable = true;
            this.TxtUserPW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUserPW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtUserPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserPW_KeyPress);
            // 
            // Button_OK
            // 
            this.Button_OK.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Button_OK.Location = new System.Drawing.Point(141, 160);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(107, 45);
            this.Button_OK.TabIndex = 2;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseSelectable = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancle
            // 
            this.Button_Cancle.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Button_Cancle.Location = new System.Drawing.Point(254, 160);
            this.Button_Cancle.Name = "Button_Cancle";
            this.Button_Cancle.Size = new System.Drawing.Size(110, 45);
            this.Button_Cancle.TabIndex = 3;
            this.Button_Cancle.Text = "Cancle";
            this.Button_Cancle.UseSelectable = true;
            this.Button_Cancle.Click += new System.EventHandler(this.Button_Cancle_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 251);
            this.ControlBox = false;
            this.Controls.Add(this.Button_Cancle);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.TxtUserPW);
            this.Controls.Add(this.TxtUserID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "LoginForm";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtUserID;
        private MetroFramework.Controls.MetroTextBox TxtUserPW;
        private MetroFramework.Controls.MetroButton Button_OK;
        private MetroFramework.Controls.MetroButton Button_Cancle;
    }
}