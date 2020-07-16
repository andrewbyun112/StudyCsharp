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
            this.TxtSearchItem = new MetroFramework.Controls.MetroTextBox();
            this.DgvSearchItems = new System.Windows.Forms.DataGridView();
            this.sido_sgg_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spot_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occrrnc_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caslt_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dth_dnv_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.se_dnv_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl_dnv_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wnd_dnv_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
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
            // TxtSearchItem
            // 
            this.TxtSearchItem.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtSearchItem.Location = new System.Drawing.Point(642, 5);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(201, 35);
            this.TxtSearchItem.TabIndex = 1;
            this.TxtSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchItem_KeyPress);
            // 
            // DgvSearchItems
            // 
            this.DgvSearchItems.AllowUserToAddRows = false;
            this.DgvSearchItems.AllowUserToDeleteRows = false;
            this.DgvSearchItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sido_sgg_nm,
            this.spot_nm,
            this.occrrnc_cnt,
            this.caslt_cnt,
            this.dth_dnv_cnt,
            this.se_dnv_cnt,
            this.sl_dnv_cnt,
            this.wnd_dnv_cnt});
            this.DgvSearchItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSearchItems.Location = new System.Drawing.Point(0, 0);
            this.DgvSearchItems.Name = "DgvSearchItems";
            this.DgvSearchItems.RowTemplate.Height = 23;
            this.DgvSearchItems.Size = new System.Drawing.Size(945, 394);
            this.DgvSearchItems.TabIndex = 0;
            // 
            // sido_sgg_nm
            // 
            this.sido_sgg_nm.HeaderText = "시도시군구명";
            this.sido_sgg_nm.Name = "sido_sgg_nm";
            // 
            // spot_nm
            // 
            this.spot_nm.HeaderText = "지점명";
            this.spot_nm.Name = "spot_nm";
            // 
            // occrrnc_cnt
            // 
            this.occrrnc_cnt.HeaderText = "발생건수";
            this.occrrnc_cnt.Name = "occrrnc_cnt";
            // 
            // caslt_cnt
            // 
            this.caslt_cnt.HeaderText = "사상자수";
            this.caslt_cnt.Name = "caslt_cnt";
            // 
            // dth_dnv_cnt
            // 
            this.dth_dnv_cnt.HeaderText = "사망자수";
            this.dth_dnv_cnt.Name = "dth_dnv_cnt";
            // 
            // se_dnv_cnt
            // 
            this.se_dnv_cnt.HeaderText = "중상자수";
            this.se_dnv_cnt.Name = "se_dnv_cnt";
            // 
            // sl_dnv_cnt
            // 
            this.sl_dnv_cnt.HeaderText = "경상자수";
            this.sl_dnv_cnt.Name = "sl_dnv_cnt";
            // 
            // wnd_dnv_cnt
            // 
            this.wnd_dnv_cnt.HeaderText = "부상신고자수";
            this.wnd_dnv_cnt.Name = "wnd_dnv_cnt";
            // 
            // SearchItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.MtlBack);
            this.Name = "SearchItemForm";
            this.Text = "SearchItemForm";
            this.Load += new System.EventHandler(this.SearchItemForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTextBox TxtSearchItem;
        private MetroFramework.Controls.MetroButton BtnSearch;
        private System.Windows.Forms.DataGridView DgvSearchItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn sido_sgg_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn spot_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn occrrnc_cnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn caslt_cnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dth_dnv_cnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn se_dnv_cnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl_dnv_cnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn wnd_dnv_cnt;
    }
}