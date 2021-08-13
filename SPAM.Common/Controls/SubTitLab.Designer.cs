namespace SPAM.Common.Controls
{
    partial class SubTitLab
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
            this.labelCommon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCommon
            // 
            this.labelCommon.AutoSize = true;
            this.labelCommon.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCommon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(66)))), ((int)(((byte)(75)))));
            this.labelCommon.Location = new System.Drawing.Point(13, 9);
            this.labelCommon.Name = "labelCommon";
            this.labelCommon.Size = new System.Drawing.Size(46, 13);
            this.labelCommon.TabIndex = 4;
            this.labelCommon.Text = "TITLE";
            this.labelCommon.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SubTitLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCommon);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SubTitLab";
            this.Size = new System.Drawing.Size(93, 26);
            this.Load += new System.EventHandler(this.SubTitLab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCommon;
    }
}
