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
            this.lblOutDateQ = new System.Windows.Forms.Label();
            this.calendarDouble1 = new SPAM.Common.Controls.CalendarDouble();
            this.txtLOTIDQ = new System.Windows.Forms.TextBox();
            this.lblLOTIDQ = new System.Windows.Forms.Label();
            this.txtItemSeqQ = new System.Windows.Forms.TextBox();
            this.lblItemSeqQ = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOutSeq = new System.Windows.Forms.TextBox();
            this.lblOutSeq = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtLOTID = new System.Windows.Forms.TextBox();
            this.lblLOTID = new System.Windows.Forms.Label();
            this.cmbOutClss = new System.Windows.Forms.ComboBox();
            this.txtItemSeq = new System.Windows.Forms.TextBox();
            this.txtMachID = new System.Windows.Forms.TextBox();
            this.txtOutDate = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblProcSeq = new System.Windows.Forms.Label();
            this.lblItemSeq = new System.Windows.Forms.Label();
            this.lblOutClss = new System.Windows.Forms.Label();
            this.lblOutDate = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblOutDateQ);
            this.pnlHeader.Controls.Add(this.calendarDouble1);
            this.pnlHeader.Controls.Add(this.txtLOTIDQ);
            this.pnlHeader.Controls.Add(this.lblLOTIDQ);
            this.pnlHeader.Controls.Add(this.txtItemSeqQ);
            this.pnlHeader.Controls.Add(this.lblItemSeqQ);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(2000, 74);
            this.pnlHeader.TabIndex = 12;
            // 
            // lblOutDateQ
            // 
            this.lblOutDateQ.AutoSize = true;
            this.lblOutDateQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOutDateQ.Location = new System.Drawing.Point(32, 16);
            this.lblOutDateQ.Name = "lblOutDateQ";
            this.lblOutDateQ.Size = new System.Drawing.Size(111, 32);
            this.lblOutDateQ.TabIndex = 17;
            this.lblOutDateQ.Text = "출고일자";
            this.lblOutDateQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calendarDouble1
            // 
            this.calendarDouble1.Location = new System.Drawing.Point(168, 16);
            this.calendarDouble1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calendarDouble1.Name = "calendarDouble1";
            this.calendarDouble1.Size = new System.Drawing.Size(274, 31);
            this.calendarDouble1.StartMonthDistinction = 0;
            this.calendarDouble1.TabIndex = 16;
            this.calendarDouble1.ValueEndDate = "20210814";
            this.calendarDouble1.ValueStartDate = "20210814";
            // 
            // txtLOTIDQ
            // 
            this.txtLOTIDQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLOTIDQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLOTIDQ.Location = new System.Drawing.Point(992, 16);
            this.txtLOTIDQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLOTIDQ.Name = "txtLOTIDQ";
            this.txtLOTIDQ.Size = new System.Drawing.Size(239, 35);
            this.txtLOTIDQ.TabIndex = 15;
            this.txtLOTIDQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLOTIDQ
            // 
            this.lblLOTIDQ.AutoSize = true;
            this.lblLOTIDQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLOTIDQ.Location = new System.Drawing.Point(880, 16);
            this.lblLOTIDQ.Name = "lblLOTIDQ";
            this.lblLOTIDQ.Size = new System.Drawing.Size(82, 32);
            this.lblLOTIDQ.TabIndex = 14;
            this.lblLOTIDQ.Text = "LOTID";
            this.lblLOTIDQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemSeqQ
            // 
            this.txtItemSeqQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemSeqQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemSeqQ.Location = new System.Drawing.Point(600, 16);
            this.txtItemSeqQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemSeqQ.Name = "txtItemSeqQ";
            this.txtItemSeqQ.Size = new System.Drawing.Size(239, 35);
            this.txtItemSeqQ.TabIndex = 13;
            this.txtItemSeqQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblItemSeqQ
            // 
            this.lblItemSeqQ.AutoSize = true;
            this.lblItemSeqQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemSeqQ.Location = new System.Drawing.Point(488, 16);
            this.lblItemSeqQ.Name = "lblItemSeqQ";
            this.lblItemSeqQ.Size = new System.Drawing.Size(87, 32);
            this.lblItemSeqQ.TabIndex = 12;
            this.lblItemSeqQ.Text = "자재명";
            this.lblItemSeqQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutSeq);
            this.groupBox1.Controls.Add(this.lblOutSeq);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.lblQty);
            this.groupBox1.Controls.Add(this.txtLOTID);
            this.groupBox1.Controls.Add(this.lblLOTID);
            this.groupBox1.Controls.Add(this.cmbOutClss);
            this.groupBox1.Controls.Add(this.txtItemSeq);
            this.groupBox1.Controls.Add(this.txtMachID);
            this.groupBox1.Controls.Add(this.txtOutDate);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lblProcSeq);
            this.groupBox1.Controls.Add(this.lblItemSeq);
            this.groupBox1.Controls.Add(this.lblOutClss);
            this.groupBox1.Controls.Add(this.lblOutDate);
            this.groupBox1.Location = new System.Drawing.Point(8, 248);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(640, 591);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력 정보";
            // 
            // txtOutSeq
            // 
            this.txtOutSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOutSeq.Location = new System.Drawing.Point(195, 51);
            this.txtOutSeq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutSeq.Name = "txtOutSeq";
            this.txtOutSeq.Size = new System.Drawing.Size(394, 35);
            this.txtOutSeq.TabIndex = 24;
            this.txtOutSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOutSeq
            // 
            this.lblOutSeq.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblOutSeq.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOutSeq.ForeColor = System.Drawing.Color.White;
            this.lblOutSeq.Location = new System.Drawing.Point(32, 48);
            this.lblOutSeq.Name = "lblOutSeq";
            this.lblOutSeq.Size = new System.Drawing.Size(133, 44);
            this.lblOutSeq.TabIndex = 23;
            this.lblOutSeq.Text = "출고내부코드";
            this.lblOutSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5.Location = new System.Drawing.Point(483, 242);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(104, 35);
            this.textBox5.TabIndex = 22;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtQty.Location = new System.Drawing.Point(195, 433);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(394, 35);
            this.txtQty.TabIndex = 21;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQty
            // 
            this.lblQty.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblQty.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblQty.ForeColor = System.Drawing.Color.White;
            this.lblQty.Location = new System.Drawing.Point(32, 432);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(133, 44);
            this.lblQty.TabIndex = 20;
            this.lblQty.Text = "수량";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLOTID
            // 
            this.txtLOTID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLOTID.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLOTID.Location = new System.Drawing.Point(195, 369);
            this.txtLOTID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLOTID.Name = "txtLOTID";
            this.txtLOTID.Size = new System.Drawing.Size(394, 35);
            this.txtLOTID.TabIndex = 19;
            this.txtLOTID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLOTID
            // 
            this.lblLOTID.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblLOTID.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLOTID.ForeColor = System.Drawing.Color.White;
            this.lblLOTID.Location = new System.Drawing.Point(32, 368);
            this.lblLOTID.Name = "lblLOTID";
            this.lblLOTID.Size = new System.Drawing.Size(133, 44);
            this.lblLOTID.TabIndex = 18;
            this.lblLOTID.Text = "LOTID";
            this.lblLOTID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbOutClss
            // 
            this.cmbOutClss.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbOutClss.FormattingEnabled = true;
            this.cmbOutClss.Location = new System.Drawing.Point(195, 178);
            this.cmbOutClss.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOutClss.Name = "cmbOutClss";
            this.cmbOutClss.Size = new System.Drawing.Size(394, 32);
            this.cmbOutClss.TabIndex = 17;
            // 
            // txtItemSeq
            // 
            this.txtItemSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemSeq.Location = new System.Drawing.Point(195, 242);
            this.txtItemSeq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemSeq.Name = "txtItemSeq";
            this.txtItemSeq.Size = new System.Drawing.Size(280, 35);
            this.txtItemSeq.TabIndex = 16;
            this.txtItemSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMachID
            // 
            this.txtMachID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMachID.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMachID.Location = new System.Drawing.Point(195, 305);
            this.txtMachID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMachID.Name = "txtMachID";
            this.txtMachID.Size = new System.Drawing.Size(394, 35);
            this.txtMachID.TabIndex = 14;
            this.txtMachID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOutDate
            // 
            this.txtOutDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutDate.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOutDate.Location = new System.Drawing.Point(195, 115);
            this.txtOutDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutDate.Name = "txtOutDate";
            this.txtOutDate.Size = new System.Drawing.Size(394, 35);
            this.txtOutDate.TabIndex = 13;
            this.txtOutDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.LightPink;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel.Location = new System.Drawing.Point(519, 528);
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
            this.btnSave.Location = new System.Drawing.Point(398, 528);
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
            this.btnNew.Location = new System.Drawing.Point(277, 528);
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
            this.lblProcSeq.Location = new System.Drawing.Point(32, 304);
            this.lblProcSeq.Name = "lblProcSeq";
            this.lblProcSeq.Size = new System.Drawing.Size(133, 44);
            this.lblProcSeq.TabIndex = 5;
            this.lblProcSeq.Text = "의뢰일자";
            this.lblProcSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemSeq
            // 
            this.lblItemSeq.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblItemSeq.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemSeq.ForeColor = System.Drawing.Color.White;
            this.lblItemSeq.Location = new System.Drawing.Point(32, 240);
            this.lblItemSeq.Name = "lblItemSeq";
            this.lblItemSeq.Size = new System.Drawing.Size(133, 44);
            this.lblItemSeq.TabIndex = 4;
            this.lblItemSeq.Text = "자재명";
            this.lblItemSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutClss
            // 
            this.lblOutClss.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblOutClss.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOutClss.ForeColor = System.Drawing.Color.White;
            this.lblOutClss.Location = new System.Drawing.Point(32, 176);
            this.lblOutClss.Name = "lblOutClss";
            this.lblOutClss.Size = new System.Drawing.Size(133, 44);
            this.lblOutClss.TabIndex = 2;
            this.lblOutClss.Text = "출고구분";
            this.lblOutClss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutDate
            // 
            this.lblOutDate.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblOutDate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOutDate.ForeColor = System.Drawing.Color.White;
            this.lblOutDate.Location = new System.Drawing.Point(32, 112);
            this.lblOutDate.Name = "lblOutDate";
            this.lblOutDate.Size = new System.Drawing.Size(133, 44);
            this.lblOutDate.TabIndex = 0;
            this.lblOutDate.Text = "출고일자";
            this.lblOutDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.groupbox2.Text = "출고 정보";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBarcode);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(8, 104);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(640, 128);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "바코드 정보";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBarcode.Location = new System.Drawing.Point(192, 56);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(394, 35);
            this.txtBarcode.TabIndex = 13;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MidnightBlue;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 44);
            this.label6.TabIndex = 0;
            this.label6.Text = "바코드입력";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucMatOutAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucMatOutAdd";
            this.Size = new System.Drawing.Size(2000, 875);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
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
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbOutClss;
        private System.Windows.Forms.TextBox txtItemSeq;
        private System.Windows.Forms.TextBox txtMachID;
        private System.Windows.Forms.TextBox txtOutDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtItemSeqQ;
        private System.Windows.Forms.Label lblItemSeqQ;
        private Common.Controls.CalendarDouble calendarDouble1;
        private System.Windows.Forms.TextBox txtLOTIDQ;
        private System.Windows.Forms.Label lblLOTIDQ;
        private System.Windows.Forms.Label lblOutDateQ;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtLOTID;
        private System.Windows.Forms.Label lblLOTID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOutSeq;
        private System.Windows.Forms.Label lblOutSeq;
    }
}
