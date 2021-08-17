
namespace SPAM.MainWork
{
    partial class ucMatIn
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtUserIDQ = new System.Windows.Forms.TextBox();
            this.lblUserIDQ = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.txtUserIDQ);
            this.pnlHeader.Controls.Add(this.lblUserIDQ);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(2000, 74);
            this.pnlHeader.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(1850, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 44);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtUserIDQ
            // 
            this.txtUserIDQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserIDQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserIDQ.Location = new System.Drawing.Point(159, 16);
            this.txtUserIDQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserIDQ.Name = "txtUserIDQ";
            this.txtUserIDQ.Size = new System.Drawing.Size(239, 35);
            this.txtUserIDQ.TabIndex = 2;
            this.txtUserIDQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUserIDQ
            // 
            this.lblUserIDQ.AutoSize = true;
            this.lblUserIDQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserIDQ.Location = new System.Drawing.Point(26, 20);
            this.lblUserIDQ.Name = "lblUserIDQ";
            this.lblUserIDQ.Size = new System.Drawing.Size(110, 32);
            this.lblUserIDQ.TabIndex = 0;
            this.lblUserIDQ.Text = "사용자ID";
            this.lblUserIDQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucMatIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHeader);
            this.Name = "ucMatIn";
            this.Size = new System.Drawing.Size(2000, 875);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtUserIDQ;
        private System.Windows.Forms.Label lblUserIDQ;
    }
}
