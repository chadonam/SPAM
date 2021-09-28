
namespace SPAM.MainWork
{
    partial class ucMesAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVNL = new System.Windows.Forms.TextBox();
            this.txtKoL = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEtc = new System.Windows.Forms.Button();
            this.lblVNL = new System.Windows.Forms.Label();
            this.lblKoL = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMesQ = new System.Windows.Forms.TextBox();
            this.lblMesQ = new System.Windows.Forms.Label();
            this.btnEtc2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEtc2);
            this.groupBox1.Controls.Add(this.txtVNL);
            this.groupBox1.Controls.Add(this.txtKoL);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnEtc);
            this.groupBox1.Controls.Add(this.lblVNL);
            this.groupBox1.Controls.Add(this.lblKoL);
            this.groupBox1.Location = new System.Drawing.Point(24, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(640, 750);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력정보";
            // 
            // txtVNL
            // 
            this.txtVNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVNL.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtVNL.Location = new System.Drawing.Point(192, 232);
            this.txtVNL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVNL.Name = "txtVNL";
            this.txtVNL.Size = new System.Drawing.Size(394, 42);
            this.txtVNL.TabIndex = 14;
            this.txtVNL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKoL
            // 
            this.txtKoL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKoL.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtKoL.Location = new System.Drawing.Point(192, 61);
            this.txtKoL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKoL.Name = "txtKoL";
            this.txtKoL.Size = new System.Drawing.Size(394, 42);
            this.txtKoL.TabIndex = 13;
            this.txtKoL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.LightPink;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel.Location = new System.Drawing.Point(519, 640);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(114, 44);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightPink;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(398, 640);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 44);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEtc
            // 
            this.btnEtc.BackColor = System.Drawing.Color.LightPink;
            this.btnEtc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtc.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEtc.ForeColor = System.Drawing.Color.Black;
            this.btnEtc.Location = new System.Drawing.Point(277, 640);
            this.btnEtc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEtc.Name = "btnEtc";
            this.btnEtc.Size = new System.Drawing.Size(114, 44);
            this.btnEtc.TabIndex = 10;
            this.btnEtc.Text = "초기화";
            this.btnEtc.UseVisualStyleBackColor = false;
            this.btnEtc.Click += new System.EventHandler(this.btnEtc_Click);
            // 
            // lblVNL
            // 
            this.lblVNL.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblVNL.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblVNL.ForeColor = System.Drawing.Color.White;
            this.lblVNL.Location = new System.Drawing.Point(29, 232);
            this.lblVNL.Name = "lblVNL";
            this.lblVNL.Size = new System.Drawing.Size(133, 44);
            this.lblVNL.TabIndex = 2;
            this.lblVNL.Text = "베트남어";
            this.lblVNL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKoL
            // 
            this.lblKoL.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblKoL.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKoL.ForeColor = System.Drawing.Color.White;
            this.lblKoL.Location = new System.Drawing.Point(29, 61);
            this.lblKoL.Name = "lblKoL";
            this.lblKoL.Size = new System.Drawing.Size(133, 44);
            this.lblKoL.TabIndex = 0;
            this.lblKoL.Text = "한국어";
            this.lblKoL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.fpSpread1);
            this.groupbox2.Location = new System.Drawing.Point(672, 112);
            this.groupbox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox2.Size = new System.Drawing.Size(1314, 750);
            this.groupbox2.TabIndex = 17;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "메세지정보";
            // 
            // fpSpread1
            // 
            this.fpSpread1.AccessibleDescription = "";
            this.fpSpread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpSpread1.Location = new System.Drawing.Point(3, 22);
            this.fpSpread1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.fpSpread1.Size = new System.Drawing.Size(1308, 724);
            this.fpSpread1.TabIndex = 0;
            this.fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpSpread1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.fpSpread1_CellClick_1);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.txtMesQ);
            this.pnlHeader.Controls.Add(this.lblMesQ);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(2500, 93);
            this.pnlHeader.TabIndex = 18;
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
            this.btnSearch.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // txtMesQ
            // 
            this.txtMesQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMesQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMesQ.Location = new System.Drawing.Point(159, 24);
            this.txtMesQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMesQ.Name = "txtMesQ";
            this.txtMesQ.Size = new System.Drawing.Size(239, 42);
            this.txtMesQ.TabIndex = 2;
            this.txtMesQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMesQ
            // 
            this.lblMesQ.AutoSize = true;
            this.lblMesQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMesQ.Location = new System.Drawing.Point(26, 20);
            this.lblMesQ.Name = "lblMesQ";
            this.lblMesQ.Size = new System.Drawing.Size(108, 41);
            this.lblMesQ.TabIndex = 0;
            this.lblMesQ.Text = "메세지";
            this.lblMesQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEtc2
            // 
            this.btnEtc2.BackColor = System.Drawing.Color.LightPink;
            this.btnEtc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtc2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEtc2.ForeColor = System.Drawing.Color.Black;
            this.btnEtc2.Location = new System.Drawing.Point(156, 640);
            this.btnEtc2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEtc2.Name = "btnEtc2";
            this.btnEtc2.Size = new System.Drawing.Size(114, 44);
            this.btnEtc2.TabIndex = 15;
            this.btnEtc2.Text = "번역";
            this.btnEtc2.UseVisualStyleBackColor = false;
            // 
            // ucMesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucMesAdd";
            this.Size = new System.Drawing.Size(2500, 1094);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVNL;
        private System.Windows.Forms.TextBox txtKoL;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEtc;
        private System.Windows.Forms.Label lblVNL;
        private System.Windows.Forms.Label lblKoL;
        private System.Windows.Forms.GroupBox groupbox2;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMesQ;
        private System.Windows.Forms.Label lblMesQ;
        private System.Windows.Forms.Button btnEtc2;
    }
}
