namespace TrafficInfo.SubItems
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnSearch = new MetroFramework.Controls.MetroButton();
            this.TxtSearchItem = new MetroFramework.Controls.MetroTextBox();
            this.DgvSearchItems = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.MtlBack = new MetroFramework.Controls.MetroTile();
            this.INCIDENTDESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGISTDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INCIDENTCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchItems)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1218, 546);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.splitContainer1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1210, 506);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "돌발이벤트";
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
            this.splitContainer1.Panel1.Controls.Add(this.BtnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.TxtSearchItem);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvSearchItems);
            this.splitContainer1.Size = new System.Drawing.Size(1210, 506);
            this.splitContainer1.SplitterDistance = 34;
            this.splitContainer1.TabIndex = 2;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(1132, 2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 30);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSearchItem
            // 
            this.TxtSearchItem.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtSearchItem.Location = new System.Drawing.Point(871, 3);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(255, 30);
            this.TxtSearchItem.TabIndex = 0;
            this.TxtSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchItem_KeyPress);
            // 
            // DgvSearchItems
            // 
            this.DgvSearchItems.AllowUserToAddRows = false;
            this.DgvSearchItems.AllowUserToDeleteRows = false;
            this.DgvSearchItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.INCIDENTDESC,
            this.REGISTDATE,
            this.INCIDENTCODE,
            this.X,
            this.Y,
            this.TITLE});
            this.DgvSearchItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSearchItems.Location = new System.Drawing.Point(0, 0);
            this.DgvSearchItems.Name = "DgvSearchItems";
            this.DgvSearchItems.RowTemplate.Height = 23;
            this.DgvSearchItems.Size = new System.Drawing.Size(1210, 468);
            this.DgvSearchItems.TabIndex = 0;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1210, 506);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // MtlBack
            // 
            this.MtlBack.Location = new System.Drawing.Point(1172, 615);
            this.MtlBack.Name = "MtlBack";
            this.MtlBack.Size = new System.Drawing.Size(69, 43);
            this.MtlBack.TabIndex = 1;
            this.MtlBack.TileImage = global::TrafficInfo.Properties.Resources.back2;
            this.MtlBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlBack.UseTileImage = true;
            this.MtlBack.Click += new System.EventHandler(this.MtlBack_Click);
            // 
            // INCIDENTDESC
            // 
            this.INCIDENTDESC.HeaderText = "교통사고 개요";
            this.INCIDENTDESC.Name = "INCIDENTDESC";
            this.INCIDENTDESC.Width = 200;
            // 
            // REGISTDATE
            // 
            this.REGISTDATE.HeaderText = "교통사고 시간";
            this.REGISTDATE.Name = "REGISTDATE";
            this.REGISTDATE.Width = 120;
            // 
            // INCIDENTCODE
            // 
            this.INCIDENTCODE.HeaderText = "돌발상황 유형";
            this.INCIDENTCODE.Name = "INCIDENTCODE";
            this.INCIDENTCODE.Width = 150;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // TITLE
            // 
            this.TITLE.HeaderText = "교통사고 위치";
            this.TITLE.Name = "TITLE";
            this.TITLE.Width = 150;
            // 
            // SearchItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MtlBack);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "SearchItemForm";
            this.Text = "돌발이벤트 정보조회서비스";
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

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTile MtlBack;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton BtnSearch;
        private MetroFramework.Controls.MetroTextBox TxtSearchItem;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView DgvSearchItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn INCIDENTDESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGISTDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INCIDENTCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITLE;
    }
}