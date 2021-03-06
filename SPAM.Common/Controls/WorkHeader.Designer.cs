namespace SPAM.Common.Controls
{
    partial class WorkHeader
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.lblProcID = new System.Windows.Forms.Label();
            this.txtNG = new System.Windows.Forms.TextBox();
            this.lblNG = new System.Windows.Forms.Label();
            this.txtOK = new System.Windows.Forms.TextBox();
            this.lblOK = new System.Windows.Forms.Label();
            this.txtWoker = new System.Windows.Forms.TextBox();
            this.lnlWoker = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtProcID = new System.Windows.Forms.TextBox();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.lblWO = new System.Windows.Forms.Label();
            this.txtWO = new System.Windows.Forms.TextBox();
            this.lblMach = new System.Windows.Forms.Label();
            this.cmbMach = new System.Windows.Forms.ComboBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.btnEnd);
            this.pnlHeader.Controls.Add(this.btnStart);
            this.pnlHeader.Controls.Add(this.lblItemNo);
            this.pnlHeader.Controls.Add(this.lblProcID);
            this.pnlHeader.Controls.Add(this.txtNG);
            this.pnlHeader.Controls.Add(this.lblNG);
            this.pnlHeader.Controls.Add(this.txtOK);
            this.pnlHeader.Controls.Add(this.lblOK);
            this.pnlHeader.Controls.Add(this.txtWoker);
            this.pnlHeader.Controls.Add(this.lnlWoker);
            this.pnlHeader.Controls.Add(this.txtRemark);
            this.pnlHeader.Controls.Add(this.lblRemark);
            this.pnlHeader.Controls.Add(this.txtProcID);
            this.pnlHeader.Controls.Add(this.txtItemNo);
            this.pnlHeader.Controls.Add(this.lblWO);
            this.pnlHeader.Controls.Add(this.txtWO);
            this.pnlHeader.Controls.Add(this.lblMach);
            this.pnlHeader.Controls.Add(this.cmbMach);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1750, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1593, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 62);
            this.btnStart.TabIndex = 50;
            this.btnStart.Text = "작업시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblItemNo
            // 
            this.lblItemNo.AutoSize = true;
            this.lblItemNo.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemNo.Location = new System.Drawing.Point(642, 3);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(63, 32);
            this.lblItemNo.TabIndex = 49;
            this.lblItemNo.Text = "품번";
            this.lblItemNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcID
            // 
            this.lblProcID.AutoSize = true;
            this.lblProcID.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProcID.Location = new System.Drawing.Point(954, 3);
            this.lblProcID.Name = "lblProcID";
            this.lblProcID.Size = new System.Drawing.Size(86, 32);
            this.lblProcID.TabIndex = 48;
            this.lblProcID.Text = "공정ID";
            this.lblProcID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNG
            // 
            this.txtNG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNG.Enabled = false;
            this.txtNG.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNG.Location = new System.Drawing.Point(1498, 44);
            this.txtNG.Name = "txtNG";
            this.txtNG.ReadOnly = true;
            this.txtNG.Size = new System.Drawing.Size(75, 35);
            this.txtNG.TabIndex = 47;
            this.txtNG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNG
            // 
            this.lblNG.AutoSize = true;
            this.lblNG.Font = new System.Drawing.Font("휴먼둥근헤드라인", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNG.ForeColor = System.Drawing.Color.Red;
            this.lblNG.Location = new System.Drawing.Point(1428, 46);
            this.lblNG.Name = "lblNG";
            this.lblNG.Size = new System.Drawing.Size(64, 30);
            this.lblNG.TabIndex = 46;
            this.lblNG.Text = "NG";
            this.lblNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOK
            // 
            this.txtOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOK.Enabled = false;
            this.txtOK.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOK.Location = new System.Drawing.Point(1347, 44);
            this.txtOK.Name = "txtOK";
            this.txtOK.ReadOnly = true;
            this.txtOK.Size = new System.Drawing.Size(75, 35);
            this.txtOK.TabIndex = 45;
            this.txtOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOK
            // 
            this.lblOK.AutoSize = true;
            this.lblOK.Font = new System.Drawing.Font("휴먼둥근헤드라인", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOK.ForeColor = System.Drawing.Color.Blue;
            this.lblOK.Location = new System.Drawing.Point(1281, 46);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(60, 30);
            this.lblOK.TabIndex = 44;
            this.lblOK.Text = "OK";
            this.lblOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWoker
            // 
            this.txtWoker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWoker.Enabled = false;
            this.txtWoker.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWoker.Location = new System.Drawing.Point(1364, 3);
            this.txtWoker.Name = "txtWoker";
            this.txtWoker.ReadOnly = true;
            this.txtWoker.Size = new System.Drawing.Size(209, 35);
            this.txtWoker.TabIndex = 43;
            this.txtWoker.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lnlWoker
            // 
            this.lnlWoker.AutoSize = true;
            this.lnlWoker.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lnlWoker.Location = new System.Drawing.Point(1271, 3);
            this.lnlWoker.Name = "lnlWoker";
            this.lnlWoker.Size = new System.Drawing.Size(87, 32);
            this.lnlWoker.TabIndex = 42;
            this.lnlWoker.Text = "작업자";
            this.lnlWoker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Enabled = false;
            this.txtRemark.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRemark.Location = new System.Drawing.Point(120, 50);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(1135, 35);
            this.txtRemark.TabIndex = 41;
            this.txtRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRemark.Location = new System.Drawing.Point(3, 50);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(111, 32);
            this.lblRemark.TabIndex = 40;
            this.lblRemark.Text = "지시사항";
            this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProcID
            // 
            this.txtProcID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcID.Enabled = false;
            this.txtProcID.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcID.Location = new System.Drawing.Point(1046, 3);
            this.txtProcID.Name = "txtProcID";
            this.txtProcID.ReadOnly = true;
            this.txtProcID.Size = new System.Drawing.Size(209, 35);
            this.txtProcID.TabIndex = 39;
            this.txtProcID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemNo
            // 
            this.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNo.Enabled = false;
            this.txtItemNo.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemNo.Location = new System.Drawing.Point(711, 3);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.ReadOnly = true;
            this.txtItemNo.Size = new System.Drawing.Size(209, 35);
            this.txtItemNo.TabIndex = 38;
            this.txtItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblWO
            // 
            this.lblWO.AutoSize = true;
            this.lblWO.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWO.Location = new System.Drawing.Point(332, 3);
            this.lblWO.Name = "lblWO";
            this.lblWO.Size = new System.Drawing.Size(67, 32);
            this.lblWO.TabIndex = 37;
            this.lblWO.Text = "W/O";
            this.lblWO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWO
            // 
            this.txtWO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWO.Enabled = false;
            this.txtWO.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWO.Location = new System.Drawing.Point(405, 3);
            this.txtWO.Name = "txtWO";
            this.txtWO.ReadOnly = true;
            this.txtWO.Size = new System.Drawing.Size(209, 35);
            this.txtWO.TabIndex = 36;
            this.txtWO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMach
            // 
            this.lblMach.AutoSize = true;
            this.lblMach.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMach.Location = new System.Drawing.Point(3, 3);
            this.lblMach.Name = "lblMach";
            this.lblMach.Size = new System.Drawing.Size(63, 32);
            this.lblMach.TabIndex = 35;
            this.lblMach.Text = "설비";
            this.lblMach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMach
            // 
            this.cmbMach.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbMach.FormattingEnabled = true;
            this.cmbMach.Location = new System.Drawing.Point(119, 5);
            this.cmbMach.Name = "cmbMach";
            this.cmbMach.Size = new System.Drawing.Size(199, 32);
            this.cmbMach.TabIndex = 34;
            this.cmbMach.SelectedIndexChanged += new System.EventHandler(this.cmbMach_SelectedIndexChanged);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(1593, 5);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(93, 62);
            this.btnEnd.TabIndex = 51;
            this.btnEnd.Text = "작업종료";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // WorkHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHeader);
            this.Name = "WorkHeader";
            this.Size = new System.Drawing.Size(1750, 100);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.Label lblProcID;
        private System.Windows.Forms.TextBox txtNG;
        private System.Windows.Forms.Label lblNG;
        private System.Windows.Forms.TextBox txtOK;
        private System.Windows.Forms.Label lblOK;
        private System.Windows.Forms.TextBox txtWoker;
        private System.Windows.Forms.Label lnlWoker;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtProcID;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label lblWO;
        private System.Windows.Forms.TextBox txtWO;
        private System.Windows.Forms.Label lblMach;
        private System.Windows.Forms.ComboBox cmbMach;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
    }
}
