
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMatinNum = new System.Windows.Forms.TextBox();
            this.txtLOTID = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtItemSeq = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtMatin = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMatinNum = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblLotid1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMatinName1 = new System.Windows.Forms.Label();
            this.lblMatin1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMatinLOTID = new System.Windows.Forms.TextBox();
            this.lblMatinLOTID = new System.Windows.Forms.Label();
            this.txtMatinName = new System.Windows.Forms.TextBox();
            this.lblMatinName = new System.Windows.Forms.Label();
            this.lblMatin = new System.Windows.Forms.Label();
            this.calendarDouble1 = new SPAM.Common.Controls.CalendarDouble();
            this.groupBox3.SuspendLayout();
            this.groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCode);
            this.groupBox3.Controls.Add(this.lblCode);
            this.groupBox3.Location = new System.Drawing.Point(8, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 200);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "바코드정보";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCode.Location = new System.Drawing.Point(168, 88);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(345, 35);
            this.txtCode.TabIndex = 13;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblCode.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCode.ForeColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(25, 88);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(116, 35);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "바코드 입력";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.fpSpread1);
            this.groupbox2.Location = new System.Drawing.Point(576, 86);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(1150, 600);
            this.groupbox2.TabIndex = 21;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "사용자정보";
            // 
            // fpSpread1
            // 
            this.fpSpread1.AccessibleDescription = "fpSpread1, Sheet1, Row 0, Column 0, ";
            this.fpSpread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpSpread1.Location = new System.Drawing.Point(3, 17);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.fpSpread1.Size = new System.Drawing.Size(1144, 580);
            this.fpSpread1.TabIndex = 0;
            this.fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpSpread1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.fpSpread1_CellClick);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMatinNum);
            this.groupBox1.Controls.Add(this.txtLOTID);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtItemSeq);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.txtMatin);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblMatinNum);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lblLotid1);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblMatinName1);
            this.groupBox1.Controls.Add(this.lblMatin1);
            this.groupBox1.Location = new System.Drawing.Point(8, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 384);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력정보";
            // 
            // txtMatinNum
            // 
            this.txtMatinNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatinNum.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMatinNum.Location = new System.Drawing.Point(168, 253);
            this.txtMatinNum.Name = "txtMatinNum";
            this.txtMatinNum.Size = new System.Drawing.Size(345, 35);
            this.txtMatinNum.TabIndex = 16;
            this.txtMatinNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLOTID
            // 
            this.txtLOTID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLOTID.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLOTID.Location = new System.Drawing.Point(168, 204);
            this.txtLOTID.Name = "txtLOTID";
            this.txtLOTID.Size = new System.Drawing.Size(345, 35);
            this.txtLOTID.TabIndex = 14;
            this.txtLOTID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDate.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDate.Location = new System.Drawing.Point(168, 152);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(345, 35);
            this.txtDate.TabIndex = 16;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemSeq
            // 
            this.txtItemSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemSeq.Location = new System.Drawing.Point(376, 101);
            this.txtItemSeq.Name = "txtItemSeq";
            this.txtItemSeq.Size = new System.Drawing.Size(136, 35);
            this.txtItemSeq.TabIndex = 14;
            this.txtItemSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemName.Location = new System.Drawing.Point(168, 101);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(200, 35);
            this.txtItemName.TabIndex = 14;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMatin
            // 
            this.txtMatin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatin.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMatin.Location = new System.Drawing.Point(168, 49);
            this.txtMatin.Name = "txtMatin";
            this.txtMatin.Size = new System.Drawing.Size(345, 35);
            this.txtMatin.TabIndex = 13;
            this.txtMatin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.LightPink;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel.Location = new System.Drawing.Point(448, 328);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 35);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightPink;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(342, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // lblMatinNum
            // 
            this.lblMatinNum.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblMatinNum.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMatinNum.ForeColor = System.Drawing.Color.White;
            this.lblMatinNum.Location = new System.Drawing.Point(25, 253);
            this.lblMatinNum.Name = "lblMatinNum";
            this.lblMatinNum.Size = new System.Drawing.Size(116, 35);
            this.lblMatinNum.TabIndex = 5;
            this.lblMatinNum.Text = "수량";
            this.lblMatinNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LightPink;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(236, 328);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 35);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "신규";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // lblLotid1
            // 
            this.lblLotid1.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblLotid1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLotid1.ForeColor = System.Drawing.Color.White;
            this.lblLotid1.Location = new System.Drawing.Point(25, 204);
            this.lblLotid1.Name = "lblLotid1";
            this.lblLotid1.Size = new System.Drawing.Size(116, 35);
            this.lblLotid1.TabIndex = 5;
            this.lblLotid1.Text = "LOTID";
            this.lblLotid1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblDate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(25, 152);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(116, 35);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "의뢰일자";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatinName1
            // 
            this.lblMatinName1.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblMatinName1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMatinName1.ForeColor = System.Drawing.Color.White;
            this.lblMatinName1.Location = new System.Drawing.Point(25, 101);
            this.lblMatinName1.Name = "lblMatinName1";
            this.lblMatinName1.Size = new System.Drawing.Size(116, 35);
            this.lblMatinName1.TabIndex = 2;
            this.lblMatinName1.Text = "자재명";
            this.lblMatinName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatin1
            // 
            this.lblMatin1.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblMatin1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMatin1.ForeColor = System.Drawing.Color.White;
            this.lblMatin1.Location = new System.Drawing.Point(25, 49);
            this.lblMatin1.Name = "lblMatin1";
            this.lblMatin1.Size = new System.Drawing.Size(116, 35);
            this.lblMatin1.TabIndex = 0;
            this.lblMatin1.Text = "입고내부코드";
            this.lblMatin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.calendarDouble1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtMatinLOTID);
            this.panel1.Controls.Add(this.lblMatinLOTID);
            this.panel1.Controls.Add(this.txtMatinName);
            this.panel1.Controls.Add(this.lblMatinName);
            this.panel1.Controls.Add(this.lblMatin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1750, 60);
            this.panel1.TabIndex = 19;
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
            // txtMatinLOTID
            // 
            this.txtMatinLOTID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatinLOTID.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMatinLOTID.Location = new System.Drawing.Point(1056, 13);
            this.txtMatinLOTID.Name = "txtMatinLOTID";
            this.txtMatinLOTID.Size = new System.Drawing.Size(209, 35);
            this.txtMatinLOTID.TabIndex = 2;
            this.txtMatinLOTID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMatinLOTID
            // 
            this.lblMatinLOTID.AutoSize = true;
            this.lblMatinLOTID.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMatinLOTID.Location = new System.Drawing.Point(952, 13);
            this.lblMatinLOTID.Name = "lblMatinLOTID";
            this.lblMatinLOTID.Size = new System.Drawing.Size(82, 32);
            this.lblMatinLOTID.TabIndex = 0;
            this.lblMatinLOTID.Text = "LOTID";
            this.lblMatinLOTID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMatinName
            // 
            this.txtMatinName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatinName.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMatinName.Location = new System.Drawing.Point(656, 13);
            this.txtMatinName.Name = "txtMatinName";
            this.txtMatinName.Size = new System.Drawing.Size(209, 35);
            this.txtMatinName.TabIndex = 2;
            this.txtMatinName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMatinName
            // 
            this.lblMatinName.AutoSize = true;
            this.lblMatinName.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMatinName.Location = new System.Drawing.Point(552, 13);
            this.lblMatinName.Name = "lblMatinName";
            this.lblMatinName.Size = new System.Drawing.Size(87, 32);
            this.lblMatinName.TabIndex = 0;
            this.lblMatinName.Text = "자재명";
            this.lblMatinName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatin
            // 
            this.lblMatin.AutoSize = true;
            this.lblMatin.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMatin.Location = new System.Drawing.Point(31, 13);
            this.lblMatin.Name = "lblMatin";
            this.lblMatin.Size = new System.Drawing.Size(111, 32);
            this.lblMatin.TabIndex = 0;
            this.lblMatin.Text = "입고일자";
            this.lblMatin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calendarDouble1
            // 
            this.calendarDouble1.Location = new System.Drawing.Point(184, 16);
            this.calendarDouble1.Name = "calendarDouble1";
            this.calendarDouble1.Size = new System.Drawing.Size(240, 25);
            this.calendarDouble1.StartMonthDistinction = 0;
            this.calendarDouble1.TabIndex = 12;
            this.calendarDouble1.ValueEndDate = "20210821";
            this.calendarDouble1.ValueStartDate = "20210821";
            // 
            // ucMatIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucMatIn";
            this.Size = new System.Drawing.Size(1750, 700);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.GroupBox groupbox2;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMatinNum;
        private System.Windows.Forms.TextBox txtLOTID;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtItemSeq;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtMatin;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMatinNum;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblLotid1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMatinName1;
        private System.Windows.Forms.Label lblMatin1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMatinLOTID;
        private System.Windows.Forms.Label lblMatinLOTID;
        private System.Windows.Forms.TextBox txtMatinName;
        private System.Windows.Forms.Label lblMatinName;
        private System.Windows.Forms.Label lblMatin;
        private Common.Controls.CalendarDouble calendarDouble1;
    }
}
