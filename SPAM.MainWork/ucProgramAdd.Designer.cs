namespace SPAM.MainWork
{
    partial class ucProgramAdd
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
            this.txtPgmNameQ = new System.Windows.Forms.TextBox();
            this.lblPgmNameQ = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPgmIDQ = new System.Windows.Forms.TextBox();
            this.lblPgmIDQ = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPgmName = new System.Windows.Forms.TextBox();
            this.txtPgmID = new System.Windows.Forms.TextBox();
            this.txtPgmSeq = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblPgmName = new System.Windows.Forms.Label();
            this.lblPgmID = new System.Windows.Forms.Label();
            this.lblPgmSeq = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
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
            this.pnlHeader.Controls.Add(this.txtPgmNameQ);
            this.pnlHeader.Controls.Add(this.lblPgmNameQ);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.txtPgmIDQ);
            this.pnlHeader.Controls.Add(this.lblPgmIDQ);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(2000, 74);
            this.pnlHeader.TabIndex = 12;
            // 
            // txtPgmNameQ
            // 
            this.txtPgmNameQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPgmNameQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPgmNameQ.Location = new System.Drawing.Point(629, 20);
            this.txtPgmNameQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPgmNameQ.Name = "txtPgmNameQ";
            this.txtPgmNameQ.Size = new System.Drawing.Size(239, 35);
            this.txtPgmNameQ.TabIndex = 13;
            this.txtPgmNameQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPgmNameQ
            // 
            this.lblPgmNameQ.AutoSize = true;
            this.lblPgmNameQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPgmNameQ.Location = new System.Drawing.Point(455, 20);
            this.lblPgmNameQ.Name = "lblPgmNameQ";
            this.lblPgmNameQ.Size = new System.Drawing.Size(135, 32);
            this.lblPgmNameQ.TabIndex = 12;
            this.lblPgmNameQ.Text = "프로그램명";
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
            // txtPgmIDQ
            // 
            this.txtPgmIDQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPgmIDQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPgmIDQ.Location = new System.Drawing.Point(188, 19);
            this.txtPgmIDQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPgmIDQ.Name = "txtPgmIDQ";
            this.txtPgmIDQ.Size = new System.Drawing.Size(239, 35);
            this.txtPgmIDQ.TabIndex = 2;
            this.txtPgmIDQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPgmIDQ
            // 
            this.lblPgmIDQ.AutoSize = true;
            this.lblPgmIDQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPgmIDQ.Location = new System.Drawing.Point(26, 20);
            this.lblPgmIDQ.Name = "lblPgmIDQ";
            this.lblPgmIDQ.Size = new System.Drawing.Size(134, 32);
            this.lblPgmIDQ.TabIndex = 0;
            this.lblPgmIDQ.Text = "프로그램ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPgmName);
            this.groupBox1.Controls.Add(this.txtPgmID);
            this.groupBox1.Controls.Add(this.txtPgmSeq);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lblPgmName);
            this.groupBox1.Controls.Add(this.lblPgmID);
            this.groupBox1.Controls.Add(this.lblPgmSeq);
            this.groupBox1.Location = new System.Drawing.Point(8, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(640, 750);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력정보";
            // 
            // txtPgmName
            // 
            this.txtPgmName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPgmName.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPgmName.Location = new System.Drawing.Point(192, 190);
            this.txtPgmName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPgmName.Name = "txtPgmName";
            this.txtPgmName.Size = new System.Drawing.Size(394, 35);
            this.txtPgmName.TabIndex = 16;
            this.txtPgmName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPgmID
            // 
            this.txtPgmID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPgmID.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPgmID.Location = new System.Drawing.Point(192, 126);
            this.txtPgmID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPgmID.Name = "txtPgmID";
            this.txtPgmID.Size = new System.Drawing.Size(394, 35);
            this.txtPgmID.TabIndex = 14;
            this.txtPgmID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPgmSeq
            // 
            this.txtPgmSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPgmSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPgmSeq.Location = new System.Drawing.Point(192, 61);
            this.txtPgmSeq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPgmSeq.Name = "txtPgmSeq";
            this.txtPgmSeq.Size = new System.Drawing.Size(394, 35);
            this.txtPgmSeq.TabIndex = 13;
            this.txtPgmSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // lblPgmName
            // 
            this.lblPgmName.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblPgmName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPgmName.ForeColor = System.Drawing.Color.White;
            this.lblPgmName.Location = new System.Drawing.Point(29, 190);
            this.lblPgmName.Name = "lblPgmName";
            this.lblPgmName.Size = new System.Drawing.Size(133, 44);
            this.lblPgmName.TabIndex = 4;
            this.lblPgmName.Text = "프로그램명";
            this.lblPgmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgmID
            // 
            this.lblPgmID.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblPgmID.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPgmID.ForeColor = System.Drawing.Color.White;
            this.lblPgmID.Location = new System.Drawing.Point(29, 126);
            this.lblPgmID.Name = "lblPgmID";
            this.lblPgmID.Size = new System.Drawing.Size(133, 44);
            this.lblPgmID.TabIndex = 2;
            this.lblPgmID.Text = "프로그램ID";
            this.lblPgmID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgmSeq
            // 
            this.lblPgmSeq.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblPgmSeq.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPgmSeq.ForeColor = System.Drawing.Color.White;
            this.lblPgmSeq.Location = new System.Drawing.Point(29, 61);
            this.lblPgmSeq.Name = "lblPgmSeq";
            this.lblPgmSeq.Size = new System.Drawing.Size(133, 44);
            this.lblPgmSeq.TabIndex = 0;
            this.lblPgmSeq.Text = "프로그램코드";
            this.lblPgmSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.groupbox2.Text = "조회정보";
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
            // ucProgramAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucProgramAdd";
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
        private System.Windows.Forms.Label lblPgmName;
        private System.Windows.Forms.Label lblPgmID;
        private System.Windows.Forms.Label lblPgmSeq;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblPgmIDQ;
        private System.Windows.Forms.TextBox txtPgmIDQ;
        private System.Windows.Forms.TextBox txtPgmName;
        private System.Windows.Forms.TextBox txtPgmID;
        private System.Windows.Forms.TextBox txtPgmSeq;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPgmNameQ;
        private System.Windows.Forms.Label lblPgmNameQ;
    }
}
