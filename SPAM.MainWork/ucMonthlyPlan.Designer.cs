
namespace SPAM.MainWork
{
    partial class ucMonthlyPlan
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
            this.txtPlanID = new System.Windows.Forms.TextBox();
            this.lblProNameQ = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.txtPlanNameQ = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.date = new SPAM.Common.Controls.CalendarDouble();
            this.lblDateQ = new System.Windows.Forms.Label();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblPgmName = new System.Windows.Forms.Label();
            this.lblPlanID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPlanSeq = new System.Windows.Forms.TextBox();
            this.txtItemSeq = new System.Windows.Forms.TextBox();
            this.txtStartD = new System.Windows.Forms.TextBox();
            this.lblStartD = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndD = new System.Windows.Forms.TextBox();
            this.lblEndD = new System.Windows.Forms.Label();
            this.txtProcSeq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlanSeq = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.groupbox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPlanID
            // 
            this.txtPlanID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanID.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanID.Location = new System.Drawing.Point(168, 101);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.Size = new System.Drawing.Size(345, 35);
            this.txtPlanID.TabIndex = 14;
            this.txtPlanID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProNameQ
            // 
            this.lblProNameQ.AutoSize = true;
            this.lblProNameQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProNameQ.Location = new System.Drawing.Point(672, 16);
            this.lblProNameQ.Name = "lblProNameQ";
            this.lblProNameQ.Size = new System.Drawing.Size(111, 32);
            this.lblProNameQ.TabIndex = 12;
            this.lblProNameQ.Text = "제품품번";
            // 
            // txtItemNo
            // 
            this.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNo.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemNo.Location = new System.Drawing.Point(168, 152);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(232, 35);
            this.txtItemNo.TabIndex = 16;
            this.txtItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemNo_KeyDown);
            // 
            // txtPlanNameQ
            // 
            this.txtPlanNameQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanNameQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanNameQ.Location = new System.Drawing.Point(824, 16);
            this.txtPlanNameQ.Name = "txtPlanNameQ";
            this.txtPlanNameQ.Size = new System.Drawing.Size(209, 35);
            this.txtPlanNameQ.TabIndex = 13;
            this.txtPlanNameQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.date);
            this.pnlHeader.Controls.Add(this.txtPlanNameQ);
            this.pnlHeader.Controls.Add(this.lblProNameQ);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.lblDateQ);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1750, 60);
            this.pnlHeader.TabIndex = 17;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(160, 16);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(240, 25);
            this.date.StartMonthDistinction = 0;
            this.date.TabIndex = 14;
            this.date.ValueEndDate = "20210827";
            this.date.ValueStartDate = "20210827";
            // 
            // lblDateQ
            // 
            this.lblDateQ.AutoSize = true;
            this.lblDateQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDateQ.Location = new System.Drawing.Point(23, 16);
            this.lblDateQ.Name = "lblDateQ";
            this.lblDateQ.Size = new System.Drawing.Size(63, 32);
            this.lblDateQ.TabIndex = 0;
            this.lblDateQ.Text = "기간";
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
            this.fpSpread1.Size = new System.Drawing.Size(1144, 580);
            this.fpSpread1.TabIndex = 0;
            this.fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpSpread1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.fpSpread1_CellClick_1);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.fpSpread1);
            this.groupbox2.Location = new System.Drawing.Point(573, 86);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(1150, 600);
            this.groupbox2.TabIndex = 19;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "조회정보";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.LightPink;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel.Location = new System.Drawing.Point(454, 512);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 35);
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
            this.btnSave.Location = new System.Drawing.Point(348, 512);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
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
            this.btnNew.Location = new System.Drawing.Point(242, 512);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 35);
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
            this.lblPgmName.Location = new System.Drawing.Point(25, 152);
            this.lblPgmName.Name = "lblPgmName";
            this.lblPgmName.Size = new System.Drawing.Size(116, 35);
            this.lblPgmName.TabIndex = 4;
            this.lblPgmName.Text = "제품품번";
            this.lblPgmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlanID
            // 
            this.lblPlanID.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblPlanID.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPlanID.ForeColor = System.Drawing.Color.White;
            this.lblPlanID.Location = new System.Drawing.Point(25, 101);
            this.lblPlanID.Name = "lblPlanID";
            this.lblPlanID.Size = new System.Drawing.Size(116, 35);
            this.lblPlanID.TabIndex = 2;
            this.lblPlanID.Text = "계획번호";
            this.lblPlanID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPlanSeq);
            this.groupBox1.Controls.Add(this.txtItemSeq);
            this.groupBox1.Controls.Add(this.txtStartD);
            this.groupBox1.Controls.Add(this.lblStartD);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQuan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEndD);
            this.groupBox1.Controls.Add(this.lblEndD);
            this.groupBox1.Controls.Add(this.txtProcSeq);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtItemNo);
            this.groupBox1.Controls.Add(this.txtPlanID);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lblPgmName);
            this.groupBox1.Controls.Add(this.lblPlanID);
            this.groupBox1.Controls.Add(this.lblPlanSeq);
            this.groupBox1.Location = new System.Drawing.Point(8, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 600);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력정보";
            // 
            // txtPlanSeq
            // 
            this.txtPlanSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanSeq.Location = new System.Drawing.Point(168, 48);
            this.txtPlanSeq.Name = "txtPlanSeq";
            this.txtPlanSeq.Size = new System.Drawing.Size(345, 35);
            this.txtPlanSeq.TabIndex = 28;
            this.txtPlanSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemSeq
            // 
            this.txtItemSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemSeq.Location = new System.Drawing.Point(408, 152);
            this.txtItemSeq.Name = "txtItemSeq";
            this.txtItemSeq.Size = new System.Drawing.Size(104, 35);
            this.txtItemSeq.TabIndex = 27;
            this.txtItemSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStartD
            // 
            this.txtStartD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartD.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStartD.Location = new System.Drawing.Point(168, 248);
            this.txtStartD.Name = "txtStartD";
            this.txtStartD.Size = new System.Drawing.Size(345, 35);
            this.txtStartD.TabIndex = 26;
            this.txtStartD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStartD
            // 
            this.lblStartD.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblStartD.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStartD.ForeColor = System.Drawing.Color.White;
            this.lblStartD.Location = new System.Drawing.Point(25, 248);
            this.lblStartD.Name = "lblStartD";
            this.lblStartD.Size = new System.Drawing.Size(116, 35);
            this.lblStartD.TabIndex = 25;
            this.lblStartD.Text = "시작일자";
            this.lblStartD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNote.Location = new System.Drawing.Point(167, 392);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(345, 35);
            this.txtNote.TabIndex = 24;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 35);
            this.label5.TabIndex = 23;
            this.label5.Text = "비고";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuan
            // 
            this.txtQuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuan.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtQuan.Location = new System.Drawing.Point(167, 352);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(345, 35);
            this.txtQuan.TabIndex = 22;
            this.txtQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 35);
            this.label4.TabIndex = 21;
            this.label4.Text = "수량";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEndD
            // 
            this.txtEndD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndD.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEndD.Location = new System.Drawing.Point(168, 288);
            this.txtEndD.Name = "txtEndD";
            this.txtEndD.Size = new System.Drawing.Size(345, 35);
            this.txtEndD.TabIndex = 20;
            this.txtEndD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEndD
            // 
            this.lblEndD.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblEndD.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEndD.ForeColor = System.Drawing.Color.White;
            this.lblEndD.Location = new System.Drawing.Point(25, 288);
            this.lblEndD.Name = "lblEndD";
            this.lblEndD.Size = new System.Drawing.Size(116, 35);
            this.lblEndD.TabIndex = 19;
            this.lblEndD.Text = "종료일자";
            this.lblEndD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProcSeq
            // 
            this.txtProcSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcSeq.Location = new System.Drawing.Point(167, 192);
            this.txtProcSeq.Name = "txtProcSeq";
            this.txtProcSeq.Size = new System.Drawing.Size(345, 35);
            this.txtProcSeq.TabIndex = 18;
            this.txtProcSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "공정순서";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlanSeq
            // 
            this.lblPlanSeq.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblPlanSeq.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPlanSeq.ForeColor = System.Drawing.Color.White;
            this.lblPlanSeq.Location = new System.Drawing.Point(25, 49);
            this.lblPlanSeq.Name = "lblPlanSeq";
            this.lblPlanSeq.Size = new System.Drawing.Size(116, 35);
            this.lblPlanSeq.TabIndex = 0;
            this.lblPlanSeq.Text = "계획내부코드";
            this.lblPlanSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucMonthlyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucMonthlyPlan";
            this.Size = new System.Drawing.Size(1750, 700);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.groupbox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPlanID;
        private System.Windows.Forms.Label lblProNameQ;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.TextBox txtPlanNameQ;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDateQ;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblPgmName;
        private System.Windows.Forms.Label lblPlanID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndD;
        private System.Windows.Forms.Label lblEndD;
        private System.Windows.Forms.TextBox txtProcSeq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlanSeq;
        private Common.Controls.CalendarDouble date;
        private System.Windows.Forms.TextBox txtStartD;
        private System.Windows.Forms.Label lblStartD;
        private System.Windows.Forms.TextBox txtItemSeq;
        private System.Windows.Forms.TextBox txtPlanSeq;
    }
}
