
namespace SPAM.MainWork
{
    partial class ucProcAdd
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
            this.txtProcIDQ = new System.Windows.Forms.TextBox();
            this.lblProcIDQ = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProcName = new System.Windows.Forms.TextBox();
            this.txtProcID = new System.Windows.Forms.TextBox();
            this.txtProcSeq = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblProcName = new System.Windows.Forms.Label();
            this.lblProcID = new System.Windows.Forms.Label();
            this.lblProcSeq = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.txtProcNameQ = new System.Windows.Forms.TextBox();
            this.lblProcNameQ = new System.Windows.Forms.Label();
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
            this.pnlHeader.Controls.Add(this.txtProcNameQ);
            this.pnlHeader.Controls.Add(this.lblProcNameQ);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.txtProcIDQ);
            this.pnlHeader.Controls.Add(this.lblProcIDQ);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(2000, 74);
            this.pnlHeader.TabIndex = 13;
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProcIDQ
            // 
            this.txtProcIDQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcIDQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcIDQ.Location = new System.Drawing.Point(159, 16);
            this.txtProcIDQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcIDQ.Name = "txtProcIDQ";
            this.txtProcIDQ.Size = new System.Drawing.Size(239, 35);
            this.txtProcIDQ.TabIndex = 2;
            this.txtProcIDQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProcIDQ
            // 
            this.lblProcIDQ.AutoSize = true;
            this.lblProcIDQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProcIDQ.Location = new System.Drawing.Point(26, 20);
            this.lblProcIDQ.Name = "lblProcIDQ";
            this.lblProcIDQ.Size = new System.Drawing.Size(86, 32);
            this.lblProcIDQ.TabIndex = 0;
            this.lblProcIDQ.Text = "공정ID";
            this.lblProcIDQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProcName);
            this.groupBox1.Controls.Add(this.txtProcID);
            this.groupBox1.Controls.Add(this.txtProcSeq);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lblProcName);
            this.groupBox1.Controls.Add(this.lblProcID);
            this.groupBox1.Controls.Add(this.lblProcSeq);
            this.groupBox1.Location = new System.Drawing.Point(8, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(640, 750);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력정보";
            // 
            // txtProcName
            // 
            this.txtProcName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcName.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcName.Location = new System.Drawing.Point(192, 190);
            this.txtProcName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcName.Name = "txtProcName";
            this.txtProcName.Size = new System.Drawing.Size(394, 35);
            this.txtProcName.TabIndex = 16;
            this.txtProcName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProcID
            // 
            this.txtProcID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcID.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcID.Location = new System.Drawing.Point(192, 126);
            this.txtProcID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcID.Name = "txtProcID";
            this.txtProcID.Size = new System.Drawing.Size(394, 35);
            this.txtProcID.TabIndex = 14;
            this.txtProcID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProcSeq
            // 
            this.txtProcSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcSeq.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcSeq.Location = new System.Drawing.Point(192, 61);
            this.txtProcSeq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcSeq.Name = "txtProcSeq";
            this.txtProcSeq.Size = new System.Drawing.Size(394, 35);
            this.txtProcSeq.TabIndex = 13;
            this.txtProcSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
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
            // lblProcName
            // 
            this.lblProcName.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblProcName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProcName.ForeColor = System.Drawing.Color.White;
            this.lblProcName.Location = new System.Drawing.Point(29, 190);
            this.lblProcName.Name = "lblProcName";
            this.lblProcName.Size = new System.Drawing.Size(133, 44);
            this.lblProcName.TabIndex = 4;
            this.lblProcName.Text = "공정명";
            this.lblProcName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcID
            // 
            this.lblProcID.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblProcID.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProcID.ForeColor = System.Drawing.Color.White;
            this.lblProcID.Location = new System.Drawing.Point(29, 126);
            this.lblProcID.Name = "lblProcID";
            this.lblProcID.Size = new System.Drawing.Size(133, 44);
            this.lblProcID.TabIndex = 2;
            this.lblProcID.Text = "공정ID";
            this.lblProcID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcSeq
            // 
            this.lblProcSeq.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblProcSeq.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProcSeq.ForeColor = System.Drawing.Color.White;
            this.lblProcSeq.Location = new System.Drawing.Point(29, 61);
            this.lblProcSeq.Name = "lblProcSeq";
            this.lblProcSeq.Size = new System.Drawing.Size(133, 44);
            this.lblProcSeq.TabIndex = 0;
            this.lblProcSeq.Text = "공정내부코드";
            this.lblProcSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.fpSpread1);
            this.groupbox2.Location = new System.Drawing.Point(656, 88);
            this.groupbox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox2.Size = new System.Drawing.Size(1314, 750);
            this.groupbox2.TabIndex = 17;
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
            this.fpSpread1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.fpSpread1_CellClick_1);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // txtProcNameQ
            // 
            this.txtProcNameQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcNameQ.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcNameQ.Location = new System.Drawing.Point(717, 19);
            this.txtProcNameQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcNameQ.Name = "txtProcNameQ";
            this.txtProcNameQ.Size = new System.Drawing.Size(239, 35);
            this.txtProcNameQ.TabIndex = 15;
            this.txtProcNameQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProcNameQ
            // 
            this.lblProcNameQ.AutoSize = true;
            this.lblProcNameQ.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProcNameQ.Location = new System.Drawing.Point(543, 19);
            this.lblProcNameQ.Name = "lblProcNameQ";
            this.lblProcNameQ.Size = new System.Drawing.Size(87, 32);
            this.lblProcNameQ.TabIndex = 14;
            this.lblProcNameQ.Text = "공정명";
            // 
            // ucProcAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ucProcAdd";
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtProcIDQ;
        private System.Windows.Forms.Label lblProcIDQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProcName;
        private System.Windows.Forms.TextBox txtProcID;
        private System.Windows.Forms.TextBox txtProcSeq;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblProcName;
        private System.Windows.Forms.Label lblProcID;
        private System.Windows.Forms.Label lblProcSeq;
        private System.Windows.Forms.GroupBox groupbox2;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.TextBox txtProcNameQ;
        private System.Windows.Forms.Label lblProcNameQ;
    }
}
