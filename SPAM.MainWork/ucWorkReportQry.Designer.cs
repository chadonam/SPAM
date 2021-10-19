namespace SPAM.MainWork
{
    partial class ucWorkReportQry
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtOrderNoQ = new System.Windows.Forms.TextBox();
            this.lblOrderSeqQ = new System.Windows.Forms.Label();
            this.cmbProcSeq = new System.Windows.Forms.ComboBox();
            this.calWorkDate = new SPAM.Common.Controls.CalendarDouble();
            this.lblWorkDateQ = new System.Windows.Forms.Label();
            this.lblProcSeqQ = new System.Windows.Forms.Label();
            this.txtItemSeqQ = new System.Windows.Forms.TextBox();
            this.lblItemSeqQ = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.sheetView1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlHeader.SuspendLayout();
            this.groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.txtOrderNoQ);
            this.pnlHeader.Controls.Add(this.lblOrderSeqQ);
            this.pnlHeader.Controls.Add(this.cmbProcSeq);
            this.pnlHeader.Controls.Add(this.calWorkDate);
            this.pnlHeader.Controls.Add(this.lblWorkDateQ);
            this.pnlHeader.Controls.Add(this.lblProcSeqQ);
            this.pnlHeader.Controls.Add(this.txtItemSeqQ);
            this.pnlHeader.Controls.Add(this.lblItemSeqQ);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1750, 60);
            this.pnlHeader.TabIndex = 12;
            // 
            // txtOrderNoQ
            // 
            this.txtOrderNoQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderNoQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOrderNoQ.Location = new System.Drawing.Point(1192, 16);
            this.txtOrderNoQ.Name = "txtOrderNoQ";
            this.txtOrderNoQ.Size = new System.Drawing.Size(209, 35);
            this.txtOrderNoQ.TabIndex = 21;
            this.txtOrderNoQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOrderSeqQ
            // 
            this.lblOrderSeqQ.AutoSize = true;
            this.lblOrderSeqQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOrderSeqQ.Location = new System.Drawing.Point(1104, 16);
            this.lblOrderSeqQ.Name = "lblOrderSeqQ";
            this.lblOrderSeqQ.Size = new System.Drawing.Size(57, 32);
            this.lblOrderSeqQ.TabIndex = 20;
            this.lblOrderSeqQ.Text = "WO";
            this.lblOrderSeqQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbProcSeq
            // 
            this.cmbProcSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbProcSeq.FormattingEnabled = true;
            this.cmbProcSeq.Location = new System.Drawing.Point(848, 16);
            this.cmbProcSeq.Name = "cmbProcSeq";
            this.cmbProcSeq.Size = new System.Drawing.Size(224, 32);
            this.cmbProcSeq.TabIndex = 19;
            // 
            // calWorkDate
            // 
            this.calWorkDate.Location = new System.Drawing.Point(120, 16);
            this.calWorkDate.Name = "calWorkDate";
            this.calWorkDate.Size = new System.Drawing.Size(240, 25);
            this.calWorkDate.StartMonthDistinction = 0;
            this.calWorkDate.TabIndex = 18;
            this.calWorkDate.ValueEndDate = "20211016";
            this.calWorkDate.ValueStartDate = "20211016";
            // 
            // lblWorkDateQ
            // 
            this.lblWorkDateQ.AutoSize = true;
            this.lblWorkDateQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorkDateQ.Location = new System.Drawing.Point(28, 13);
            this.lblWorkDateQ.Name = "lblWorkDateQ";
            this.lblWorkDateQ.Size = new System.Drawing.Size(63, 32);
            this.lblWorkDateQ.TabIndex = 17;
            this.lblWorkDateQ.Text = "기간";
            this.lblWorkDateQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcSeqQ
            // 
            this.lblProcSeqQ.AutoSize = true;
            this.lblProcSeqQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProcSeqQ.Location = new System.Drawing.Point(760, 16);
            this.lblProcSeqQ.Name = "lblProcSeqQ";
            this.lblProcSeqQ.Size = new System.Drawing.Size(63, 32);
            this.lblProcSeqQ.TabIndex = 14;
            this.lblProcSeqQ.Text = "공정";
            this.lblProcSeqQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemSeqQ
            // 
            this.txtItemSeqQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemSeqQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemSeqQ.Location = new System.Drawing.Point(520, 16);
            this.txtItemSeqQ.Name = "txtItemSeqQ";
            this.txtItemSeqQ.Size = new System.Drawing.Size(209, 35);
            this.txtItemSeqQ.TabIndex = 13;
            this.txtItemSeqQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemSeqQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemNo_KeyDown);
            // 
            // lblItemSeqQ
            // 
            this.lblItemSeqQ.AutoSize = true;
            this.lblItemSeqQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemSeqQ.Location = new System.Drawing.Point(384, 16);
            this.lblItemSeqQ.Name = "lblItemSeqQ";
            this.lblItemSeqQ.Size = new System.Drawing.Size(111, 32);
            this.lblItemSeqQ.TabIndex = 12;
            this.lblItemSeqQ.Text = "제품품번";
            this.lblItemSeqQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.fpSpread1);
            this.groupbox2.Location = new System.Drawing.Point(0, 72);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(1150, 600);
            this.groupbox2.TabIndex = 16;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "생산실적";
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
            // 
            // sheetView1
            // 
            this.sheetView1.Reset();
            this.sheetView1.SheetName = "Sheet1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(1160, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 600);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "그래프";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 64);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(544, 512);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ucWorkReportQry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ucWorkReportQry";
            this.Size = new System.Drawing.Size(1750, 700);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.GroupBox groupbox2;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView sheetView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtItemSeqQ;
        private System.Windows.Forms.Label lblItemSeqQ;
        private Common.Controls.CalendarDouble calendarDouble1;
        private System.Windows.Forms.Label lblProcSeqQ;
        private System.Windows.Forms.Label lblWorkDateQ;
        private Common.Controls.CalendarDouble calWorkDate;
        private System.Windows.Forms.TextBox txtOrderNoQ;
        private System.Windows.Forms.Label lblOrderSeqQ;
        private System.Windows.Forms.ComboBox cmbProcSeq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
