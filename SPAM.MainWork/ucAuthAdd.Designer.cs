
namespace SPAM.MainWork
{
    partial class ucAuthAdd
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
            this.cmbProgram = new System.Windows.Forms.ComboBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblAuthProgram = new System.Windows.Forms.Label();
            this.lblAuthGroup = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAuthGroupQ = new System.Windows.Forms.TextBox();
            this.lblAuthGroupQ = new System.Windows.Forms.Label();
            this.txtAuthSeq = new System.Windows.Forms.GroupBox();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.txtAuthSeq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProgram);
            this.groupBox1.Controls.Add(this.cmbGroup);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lblAuthProgram);
            this.groupBox1.Controls.Add(this.lblAuthGroup);
            this.groupBox1.Location = new System.Drawing.Point(8, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(640, 750);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력정보";
            // 
            // cmbProgram
            // 
            this.cmbProgram.Font = new System.Drawing.Font("굴림", 18F);
            this.cmbProgram.FormattingEnabled = true;
            this.cmbProgram.Location = new System.Drawing.Point(192, 126);
            this.cmbProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.Size = new System.Drawing.Size(394, 32);
            this.cmbProgram.TabIndex = 16;
            // 
            // cmbGroup
            // 
            this.cmbGroup.Font = new System.Drawing.Font("굴림", 18F);
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(192, 61);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(394, 32);
            this.cmbGroup.TabIndex = 16;
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
            // lblAuthProgram
            // 
            this.lblAuthProgram.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblAuthProgram.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAuthProgram.ForeColor = System.Drawing.Color.White;
            this.lblAuthProgram.Location = new System.Drawing.Point(29, 126);
            this.lblAuthProgram.Name = "lblAuthProgram";
            this.lblAuthProgram.Size = new System.Drawing.Size(133, 44);
            this.lblAuthProgram.TabIndex = 3;
            this.lblAuthProgram.Text = "프로그램";
            this.lblAuthProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthGroup
            // 
            this.lblAuthGroup.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblAuthGroup.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAuthGroup.ForeColor = System.Drawing.Color.White;
            this.lblAuthGroup.Location = new System.Drawing.Point(29, 61);
            this.lblAuthGroup.Name = "lblAuthGroup";
            this.lblAuthGroup.Size = new System.Drawing.Size(133, 44);
            this.lblAuthGroup.TabIndex = 0;
            this.lblAuthGroup.Text = "그룹명";
            this.lblAuthGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.txtAuthGroupQ);
            this.pnlHeader.Controls.Add(this.lblAuthGroupQ);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(2000, 74);
            this.pnlHeader.TabIndex = 17;
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
            // txtAuthGroupQ
            // 
            this.txtAuthGroupQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthGroupQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAuthGroupQ.Location = new System.Drawing.Point(159, 16);
            this.txtAuthGroupQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthGroupQ.Name = "txtAuthGroupQ";
            this.txtAuthGroupQ.Size = new System.Drawing.Size(239, 35);
            this.txtAuthGroupQ.TabIndex = 2;
            this.txtAuthGroupQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAuthGroupQ
            // 
            this.lblAuthGroupQ.AutoSize = true;
            this.lblAuthGroupQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAuthGroupQ.Location = new System.Drawing.Point(26, 20);
            this.lblAuthGroupQ.Name = "lblAuthGroupQ";
            this.lblAuthGroupQ.Size = new System.Drawing.Size(87, 32);
            this.lblAuthGroupQ.TabIndex = 0;
            this.lblAuthGroupQ.Text = "그룹명";
            // 
            // txtAuthSeq
            // 
            this.txtAuthSeq.Controls.Add(this.fpSpread1);
            this.txtAuthSeq.Location = new System.Drawing.Point(656, 88);
            this.txtAuthSeq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthSeq.Name = "txtAuthSeq";
            this.txtAuthSeq.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthSeq.Size = new System.Drawing.Size(1314, 750);
            this.txtAuthSeq.TabIndex = 18;
            this.txtAuthSeq.TabStop = false;
            this.txtAuthSeq.Text = "사용자정보";
            this.txtAuthSeq.Enter += new System.EventHandler(this.txtUserSeq_Enter);
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
            // ucAuthAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAuthSeq);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucAuthAdd";
            this.Size = new System.Drawing.Size(2000, 875);
            this.Load += new System.EventHandler(this.ucAuthAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.txtAuthSeq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblAuthProgram;
        private System.Windows.Forms.Label lblAuthGroup;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAuthGroupQ;
        private System.Windows.Forms.TextBox txtAuthProgramQ;
        private System.Windows.Forms.Label lblAuthGroupQ;
        private System.Windows.Forms.GroupBox txtAuthSeq;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.ComboBox cmbProgram;
        private System.Windows.Forms.ComboBox cmbGroup;
    }
}
