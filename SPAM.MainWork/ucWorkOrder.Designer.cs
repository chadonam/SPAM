
namespace SPAM.MainWork
{
    partial class ucWorkOrder
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
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbItemProc = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.txtItemSeq = new System.Windows.Forms.TextBox();
            this.txtPlanSeq = new System.Windows.Forms.TextBox();
            this.txtPlanNo = new System.Windows.Forms.TextBox();
            this.txtOrderSeq = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProcSeq = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.lbOrderNo = new System.Windows.Forms.Label();
            this.lblWorkDate = new System.Windows.Forms.Label();
            this.lbItemSeq = new System.Windows.Forms.Label();
            this.lblPlanSeq = new System.Windows.Forms.Label();
            this.lblOrderSeq = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbProc = new System.Windows.Forms.ComboBox();
            this.calendarDouble1 = new SPAM.Common.Controls.CalendarDouble();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblWOName = new System.Windows.Forms.Label();
            this.txtItemNoQ = new System.Windows.Forms.TextBox();
            this.lblWOID = new System.Windows.Forms.Label();
            this.lblWOLength = new System.Windows.Forms.Label();
            this.groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.fpSpread1);
            this.groupbox2.Location = new System.Drawing.Point(576, 93);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(1150, 600);
            this.groupbox2.TabIndex = 25;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "WO목록";
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
            this.fpSpread1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.fpSpread1_CellClick_1);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cmbItemProc);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.txtOrderNo);
            this.groupBox1.Controls.Add(this.txtItemNo);
            this.groupBox1.Controls.Add(this.txtItemSeq);
            this.groupBox1.Controls.Add(this.txtPlanSeq);
            this.groupBox1.Controls.Add(this.txtPlanNo);
            this.groupBox1.Controls.Add(this.txtOrderSeq);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblProcSeq);
            this.groupBox1.Controls.Add(this.lblRemark);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lblQty);
            this.groupBox1.Controls.Add(this.lbOrderNo);
            this.groupBox1.Controls.Add(this.lblWorkDate);
            this.groupBox1.Controls.Add(this.lbItemSeq);
            this.groupBox1.Controls.Add(this.lblPlanSeq);
            this.groupBox1.Controls.Add(this.lblOrderSeq);
            this.groupBox1.Location = new System.Drawing.Point(8, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 597);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력정보";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 336);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // cmbItemProc
            // 
            this.cmbItemProc.Font = new System.Drawing.Font("굴림", 18F);
            this.cmbItemProc.FormattingEnabled = true;
            this.cmbItemProc.Location = new System.Drawing.Point(168, 280);
            this.cmbItemProc.Name = "cmbItemProc";
            this.cmbItemProc.Size = new System.Drawing.Size(344, 32);
            this.cmbItemProc.TabIndex = 17;
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRemark.Location = new System.Drawing.Point(168, 432);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(345, 35);
            this.txtRemark.TabIndex = 14;
            this.txtRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtQty.Location = new System.Drawing.Point(168, 376);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(345, 35);
            this.txtQty.TabIndex = 16;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderNo.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOrderNo.Location = new System.Drawing.Point(168, 228);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(345, 35);
            this.txtOrderNo.TabIndex = 14;
            this.txtOrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemNo
            // 
            this.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNo.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemNo.Location = new System.Drawing.Point(168, 176);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(224, 35);
            this.txtItemNo.TabIndex = 16;
            this.txtItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemSeq_KeyDown);
            // 
            // txtItemSeq
            // 
            this.txtItemSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemSeq.Location = new System.Drawing.Point(400, 176);
            this.txtItemSeq.Name = "txtItemSeq";
            this.txtItemSeq.Size = new System.Drawing.Size(112, 35);
            this.txtItemSeq.TabIndex = 13;
            this.txtItemSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPlanSeq
            // 
            this.txtPlanSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanSeq.Location = new System.Drawing.Point(400, 125);
            this.txtPlanSeq.Name = "txtPlanSeq";
            this.txtPlanSeq.Size = new System.Drawing.Size(112, 35);
            this.txtPlanSeq.TabIndex = 13;
            this.txtPlanSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPlanNo
            // 
            this.txtPlanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanNo.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanNo.Location = new System.Drawing.Point(168, 125);
            this.txtPlanNo.Name = "txtPlanNo";
            this.txtPlanNo.Size = new System.Drawing.Size(224, 35);
            this.txtPlanNo.TabIndex = 13;
            this.txtPlanNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPlanNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlanSeq_KeyDown);
            this.txtPlanNo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtPlanNo_MouseDoubleClick);
            // 
            // txtOrderSeq
            // 
            this.txtOrderSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOrderSeq.Location = new System.Drawing.Point(168, 73);
            this.txtOrderSeq.Name = "txtOrderSeq";
            this.txtOrderSeq.Size = new System.Drawing.Size(345, 35);
            this.txtOrderSeq.TabIndex = 13;
            this.txtOrderSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.LightPink;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel.Location = new System.Drawing.Point(448, 544);
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
            this.btnSave.Location = new System.Drawing.Point(342, 544);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblProcSeq
            // 
            this.lblProcSeq.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblProcSeq.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProcSeq.ForeColor = System.Drawing.Color.White;
            this.lblProcSeq.Location = new System.Drawing.Point(25, 277);
            this.lblProcSeq.Name = "lblProcSeq";
            this.lblProcSeq.Size = new System.Drawing.Size(116, 35);
            this.lblProcSeq.TabIndex = 5;
            this.lblProcSeq.Text = "공정";
            this.lblProcSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemark
            // 
            this.lblRemark.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblRemark.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRemark.ForeColor = System.Drawing.Color.White;
            this.lblRemark.Location = new System.Drawing.Point(24, 432);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(116, 35);
            this.lblRemark.TabIndex = 5;
            this.lblRemark.Text = "지시사항";
            this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LightPink;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(236, 544);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 35);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "신규";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblQty
            // 
            this.lblQty.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblQty.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblQty.ForeColor = System.Drawing.Color.White;
            this.lblQty.Location = new System.Drawing.Point(24, 379);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(116, 35);
            this.lblQty.TabIndex = 4;
            this.lblQty.Text = "수량";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOrderNo
            // 
            this.lbOrderNo.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbOrderNo.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbOrderNo.ForeColor = System.Drawing.Color.White;
            this.lbOrderNo.Location = new System.Drawing.Point(25, 228);
            this.lbOrderNo.Name = "lbOrderNo";
            this.lbOrderNo.Size = new System.Drawing.Size(116, 35);
            this.lbOrderNo.TabIndex = 5;
            this.lbOrderNo.Text = "WO번호";
            this.lbOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWorkDate
            // 
            this.lblWorkDate.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblWorkDate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorkDate.ForeColor = System.Drawing.Color.White;
            this.lblWorkDate.Location = new System.Drawing.Point(24, 328);
            this.lblWorkDate.Name = "lblWorkDate";
            this.lblWorkDate.Size = new System.Drawing.Size(116, 35);
            this.lblWorkDate.TabIndex = 2;
            this.lblWorkDate.Text = "작업일자";
            this.lblWorkDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbItemSeq
            // 
            this.lbItemSeq.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbItemSeq.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbItemSeq.ForeColor = System.Drawing.Color.White;
            this.lbItemSeq.Location = new System.Drawing.Point(25, 176);
            this.lbItemSeq.Name = "lbItemSeq";
            this.lbItemSeq.Size = new System.Drawing.Size(116, 35);
            this.lbItemSeq.TabIndex = 4;
            this.lbItemSeq.Text = "제품품번";
            this.lbItemSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlanSeq
            // 
            this.lblPlanSeq.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblPlanSeq.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPlanSeq.ForeColor = System.Drawing.Color.White;
            this.lblPlanSeq.Location = new System.Drawing.Point(25, 125);
            this.lblPlanSeq.Name = "lblPlanSeq";
            this.lblPlanSeq.Size = new System.Drawing.Size(116, 35);
            this.lblPlanSeq.TabIndex = 2;
            this.lblPlanSeq.Text = "계획번호";
            this.lblPlanSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderSeq
            // 
            this.lblOrderSeq.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblOrderSeq.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOrderSeq.ForeColor = System.Drawing.Color.White;
            this.lblOrderSeq.Location = new System.Drawing.Point(25, 73);
            this.lblOrderSeq.Name = "lblOrderSeq";
            this.lblOrderSeq.Size = new System.Drawing.Size(116, 35);
            this.lblOrderSeq.TabIndex = 0;
            this.lblOrderSeq.Text = "WO내부코드";
            this.lblOrderSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbProc);
            this.panel1.Controls.Add(this.calendarDouble1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblWOName);
            this.panel1.Controls.Add(this.txtItemNoQ);
            this.panel1.Controls.Add(this.lblWOID);
            this.panel1.Controls.Add(this.lblWOLength);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1750, 60);
            this.panel1.TabIndex = 23;
            // 
            // cmbProc
            // 
            this.cmbProc.Font = new System.Drawing.Font("굴림", 18F);
            this.cmbProc.FormattingEnabled = true;
            this.cmbProc.Location = new System.Drawing.Point(1184, 16);
            this.cmbProc.Name = "cmbProc";
            this.cmbProc.Size = new System.Drawing.Size(209, 32);
            this.cmbProc.TabIndex = 2;
            // 
            // calendarDouble1
            // 
            this.calendarDouble1.Location = new System.Drawing.Point(184, 16);
            this.calendarDouble1.Name = "calendarDouble1";
            this.calendarDouble1.Size = new System.Drawing.Size(240, 25);
            this.calendarDouble1.StartMonthDistinction = 0;
            this.calendarDouble1.TabIndex = 12;
            this.calendarDouble1.ValueEndDate = "20211016";
            this.calendarDouble1.ValueStartDate = "20211016";
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
            // lblWOName
            // 
            this.lblWOName.AutoSize = true;
            this.lblWOName.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWOName.Location = new System.Drawing.Point(1008, 16);
            this.lblWOName.Name = "lblWOName";
            this.lblWOName.Size = new System.Drawing.Size(63, 32);
            this.lblWOName.TabIndex = 0;
            this.lblWOName.Text = "공정";
            this.lblWOName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemNoQ
            // 
            this.txtItemNoQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNoQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemNoQ.Location = new System.Drawing.Point(696, 16);
            this.txtItemNoQ.Name = "txtItemNoQ";
            this.txtItemNoQ.Size = new System.Drawing.Size(209, 35);
            this.txtItemNoQ.TabIndex = 2;
            this.txtItemNoQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemNoQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemNoQ_KeyDown);
            // 
            // lblWOID
            // 
            this.lblWOID.AutoSize = true;
            this.lblWOID.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWOID.Location = new System.Drawing.Point(520, 16);
            this.lblWOID.Name = "lblWOID";
            this.lblWOID.Size = new System.Drawing.Size(119, 32);
            this.lblWOID.TabIndex = 0;
            this.lblWOID.Text = "제품 품번";
            this.lblWOID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWOLength
            // 
            this.lblWOLength.AutoSize = true;
            this.lblWOLength.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWOLength.Location = new System.Drawing.Point(31, 13);
            this.lblWOLength.Name = "lblWOLength";
            this.lblWOLength.Size = new System.Drawing.Size(63, 32);
            this.lblWOLength.TabIndex = 0;
            this.lblWOLength.Text = "기간";
            this.lblWOLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ucWorkOrder";
            this.Size = new System.Drawing.Size(1750, 700);
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

        private System.Windows.Forms.GroupBox groupbox2;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbProc;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblWOName;
        private System.Windows.Forms.TextBox txtItemNoQ;
        private System.Windows.Forms.Label lblWOID;
        private System.Windows.Forms.Label lblWOLength;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbItemProc;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.TextBox txtItemSeq;
        private System.Windows.Forms.TextBox txtPlanSeq;
        private System.Windows.Forms.TextBox txtPlanNo;
        private System.Windows.Forms.TextBox txtOrderSeq;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblProcSeq;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lbOrderNo;
        private System.Windows.Forms.Label lblWorkDate;
        private System.Windows.Forms.Label lbItemSeq;
        private System.Windows.Forms.Label lblPlanSeq;
        private System.Windows.Forms.Label lblOrderSeq;
        private Common.Controls.CalendarDouble calendarDouble1;
    }
}
