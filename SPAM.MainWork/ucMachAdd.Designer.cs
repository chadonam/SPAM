namespace SPAM.MainWork
{
    partial class ucMachAdd
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
            this.txtMachIDQ = new System.Windows.Forms.TextBox();
            this.lblMachIDQ = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProc = new System.Windows.Forms.ComboBox();
            this.txtMachName = new System.Windows.Forms.TextBox();
            this.txtMachID = new System.Windows.Forms.TextBox();
            this.txtMachSeq = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblProcSeq = new System.Windows.Forms.Label();
            this.lblMachName = new System.Windows.Forms.Label();
            this.lblMachID = new System.Windows.Forms.Label();
            this.lblMachSeq = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.txtMachNameQ = new System.Windows.Forms.TextBox();
            this.lblMachNameQ = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.txtMachNameQ);
            this.pnlHeader.Controls.Add(this.lblMachNameQ);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.txtMachIDQ);
            this.pnlHeader.Controls.Add(this.lblMachIDQ);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(2000, 74);
            this.pnlHeader.TabIndex = 12;
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
            // txtMachIDQ
            // 
            this.txtMachIDQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMachIDQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMachIDQ.Location = new System.Drawing.Point(159, 16);
            this.txtMachIDQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMachIDQ.Name = "txtMachIDQ";
            this.txtMachIDQ.Size = new System.Drawing.Size(239, 35);
            this.txtMachIDQ.TabIndex = 2;
            this.txtMachIDQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMachIDQ
            // 
            this.lblMachIDQ.AutoSize = true;
            this.lblMachIDQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMachIDQ.Location = new System.Drawing.Point(26, 20);
            this.lblMachIDQ.Name = "lblMachIDQ";
            this.lblMachIDQ.Size = new System.Drawing.Size(86, 32);
            this.lblMachIDQ.TabIndex = 0;
            this.lblMachIDQ.Text = "설비ID";
            this.lblMachIDQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProc);
            this.groupBox1.Controls.Add(this.txtMachName);
            this.groupBox1.Controls.Add(this.txtMachID);
            this.groupBox1.Controls.Add(this.txtMachSeq);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lblProcSeq);
            this.groupBox1.Controls.Add(this.lblMachName);
            this.groupBox1.Controls.Add(this.lblMachID);
            this.groupBox1.Controls.Add(this.lblMachSeq);
            this.groupBox1.Location = new System.Drawing.Point(8, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(640, 750);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력 정보";
            // 
            // cmbProc
            // 
            this.cmbProc.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbProc.FormattingEnabled = true;
            this.cmbProc.Location = new System.Drawing.Point(192, 259);
            this.cmbProc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProc.Name = "cmbProc";
            this.cmbProc.Size = new System.Drawing.Size(394, 32);
            this.cmbProc.TabIndex = 17;
            // 
            // txtMachName
            // 
            this.txtMachName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMachName.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMachName.Location = new System.Drawing.Point(192, 190);
            this.txtMachName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMachName.Name = "txtMachName";
            this.txtMachName.Size = new System.Drawing.Size(394, 35);
            this.txtMachName.TabIndex = 16;
            this.txtMachName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMachID
            // 
            this.txtMachID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMachID.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMachID.Location = new System.Drawing.Point(192, 126);
            this.txtMachID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMachID.Name = "txtMachID";
            this.txtMachID.Size = new System.Drawing.Size(394, 35);
            this.txtMachID.TabIndex = 14;
            this.txtMachID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMachSeq
            // 
            this.txtMachSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMachSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMachSeq.Location = new System.Drawing.Point(192, 61);
            this.txtMachSeq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMachSeq.Name = "txtMachSeq";
            this.txtMachSeq.Size = new System.Drawing.Size(394, 35);
            this.txtMachSeq.TabIndex = 13;
            this.txtMachSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LightPink;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(277, 640);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 44);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "신규";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblProcSeq
            // 
            this.lblProcSeq.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblProcSeq.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProcSeq.ForeColor = System.Drawing.Color.White;
            this.lblProcSeq.Location = new System.Drawing.Point(29, 255);
            this.lblProcSeq.Name = "lblProcSeq";
            this.lblProcSeq.Size = new System.Drawing.Size(133, 44);
            this.lblProcSeq.TabIndex = 5;
            this.lblProcSeq.Text = "공정";
            this.lblProcSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMachName
            // 
            this.lblMachName.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblMachName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMachName.ForeColor = System.Drawing.Color.White;
            this.lblMachName.Location = new System.Drawing.Point(29, 190);
            this.lblMachName.Name = "lblMachName";
            this.lblMachName.Size = new System.Drawing.Size(133, 44);
            this.lblMachName.TabIndex = 4;
            this.lblMachName.Text = "설비명";
            this.lblMachName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMachID
            // 
            this.lblMachID.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblMachID.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMachID.ForeColor = System.Drawing.Color.White;
            this.lblMachID.Location = new System.Drawing.Point(29, 126);
            this.lblMachID.Name = "lblMachID";
            this.lblMachID.Size = new System.Drawing.Size(133, 44);
            this.lblMachID.TabIndex = 2;
            this.lblMachID.Text = "설비ID";
            this.lblMachID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMachSeq
            // 
            this.lblMachSeq.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblMachSeq.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMachSeq.ForeColor = System.Drawing.Color.White;
            this.lblMachSeq.Location = new System.Drawing.Point(29, 61);
            this.lblMachSeq.Name = "lblMachSeq";
            this.lblMachSeq.Size = new System.Drawing.Size(133, 44);
            this.lblMachSeq.TabIndex = 0;
            this.lblMachSeq.Text = "설비내부코드";
            this.lblMachSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.fpSpread1);
            this.groupbox2.Location = new System.Drawing.Point(655, 89);
            this.groupbox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox2.Size = new System.Drawing.Size(1314, 750);
            this.groupbox2.TabIndex = 16;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "공정 정보";
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
            this.fpSpread1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.fpSpread1_CellClick);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // txtMachNameQ
            // 
            this.txtMachNameQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMachNameQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMachNameQ.Location = new System.Drawing.Point(552, 16);
            this.txtMachNameQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMachNameQ.Name = "txtMachNameQ";
            this.txtMachNameQ.Size = new System.Drawing.Size(239, 35);
            this.txtMachNameQ.TabIndex = 13;
            this.txtMachNameQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMachNameQ
            // 
            this.lblMachNameQ.AutoSize = true;
            this.lblMachNameQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMachNameQ.Location = new System.Drawing.Point(419, 20);
            this.lblMachNameQ.Name = "lblMachNameQ";
            this.lblMachNameQ.Size = new System.Drawing.Size(87, 32);
            this.lblMachNameQ.TabIndex = 12;
            this.lblMachNameQ.Text = "설비명";
            this.lblMachNameQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucMachAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucMachAdd";
            this.Size = new System.Drawing.Size(2000, 875);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Label lblProcSeq;
        private System.Windows.Forms.Label lblMachName;
        private System.Windows.Forms.Label lblMachID;
        private System.Windows.Forms.Label lblMachSeq;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblMachIDQ;
        private System.Windows.Forms.TextBox txtMachIDQ;
        private System.Windows.Forms.ComboBox cmbProc;
        private System.Windows.Forms.TextBox txtMachName;
        private System.Windows.Forms.TextBox txtMachID;
        private System.Windows.Forms.TextBox txtMachSeq;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMachNameQ;
        private System.Windows.Forms.Label lblMachNameQ;
    }
}
