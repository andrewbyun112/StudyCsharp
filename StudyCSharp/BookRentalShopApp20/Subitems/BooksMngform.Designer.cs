namespace BookRentalShopApp20.Subitems
{
    partial class BooksMngform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdBooksTbl = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpReleaseDate = new MetroFramework.Controls.MetroDateTime();
            this.CboDivision = new MetroFramework.Controls.MetroComboBox();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.TxtISBN = new MetroFramework.Controls.MetroTextBox();
            this.TxtNames = new MetroFramework.Controls.MetroTextBox();
            this.TxtAuthor = new MetroFramework.Controls.MetroTextBox();
            this.TxtPrice = new MetroFramework.Controls.MetroTextBox();
            this.TxtID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdBooksTbl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GrdBooksTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(760, 370);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 0;
            // 
            // GrdBooksTbl
            // 
            this.GrdBooksTbl.AllowUserToAddRows = false;
            this.GrdBooksTbl.AllowUserToDeleteRows = false;
            this.GrdBooksTbl.AllowUserToResizeRows = false;
            this.GrdBooksTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdBooksTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdBooksTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdBooksTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdBooksTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GrdBooksTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdBooksTbl.DefaultCellStyle = dataGridViewCellStyle8;
            this.GrdBooksTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdBooksTbl.EnableHeadersVisualStyles = false;
            this.GrdBooksTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdBooksTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdBooksTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdBooksTbl.Name = "GrdBooksTbl";
            this.GrdBooksTbl.ReadOnly = true;
            this.GrdBooksTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdBooksTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GrdBooksTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdBooksTbl.RowTemplate.Height = 23;
            this.GrdBooksTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdBooksTbl.Size = new System.Drawing.Size(361, 370);
            this.GrdBooksTbl.Style = MetroFramework.MetroColorStyle.Orange;
            this.GrdBooksTbl.TabIndex = 0;
            this.GrdBooksTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDivTbl_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpReleaseDate);
            this.groupBox1.Controls.Add(this.CboDivision);
            this.groupBox1.Controls.Add(this.BtnCancel);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.TxtISBN);
            this.groupBox1.Controls.Add(this.TxtNames);
            this.groupBox1.Controls.Add(this.TxtAuthor);
            this.groupBox1.Controls.Add(this.TxtPrice);
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상세";
            // 
            // DtpReleaseDate
            // 
            this.DtpReleaseDate.Location = new System.Drawing.Point(113, 151);
            this.DtpReleaseDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpReleaseDate.Name = "DtpReleaseDate";
            this.DtpReleaseDate.Size = new System.Drawing.Size(262, 29);
            this.DtpReleaseDate.TabIndex = 4;
            // 
            // CboDivision
            // 
            this.CboDivision.FormattingEnabled = true;
            this.CboDivision.ItemHeight = 23;
            this.CboDivision.Location = new System.Drawing.Point(113, 78);
            this.CboDivision.Name = "CboDivision";
            this.CboDivision.Size = new System.Drawing.Size(262, 29);
            this.CboDivision.TabIndex = 2;
            this.CboDivision.UseSelectable = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnCancel.Location = new System.Drawing.Point(300, 321);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(86, 37);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseSelectable = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnSave.Location = new System.Drawing.Point(207, 321);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(86, 37);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnNew.Location = new System.Drawing.Point(114, 321);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(86, 37);
            this.BtnNew.TabIndex = 8;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnDelete.Location = new System.Drawing.Point(21, 321);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(86, 37);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtISBN
            // 
            // 
            // 
            // 
            this.TxtISBN.CustomButton.Image = null;
            this.TxtISBN.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.TxtISBN.CustomButton.Name = "";
            this.TxtISBN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtISBN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtISBN.CustomButton.TabIndex = 1;
            this.TxtISBN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtISBN.CustomButton.UseSelectable = true;
            this.TxtISBN.CustomButton.Visible = false;
            this.TxtISBN.Lines = new string[0];
            this.TxtISBN.Location = new System.Drawing.Point(113, 186);
            this.TxtISBN.MaxLength = 200;
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.PasswordChar = '\0';
            this.TxtISBN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtISBN.SelectedText = "";
            this.TxtISBN.SelectionLength = 0;
            this.TxtISBN.SelectionStart = 0;
            this.TxtISBN.ShortcutsEnabled = true;
            this.TxtISBN.Size = new System.Drawing.Size(262, 23);
            this.TxtISBN.TabIndex = 5;
            this.TxtISBN.UseSelectable = true;
            this.TxtISBN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtISBN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtNames
            // 
            // 
            // 
            // 
            this.TxtNames.CustomButton.Image = null;
            this.TxtNames.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.TxtNames.CustomButton.Name = "";
            this.TxtNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNames.CustomButton.TabIndex = 1;
            this.TxtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNames.CustomButton.UseSelectable = true;
            this.TxtNames.CustomButton.Visible = false;
            this.TxtNames.Lines = new string[0];
            this.TxtNames.Location = new System.Drawing.Point(113, 122);
            this.TxtNames.MaxLength = 100;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.PasswordChar = '\0';
            this.TxtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNames.SelectedText = "";
            this.TxtNames.SelectionLength = 0;
            this.TxtNames.SelectionStart = 0;
            this.TxtNames.ShortcutsEnabled = true;
            this.TxtNames.Size = new System.Drawing.Size(262, 23);
            this.TxtNames.TabIndex = 3;
            this.TxtNames.UseSelectable = true;
            this.TxtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtAuthor
            // 
            // 
            // 
            // 
            this.TxtAuthor.CustomButton.Image = null;
            this.TxtAuthor.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.TxtAuthor.CustomButton.Name = "";
            this.TxtAuthor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAuthor.CustomButton.TabIndex = 1;
            this.TxtAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAuthor.CustomButton.UseSelectable = true;
            this.TxtAuthor.CustomButton.Visible = false;
            this.TxtAuthor.Lines = new string[0];
            this.TxtAuthor.Location = new System.Drawing.Point(113, 45);
            this.TxtAuthor.MaxLength = 45;
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.PasswordChar = '\0';
            this.TxtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAuthor.SelectedText = "";
            this.TxtAuthor.SelectionLength = 0;
            this.TxtAuthor.SelectionStart = 0;
            this.TxtAuthor.ShortcutsEnabled = true;
            this.TxtAuthor.Size = new System.Drawing.Size(262, 23);
            this.TxtAuthor.TabIndex = 1;
            this.TxtAuthor.UseSelectable = true;
            this.TxtAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPrice
            // 
            // 
            // 
            // 
            this.TxtPrice.CustomButton.Image = null;
            this.TxtPrice.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.TxtPrice.CustomButton.Name = "";
            this.TxtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPrice.CustomButton.TabIndex = 1;
            this.TxtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPrice.CustomButton.UseSelectable = true;
            this.TxtPrice.CustomButton.Visible = false;
            this.TxtPrice.Lines = new string[0];
            this.TxtPrice.Location = new System.Drawing.Point(116, 216);
            this.TxtPrice.MaxLength = 10;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.PasswordChar = '\0';
            this.TxtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPrice.SelectedText = "";
            this.TxtPrice.SelectionLength = 0;
            this.TxtPrice.SelectionStart = 0;
            this.TxtPrice.ShortcutsEnabled = true;
            this.TxtPrice.Size = new System.Drawing.Size(262, 23);
            this.TxtPrice.TabIndex = 6;
            this.TxtPrice.UseSelectable = true;
            this.TxtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtID
            // 
            // 
            // 
            // 
            this.TxtID.CustomButton.Image = null;
            this.TxtID.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.TxtID.CustomButton.Name = "";
            this.TxtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtID.CustomButton.TabIndex = 1;
            this.TxtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtID.CustomButton.UseSelectable = true;
            this.TxtID.CustomButton.Visible = false;
            this.TxtID.Lines = new string[0];
            this.TxtID.Location = new System.Drawing.Point(113, 16);
            this.TxtID.MaxLength = 12;
            this.TxtID.Name = "TxtID";
            this.TxtID.PasswordChar = '\0';
            this.TxtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtID.SelectedText = "";
            this.TxtID.SelectionLength = 0;
            this.TxtID.SelectionStart = 0;
            this.TxtID.ShortcutsEnabled = true;
            this.TxtID.Size = new System.Drawing.Size(262, 23);
            this.TxtID.TabIndex = 0;
            this.TxtID.UseSelectable = true;
            this.TxtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(9, 186);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 24);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "ISBN : ";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(9, 122);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 23);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "이름 : ";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(10, 215);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(100, 24);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "가격 : ";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(9, 45);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "저자명 : ";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(9, 151);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 24);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "출간일 : ";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(9, 78);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 23);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "장르 : ";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(9, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "번호 : ";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BooksMngform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BooksMngform";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "BoosMngForm";
            this.Load += new System.EventHandler(this.DivMngForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdBooksTbl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid GrdBooksTbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroTextBox TxtAuthor;
        private MetroFramework.Controls.MetroTextBox TxtID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtISBN;
        private MetroFramework.Controls.MetroTextBox TxtNames;
        private MetroFramework.Controls.MetroTextBox TxtPrice;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime DtpReleaseDate;
        private MetroFramework.Controls.MetroComboBox CboDivision;
    }
}