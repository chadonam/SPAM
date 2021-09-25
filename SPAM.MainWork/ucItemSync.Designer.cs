
namespace SPAM.MainWork
{
    partial class ucItemSync
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
            this.txtItemNoQ = new System.Windows.Forms.TextBox();
            this.lblItemNoQ = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEtc = new System.Windows.Forms.Button();
            this.groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemNoQ
            // 
            this.txtItemNoQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNoQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemNoQ.Location = new System.Drawing.Point(164, 15);
            this.txtItemNoQ.Name = "txtItemNoQ";
            this.txtItemNoQ.Size = new System.Drawing.Size(209, 35);
            this.txtItemNoQ.TabIndex = 18;
            this.txtItemNoQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblItemNoQ
            // 
            this.lblItemNoQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemNoQ.Location = new System.Drawing.Point(23, 16);
            this.lblItemNoQ.Name = "lblItemNoQ";
            this.lblItemNoQ.Size = new System.Drawing.Size(125, 34);
            this.lblItemNoQ.TabIndex = 17;
            this.lblItemNoQ.Text = "품목번호";
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.fpSpread1);
            this.groupbox2.Location = new System.Drawing.Point(21, 78);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(1712, 600);
            this.groupbox2.TabIndex = 22;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "품목정보";
            // 
            // fpSpread1
            // 
            this.fpSpread1.AccessibleDescription = "";
            this.fpSpread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpSpread1.Location = new System.Drawing.Point(3, 17);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.fpSpread1.Size = new System.Drawing.Size(1706, 580);
            this.fpSpread1.TabIndex = 0;
            this.fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(1619, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEtc
            // 
            this.btnEtc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEtc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtc.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEtc.ForeColor = System.Drawing.Color.Black;
            this.btnEtc.Location = new System.Drawing.Point(1494, 14);
            this.btnEtc.Name = "btnEtc";
            this.btnEtc.Size = new System.Drawing.Size(100, 35);
            this.btnEtc.TabIndex = 24;
            this.btnEtc.Text = "연동";
            this.btnEtc.UseVisualStyleBackColor = false;
            this.btnEtc.Click += new System.EventHandler(this.btnEtc_Click);
            // 
            // ucItemSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEtc);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtItemNoQ);
            this.Controls.Add(this.lblItemNoQ);
            this.Controls.Add(this.groupbox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucItemSync";
            this.Size = new System.Drawing.Size(1750, 700);
            this.groupbox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemNoQ;
        private System.Windows.Forms.Label lblItemNoQ;
        private System.Windows.Forms.GroupBox groupbox2;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEtc;
    }
}
