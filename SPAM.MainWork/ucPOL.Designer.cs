namespace SPAM.MainWork
{
    partial class ucPOL
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fpSpread2 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fpSpread3 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread3_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.workHeader1 = new SPAM.Common.Controls.WorkHeader();
            this.lblConsumableLot = new System.Windows.Forms.Label();
            this.btnDel1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelOK = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelNG = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.picQuilStatus = new System.Windows.Forms.PictureBox();
            this.picWorkStatus = new System.Windows.Forms.PictureBox();
            this.picMachStatus = new System.Windows.Forms.PictureBox();
            this.lblQuilStatus = new System.Windows.Forms.Label();
            this.lblWorkStatus = new System.Windows.Forms.Label();
            this.lblMachStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread2_Sheet1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread3_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelNG)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuilStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMachStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBarcode);
            this.panel1.Controls.Add(this.txtBarcode);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Location = new System.Drawing.Point(3, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 101);
            this.panel1.TabIndex = 1;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBarcode.Location = new System.Drawing.Point(13, 57);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(123, 32);
            this.lblBarcode.TabIndex = 41;
            this.lblBarcode.Text = "BARCODE";
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBarcode.Location = new System.Drawing.Point(142, 54);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(466, 35);
            this.txtBarcode.TabIndex = 40;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID.Location = new System.Drawing.Point(13, 3);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(82, 32);
            this.lblID.TabIndex = 39;
            this.lblID.Text = "LOTID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.Location = new System.Drawing.Point(142, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(466, 35);
            this.txtID.TabIndex = 38;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fpSpread1);
            this.panel2.Location = new System.Drawing.Point(1, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 256);
            this.panel2.TabIndex = 2;
            // 
            // fpSpread1
            // 
            this.fpSpread1.AccessibleDescription = "";
            this.fpSpread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread1.Location = new System.Drawing.Point(0, 0);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.fpSpread1.Size = new System.Drawing.Size(613, 256);
            this.fpSpread1.TabIndex = 0;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.fpSpread2);
            this.panel3.Location = new System.Drawing.Point(619, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 531);
            this.panel3.TabIndex = 3;
            // 
            // fpSpread2
            // 
            this.fpSpread2.AccessibleDescription = "";
            this.fpSpread2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread2.Location = new System.Drawing.Point(0, 0);
            this.fpSpread2.Name = "fpSpread2";
            this.fpSpread2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread2_Sheet1});
            this.fpSpread2.Size = new System.Drawing.Size(560, 531);
            this.fpSpread2.TabIndex = 0;
            // 
            // fpSpread2_Sheet1
            // 
            this.fpSpread2_Sheet1.Reset();
            this.fpSpread2_Sheet1.SheetName = "Sheet1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fpSpread3);
            this.panel4.Location = new System.Drawing.Point(1182, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(545, 531);
            this.panel4.TabIndex = 4;
            // 
            // fpSpread3
            // 
            this.fpSpread3.AccessibleDescription = "";
            this.fpSpread3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread3.Location = new System.Drawing.Point(0, 0);
            this.fpSpread3.Name = "fpSpread3";
            this.fpSpread3.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread3_Sheet1});
            this.fpSpread3.Size = new System.Drawing.Size(545, 531);
            this.fpSpread3.TabIndex = 0;
            // 
            // fpSpread3_Sheet1
            // 
            this.fpSpread3_Sheet1.Reset();
            this.fpSpread3_Sheet1.SheetName = "Sheet1";
            // 
            // workHeader1
            // 
            this.workHeader1.ItemSeq = null;
            this.workHeader1.Location = new System.Drawing.Point(0, 0);
            this.workHeader1.Name = "workHeader1";
            this.workHeader1.OrderSeq = null;
            this.workHeader1.ProcSeq = null;
            this.workHeader1.Size = new System.Drawing.Size(1727, 90);
            this.workHeader1.TabIndex = 0;
            // 
            // lblConsumableLot
            // 
            this.lblConsumableLot.AutoSize = true;
            this.lblConsumableLot.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblConsumableLot.Location = new System.Drawing.Point(3, 384);
            this.lblConsumableLot.Name = "lblConsumableLot";
            this.lblConsumableLot.Size = new System.Drawing.Size(111, 32);
            this.lblConsumableLot.TabIndex = 42;
            this.lblConsumableLot.Text = "투입자재";
            this.lblConsumableLot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDel1
            // 
            this.btnDel1.Image = global::SPAM.MainWork.Properties.Resources.Delete;
            this.btnDel1.Location = new System.Drawing.Point(484, 390);
            this.btnDel1.Name = "btnDel1";
            this.btnDel1.Size = new System.Drawing.Size(130, 32);
            this.btnDel1.TabIndex = 43;
            this.btnDel1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(620, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "OK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelOK
            // 
            this.btnDelOK.Image = global::SPAM.MainWork.Properties.Resources.Delete;
            this.btnDelOK.Location = new System.Drawing.Point(1048, 115);
            this.btnDelOK.Name = "btnDelOK";
            this.btnDelOK.Size = new System.Drawing.Size(130, 32);
            this.btnDelOK.TabIndex = 45;
            this.btnDelOK.TabStop = false;
            this.btnDelOK.Click += new System.EventHandler(this.btnDelOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1184, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "NG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelNG
            // 
            this.btnDelNG.Image = global::SPAM.MainWork.Properties.Resources.Delete;
            this.btnDelNG.Location = new System.Drawing.Point(1597, 115);
            this.btnDelNG.Name = "btnDelNG";
            this.btnDelNG.Size = new System.Drawing.Size(130, 32);
            this.btnDelNG.TabIndex = 47;
            this.btnDelNG.TabStop = false;
            this.btnDelNG.Click += new System.EventHandler(this.btnDelNG_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.picQuilStatus);
            this.panel5.Controls.Add(this.picWorkStatus);
            this.panel5.Controls.Add(this.picMachStatus);
            this.panel5.Controls.Add(this.lblQuilStatus);
            this.panel5.Controls.Add(this.lblWorkStatus);
            this.panel5.Controls.Add(this.lblMachStatus);
            this.panel5.Location = new System.Drawing.Point(2, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(614, 183);
            this.panel5.TabIndex = 48;
            // 
            // picQuilStatus
            // 
            this.picQuilStatus.Image = global::SPAM.MainWork.Properties.Resources.st_back_red;
            this.picQuilStatus.Location = new System.Drawing.Point(144, 129);
            this.picQuilStatus.Name = "picQuilStatus";
            this.picQuilStatus.Size = new System.Drawing.Size(409, 43);
            this.picQuilStatus.TabIndex = 45;
            this.picQuilStatus.TabStop = false;
            // 
            // picWorkStatus
            // 
            this.picWorkStatus.Image = global::SPAM.MainWork.Properties.Resources.st_back_red;
            this.picWorkStatus.Location = new System.Drawing.Point(144, 72);
            this.picWorkStatus.Name = "picWorkStatus";
            this.picWorkStatus.Size = new System.Drawing.Size(409, 43);
            this.picWorkStatus.TabIndex = 44;
            this.picWorkStatus.TabStop = false;
            // 
            // picMachStatus
            // 
            this.picMachStatus.Image = global::SPAM.MainWork.Properties.Resources.st_back_red;
            this.picMachStatus.Location = new System.Drawing.Point(144, 17);
            this.picMachStatus.Name = "picMachStatus";
            this.picMachStatus.Size = new System.Drawing.Size(409, 43);
            this.picMachStatus.TabIndex = 43;
            this.picMachStatus.TabStop = false;
            // 
            // lblQuilStatus
            // 
            this.lblQuilStatus.AutoSize = true;
            this.lblQuilStatus.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblQuilStatus.Location = new System.Drawing.Point(15, 129);
            this.lblQuilStatus.Name = "lblQuilStatus";
            this.lblQuilStatus.Size = new System.Drawing.Size(111, 32);
            this.lblQuilStatus.TabIndex = 42;
            this.lblQuilStatus.Text = "품질상태";
            this.lblQuilStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWorkStatus
            // 
            this.lblWorkStatus.AutoSize = true;
            this.lblWorkStatus.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorkStatus.Location = new System.Drawing.Point(15, 72);
            this.lblWorkStatus.Name = "lblWorkStatus";
            this.lblWorkStatus.Size = new System.Drawing.Size(111, 32);
            this.lblWorkStatus.TabIndex = 41;
            this.lblWorkStatus.Text = "작업상태";
            this.lblWorkStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMachStatus
            // 
            this.lblMachStatus.AutoSize = true;
            this.lblMachStatus.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMachStatus.Location = new System.Drawing.Point(15, 17);
            this.lblMachStatus.Name = "lblMachStatus";
            this.lblMachStatus.Size = new System.Drawing.Size(111, 32);
            this.lblMachStatus.TabIndex = 40;
            this.lblMachStatus.Text = "설비상태";
            this.lblMachStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucPOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConsumableLot);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.workHeader1);
            this.Controls.Add(this.btnDel1);
            this.Controls.Add(this.btnDelOK);
            this.Controls.Add(this.btnDelNG);
            this.Name = "ucPOL";
            this.Size = new System.Drawing.Size(1750, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread2_Sheet1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread3_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelNG)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuilStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMachStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.Controls.WorkHeader workHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private FarPoint.Win.Spread.FpSpread fpSpread2;
        private FarPoint.Win.Spread.SheetView fpSpread2_Sheet1;
        private FarPoint.Win.Spread.FpSpread fpSpread3;
        private FarPoint.Win.Spread.SheetView fpSpread3_Sheet1;
        private System.Windows.Forms.Label lblConsumableLot;
        private System.Windows.Forms.PictureBox btnDel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnDelOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnDelNG;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox picMachStatus;
        private System.Windows.Forms.Label lblQuilStatus;
        private System.Windows.Forms.Label lblWorkStatus;
        private System.Windows.Forms.Label lblMachStatus;
        private System.Windows.Forms.PictureBox picQuilStatus;
        private System.Windows.Forms.PictureBox picWorkStatus;
    }
}
