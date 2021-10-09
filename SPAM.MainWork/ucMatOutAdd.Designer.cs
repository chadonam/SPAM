namespace SPAM.MainWork
{
    partial class ucMatOutAdd
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
            this.calendarDouble2 = new SPAM.Common.Controls.CalendarDouble();
            this.lblOutDateQ = new System.Windows.Forms.Label();
            this.txtLOTIDQ = new System.Windows.Forms.TextBox();
            this.lblLOTIDQ = new System.Windows.Forms.Label();
            this.txtItemNoQ = new System.Windows.Forms.TextBox();
            this.lblItemNoQ = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOutDate = new System.Windows.Forms.DateTimePicker();
            this.txtOutSeq = new System.Windows.Forms.TextBox();
            this.lblOutSeq = new System.Windows.Forms.Label();
            this.txtItemSeq = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtLOTID = new System.Windows.Forms.TextBox();
            this.lblLOTID = new System.Windows.Forms.Label();
            this.cmbOutClss = new System.Windows.Forms.ComboBox();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.txtReq = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblProcSeq = new System.Windows.Forms.Label();
            this.lblItemSeq = new System.Windows.Forms.Label();
            this.lblOutClss = new System.Windows.Forms.Label();
            this.lblOutDate = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.sheetView1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.calendarDouble2);
            this.pnlHeader.Controls.Add(this.lblOutDateQ);
            this.pnlHeader.Controls.Add(this.txtLOTIDQ);
            this.pnlHeader.Controls.Add(this.lblLOTIDQ);
            this.pnlHeader.Controls.Add(this.txtItemNoQ);
            this.pnlHeader.Controls.Add(this.lblItemNoQ);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1750, 60);
            this.pnlHeader.TabIndex = 12;
            // 
            // calendarDouble2
            // 
            this.calendarDouble2.Location = new System.Drawing.Point(152, 16);
            this.calendarDouble2.Name = "calendarDouble2";
            this.calendarDouble2.Size = new System.Drawing.Size(240, 25);
            this.calendarDouble2.StartMonthDistinction = 0;
            this.calendarDouble2.TabIndex = 18;
            this.calendarDouble2.ValueEndDate = "20210926";
            this.calendarDouble2.ValueStartDate = "20210926";
            // 
            // lblOutDateQ
            // 
            this.lblOutDateQ.AutoSize = true;
            this.lblOutDateQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOutDateQ.Location = new System.Drawing.Point(28, 13);
            this.lblOutDateQ.Name = "lblOutDateQ";
            this.lblOutDateQ.Size = new System.Drawing.Size(111, 32);
            this.lblOutDateQ.TabIndex = 17;
            this.lblOutDateQ.Text = "출고일자";
            this.lblOutDateQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLOTIDQ
            // 
            this.txtLOTIDQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLOTIDQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLOTIDQ.Location = new System.Drawing.Point(868, 15);
            this.txtLOTIDQ.Name = "txtLOTIDQ";
            this.txtLOTIDQ.Size = new System.Drawing.Size(209, 35);
            this.txtLOTIDQ.TabIndex = 15;
            this.txtLOTIDQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLOTIDQ
            // 
            this.lblLOTIDQ.AutoSize = true;
            this.lblLOTIDQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLOTIDQ.Location = new System.Drawing.Point(770, 13);
            this.lblLOTIDQ.Name = "lblLOTIDQ";
            this.lblLOTIDQ.Size = new System.Drawing.Size(82, 32);
            this.lblLOTIDQ.TabIndex = 14;
            this.lblLOTIDQ.Text = "LOTID";
            this.lblLOTIDQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemNoQ
            // 
            this.txtItemNoQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNoQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemNoQ.Location = new System.Drawing.Point(536, 15);
            this.txtItemNoQ.Name = "txtItemNoQ";
            this.txtItemNoQ.Size = new System.Drawing.Size(209, 35);
            this.txtItemNoQ.TabIndex = 13;
            this.txtItemNoQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblItemNoQ
            // 
            this.lblItemNoQ.AutoSize = true;
            this.lblItemNoQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemNoQ.Location = new System.Drawing.Point(427, 13);
            this.lblItemNoQ.Name = "lblItemNoQ";
            this.lblItemNoQ.Size = new System.Drawing.Size(111, 32);
            this.lblItemNoQ.TabIndex = 12;
            this.lblItemNoQ.Text = "자재품번";
            this.lblItemNoQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSearch.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutDate);
            this.groupBox1.Controls.Add(this.txtOutSeq);
            this.groupBox1.Controls.Add(this.lblOutSeq);
            this.groupBox1.Controls.Add(this.txtItemSeq);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.lblQty);
            this.groupBox1.Controls.Add(this.txtLOTID);
            this.groupBox1.Controls.Add(this.lblLOTID);
            this.groupBox1.Controls.Add(this.cmbOutClss);
            this.groupBox1.Controls.Add(this.txtItemNo);
            this.groupBox1.Controls.Add(this.txtReq);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lblProcSeq);
            this.groupBox1.Controls.Add(this.lblItemSeq);
            this.groupBox1.Controls.Add(this.lblOutClss);
            this.groupBox1.Controls.Add(this.lblOutDate);
            this.groupBox1.Location = new System.Drawing.Point(7, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 473);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력 정보";
            // 
            // txtOutDate
            // 
            this.txtOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtOutDate.Location = new System.Drawing.Point(168, 96);
            this.txtOutDate.Name = "txtOutDate";
            this.txtOutDate.Size = new System.Drawing.Size(352, 21);
            this.txtOutDate.TabIndex = 25;
            // 
            // txtOutSeq
            // 
            this.txtOutSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOutSeq.Location = new System.Drawing.Point(171, 41);
            this.txtOutSeq.Name = "txtOutSeq";
            this.txtOutSeq.Size = new System.Drawing.Size(345, 35);
            this.txtOutSeq.TabIndex = 24;
            this.txtOutSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOutSeq
            // 
            this.lblOutSeq.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblOutSeq.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOutSeq.ForeColor = System.Drawing.Color.White;
            this.lblOutSeq.Location = new System.Drawing.Point(28, 38);
            this.lblOutSeq.Name = "lblOutSeq";
            this.lblOutSeq.Size = new System.Drawing.Size(116, 35);
            this.lblOutSeq.TabIndex = 23;
            this.lblOutSeq.Text = "출고내부코드";
            this.lblOutSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemSeq
            // 
            this.txtItemSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemSeq.Location = new System.Drawing.Point(423, 194);
            this.txtItemSeq.Name = "txtItemSeq";
            this.txtItemSeq.Size = new System.Drawing.Size(91, 35);
            this.txtItemSeq.TabIndex = 22;
            this.txtItemSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtQty.Location = new System.Drawing.Point(171, 346);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(345, 35);
            this.txtQty.TabIndex = 21;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQty
            // 
            this.lblQty.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblQty.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblQty.ForeColor = System.Drawing.Color.White;
            this.lblQty.Location = new System.Drawing.Point(28, 346);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(116, 35);
            this.lblQty.TabIndex = 20;
            this.lblQty.Text = "수량";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLOTID
            // 
            this.txtLOTID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLOTID.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLOTID.Location = new System.Drawing.Point(171, 295);
            this.txtLOTID.Name = "txtLOTID";
            this.txtLOTID.Size = new System.Drawing.Size(345, 35);
            this.txtLOTID.TabIndex = 19;
            this.txtLOTID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLOTID
            // 
            this.lblLOTID.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblLOTID.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLOTID.ForeColor = System.Drawing.Color.White;
            this.lblLOTID.Location = new System.Drawing.Point(28, 294);
            this.lblLOTID.Name = "lblLOTID";
            this.lblLOTID.Size = new System.Drawing.Size(116, 35);
            this.lblLOTID.TabIndex = 18;
            this.lblLOTID.Text = "LOTID";
            this.lblLOTID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbOutClss
            // 
            this.cmbOutClss.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbOutClss.FormattingEnabled = true;
            this.cmbOutClss.Location = new System.Drawing.Point(171, 142);
            this.cmbOutClss.Name = "cmbOutClss";
            this.cmbOutClss.Size = new System.Drawing.Size(345, 32);
            this.cmbOutClss.TabIndex = 17;
            // 
            // txtItemNo
            // 
            this.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNo.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemNo.Location = new System.Drawing.Point(171, 194);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(245, 35);
            this.txtItemNo.TabIndex = 16;
            this.txtItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemNo_KeyDown);
            // 
            // txtReq
            // 
            this.txtReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtReq.Location = new System.Drawing.Point(171, 244);
            this.txtReq.Name = "txtReq";
            this.txtReq.Size = new System.Drawing.Size(345, 35);
            this.txtReq.TabIndex = 14;
            this.txtReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.LightPink;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel.Location = new System.Drawing.Point(454, 422);
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
            this.btnSave.Location = new System.Drawing.Point(348, 422);
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
            this.btnNew.Location = new System.Drawing.Point(242, 422);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 35);
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
            this.lblProcSeq.Location = new System.Drawing.Point(28, 243);
            this.lblProcSeq.Name = "lblProcSeq";
            this.lblProcSeq.Size = new System.Drawing.Size(116, 35);
            this.lblProcSeq.TabIndex = 5;
            this.lblProcSeq.Text = "의뢰일자";
            this.lblProcSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemSeq
            // 
            this.lblItemSeq.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblItemSeq.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemSeq.ForeColor = System.Drawing.Color.White;
            this.lblItemSeq.Location = new System.Drawing.Point(28, 192);
            this.lblItemSeq.Name = "lblItemSeq";
            this.lblItemSeq.Size = new System.Drawing.Size(116, 35);
            this.lblItemSeq.TabIndex = 4;
            this.lblItemSeq.Text = "자재명";
            this.lblItemSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutClss
            // 
            this.lblOutClss.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblOutClss.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOutClss.ForeColor = System.Drawing.Color.White;
            this.lblOutClss.Location = new System.Drawing.Point(28, 141);
            this.lblOutClss.Name = "lblOutClss";
            this.lblOutClss.Size = new System.Drawing.Size(116, 35);
            this.lblOutClss.TabIndex = 2;
            this.lblOutClss.Text = "출고구분";
            this.lblOutClss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutDate
            // 
            this.lblOutDate.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblOutDate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOutDate.ForeColor = System.Drawing.Color.White;
            this.lblOutDate.Location = new System.Drawing.Point(28, 90);
            this.lblOutDate.Name = "lblOutDate";
            this.lblOutDate.Size = new System.Drawing.Size(116, 35);
            this.lblOutDate.TabIndex = 0;
            this.lblOutDate.Text = "출고일자";
            this.lblOutDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.fpSpread1);
            this.groupbox2.Location = new System.Drawing.Point(573, 71);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(1150, 600);
            this.groupbox2.TabIndex = 16;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "출고 정보";
            // 
            // fpSpread1
            // 
            this.fpSpread1.AccessibleDescription = "";
            this.fpSpread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpSpread1.Location = new System.Drawing.Point(3, 17);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.sheetView1});
            this.fpSpread1.Size = new System.Drawing.Size(1144, 580);
            this.fpSpread1.TabIndex = 0;
            this.fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpSpread1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.fpSpread1_CellClick);
            // 
            // sheetView1
            // 
            this.sheetView1.Reset();
            this.sheetView1.SheetName = "Sheet1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBarcode);
            this.groupBox3.Controls.Add(this.lblBarcode);
            this.groupBox3.Location = new System.Drawing.Point(7, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 102);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "바코드 정보";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBarcode.Location = new System.Drawing.Point(168, 45);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(345, 35);
            this.txtBarcode.TabIndex = 13;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // lblBarcode
            // 
            this.lblBarcode.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblBarcode.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBarcode.ForeColor = System.Drawing.Color.White;
            this.lblBarcode.Location = new System.Drawing.Point(28, 45);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(116, 35);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "바코드입력";
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucMatOutAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ucMatOutAdd";
            this.Size = new System.Drawing.Size(1750, 700);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Label lblProcSeq;
        private System.Windows.Forms.Label lblItemSeq;
        private System.Windows.Forms.Label lblOutClss;
        private System.Windows.Forms.Label lblOutDate;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView sheetView1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbOutClss;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.TextBox txtReq;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtItemNoQ;
        private System.Windows.Forms.Label lblItemNoQ;
        private Common.Controls.CalendarDouble calendarDouble1;
        private System.Windows.Forms.TextBox txtLOTIDQ;
        private System.Windows.Forms.Label lblLOTIDQ;
        private System.Windows.Forms.Label lblOutDateQ;
        private System.Windows.Forms.TextBox txtItemSeq;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtLOTID;
        private System.Windows.Forms.Label lblLOTID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtOutSeq;
        private System.Windows.Forms.Label lblOutSeq;
        private Common.Controls.CalendarDouble calendarDouble2;
        private System.Windows.Forms.DateTimePicker txtOutDate;
    }
}
