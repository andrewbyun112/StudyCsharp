namespace AccidentSearch.SubItems
{
    partial class SearchItemForm
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
            this.MtlBack = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnSearch = new MetroFramework.Controls.MetroButton();
            this.DgvSearchItems = new System.Windows.Forms.DataGridView();
            this.TxtSearchItem = new MetroFramework.Controls.MetroTextBox();
            this.orgNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgAddrDtl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchItems)).BeginInit();
            this.SuspendLayout();
            // 
            // MtlBack
            // 
            this.MtlBack.Location = new System.Drawing.Point(900, 550);
            this.MtlBack.Name = "MtlBack";
            this.MtlBack.Size = new System.Drawing.Size(77, 27);
            this.MtlBack.TabIndex = 0;
            this.MtlBack.Text = "Back";
            this.MtlBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlBack.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MtlBack.Click += new System.EventHandler(this.MtlBack_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(953, 480);
            this.metroTabControl1.TabIndex = 1;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.splitContainer1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(945, 440);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "결과";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.TxtSearchItem);
            this.splitContainer1.Panel1.Controls.Add(this.BtnSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvSearchItems);
            this.splitContainer1.Size = new System.Drawing.Size(945, 440);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 2;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(849, 4);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(93, 35);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DgvSearchItems
            // 
            this.DgvSearchItems.AllowUserToAddRows = false;
            this.DgvSearchItems.AllowUserToDeleteRows = false;
            this.DgvSearchItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orgNm,
            this.memberNm,
            this.orgAddr,
            this.orgAddrDtl,
            this.tel});
            this.DgvSearchItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSearchItems.Location = new System.Drawing.Point(0, 0);
            this.DgvSearchItems.Name = "DgvSearchItems";
            this.DgvSearchItems.RowTemplate.Height = 23;
            this.DgvSearchItems.Size = new System.Drawing.Size(945, 394);
            this.DgvSearchItems.TabIndex = 0;
            // 
            // TxtSearchItem
            // 
            this.TxtSearchItem.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtSearchItem.Location = new System.Drawing.Point(642, 5);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(201, 35);
            this.TxtSearchItem.TabIndex = 1;
            this.TxtSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchItem_KeyPress);
            // 
            // orgNm
            // 
            this.orgNm.HeaderText = "병원이름";
            this.orgNm.Name = "orgNm";
            // 
            // memberNm
            // 
            this.memberNm.HeaderText = "대표자명";
            this.memberNm.Name = "memberNm";
            // 
            // orgAddr
            // 
            this.orgAddr.HeaderText = "주소";
            this.orgAddr.Name = "orgAddr";
            // 
            // orgAddrDtl
            // 
            this.orgAddrDtl.HeaderText = "상세주소";
            this.orgAddrDtl.Name = "orgAddrDtl";
            // 
            // tel
            // 
            this.tel.HeaderText = "전화번호";
            this.tel.Name = "tel";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel1.Location = new System.Drawing.Point(588, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "지역 : ";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.MtlBack);
            this.Name = "SearchItemForm";
            this.Text = "등록대행업체 지역검색";
            this.Load += new System.EventHandler(this.SearchItemForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MtlBack;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton BtnSearch;
        private System.Windows.Forms.DataGridView DgvSearchItems;
        private MetroFramework.Controls.MetroTextBox TxtSearchItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgAddrDtl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}