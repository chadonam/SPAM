namespace SPAM.Common.Controls
{
    partial class SearchCntLab
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblListTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblListTotal
            // 
            this.lblListTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListTotal.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblListTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(88)))), ((int)(((byte)(92)))));
            this.lblListTotal.Location = new System.Drawing.Point(0, 0);
            this.lblListTotal.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblListTotal.Name = "lblListTotal";
            this.lblListTotal.Size = new System.Drawing.Size(170, 15);
            this.lblListTotal.TabIndex = 13;
            this.lblListTotal.Text = "전체 : 0건";
            this.lblListTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // SearchCntLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblListTotal);
            this.Name = "SearchCntLab";
            this.Size = new System.Drawing.Size(170, 15);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblListTotal;
    }
}
