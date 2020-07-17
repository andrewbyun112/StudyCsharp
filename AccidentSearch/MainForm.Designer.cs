namespace AccidentSearch
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.MtlSearchItem = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(274, 63);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(175, 112);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile2.TabIndex = 0;
            this.metroTile2.Text = "준비중...";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = global::AccidentSearch.Properties.Resources.iconfinder_Facebook_UI_07_2344289;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseTileImage = true;
            // 
            // MtlSearchItem
            // 
            this.MtlSearchItem.Location = new System.Drawing.Point(23, 63);
            this.MtlSearchItem.Name = "MtlSearchItem";
            this.MtlSearchItem.Size = new System.Drawing.Size(245, 112);
            this.MtlSearchItem.Style = MetroFramework.MetroColorStyle.Teal;
            this.MtlSearchItem.TabIndex = 0;
            this.MtlSearchItem.Text = "반려동물 등록대행업체 조회 ";
            this.MtlSearchItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MtlSearchItem.TileImage = global::AccidentSearch.Properties.Resources.iconfinder_ic_pets_48px_3669300;
            this.MtlSearchItem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlSearchItem.UseTileImage = true;
            this.MtlSearchItem.Click += new System.EventHandler(this.MtlSearchItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.MtlSearchItem);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "반려동물 등록대행업체 조회 서비스";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MtlSearchItem;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}

