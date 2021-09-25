
namespace SPAM.MainWork
{
    partial class ucItemProc
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtItemNoQ = new System.Windows.Forms.TextBox();
            this.lblItemProcNoQ = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEtc = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtItemSeqQ = new System.Windows.Forms.TextBox();
            this.txtItemNameQ = new System.Windows.Forms.TextBox();
            this.groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(1617, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtItemNoQ
            // 
            this.txtItemNoQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNoQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemNoQ.Location = new System.Drawing.Point(165, 19);
            this.txtItemNoQ.Name = "txtItemNoQ";
            this.txtItemNoQ.Size = new System.Drawing.Size(245, 35);
            this.txtItemNoQ.TabIndex = 25;
            this.txtItemNoQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemNoQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemNoQ_KeyDown);
            // 
            // lblItemProcNoQ
            // 
            this.lblItemProcNoQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemProcNoQ.Location = new System.Drawing.Point(16, 21);
            this.lblItemProcNoQ.Name = "lblItemProcNoQ";
            this.lblItemProcNoQ.Size = new System.Drawing.Size(144, 32);
            this.lblItemProcNoQ.TabIndex = 24;
            this.lblItemProcNoQ.Text = "품목번호";
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.fpSpread1);
            this.groupbox2.Location = new System.Drawing.Point(19, 82);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(1712, 513);
            this.groupbox2.TabIndex = 26;
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
            this.fpSpread1.Size = new System.Drawing.Size(1706, 493);
            this.fpSpread1.TabIndex = 0;
            this.fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.LightPink;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel.Location = new System.Drawing.Point(1617, 621);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 35);
            this.btnDel.TabIndex = 29;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEtc
            // 
            this.btnEtc.BackColor = System.Drawing.Color.LightPink;
            this.btnEtc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtc.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEtc.Location = new System.Drawing.Point(1386, 621);
            this.btnEtc.Name = "btnEtc";
            this.btnEtc.Size = new System.Drawing.Size(100, 35);
            this.btnEtc.TabIndex = 28;
            this.btnEtc.Text = "행추가";
            this.btnEtc.UseVisualStyleBackColor = false;
            this.btnEtc.Click += new System.EventHandler(this.btnEtc_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightPink;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(1503, 620);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "추가";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtItemSeqQ
            // 
            this.txtItemSeqQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemSeqQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemSeqQ.Location = new System.Drawing.Point(431, 19);
            this.txtItemSeqQ.Name = "txtItemSeqQ";
            this.txtItemSeqQ.ReadOnly = true;
            this.txtItemSeqQ.Size = new System.Drawing.Size(166, 35);
            this.txtItemSeqQ.TabIndex = 31;
            this.txtItemSeqQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemNameQ
            // 
            this.txtItemNameQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNameQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemNameQ.Location = new System.Drawing.Point(618, 18);
            this.txtItemNameQ.Name = "txtItemNameQ";
            this.txtItemNameQ.ReadOnly = true;
            this.txtItemNameQ.Size = new System.Drawing.Size(366, 35);
            this.txtItemNameQ.TabIndex = 32;
            this.txtItemNameQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ucItemProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtItemNameQ);
            this.Controls.Add(this.txtItemSeqQ);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEtc);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtItemNoQ);
            this.Controls.Add(this.lblItemProcNoQ);
            this.Controls.Add(this.groupbox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucItemProc";
            this.Size = new System.Drawing.Size(1750, 700);
            this.groupbox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtItemNoQ;
        private System.Windows.Forms.Label lblItemProcNoQ;
        private System.Windows.Forms.GroupBox groupbox2;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEtc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtItemSeqQ;
        private System.Windows.Forms.TextBox txtItemNameQ;
    }
}
