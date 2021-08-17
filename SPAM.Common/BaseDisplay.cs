using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SPAM.Common
{
    public class BaseDisplay
    {
        //버튼의 타입별 크기와 색상 설정
        public static void AdminBtn(Button btn, BtnType btnTp)
        {
            if (btnTp == BtnType.Search)
            {
                btn.BackColor = Color.MediumSeaGreen;
                btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Text = "조회";
            }
            else if (btnTp == BtnType.Save)
            {
                btn.BackColor = Color.LightPink;
                btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Text = "저장";
            }
            else if (btnTp == BtnType.modify)
            {
                btn.BackColor = Color.LightPink;
                btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Text = "수정";
            }
            else if (btnTp == BtnType.Delete)
            {
                btn.BackColor = Color.LightPink;
                btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Text = "삭제";
            }
            else if (btnTp == BtnType.New)
            {
                btn.BackColor = Color.LightPink;
                btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Text = "신규";
            }
            else if (btnTp == BtnType.Etc)
            {
                //btn.BackColor = Color.MediumSeaGreen;
                btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

        }

        /// <summary>
        /// 버튼의 타입 enum
        /// </summary>
        public enum BtnType
        {
            // 요약:
            //     저장버튼


            Save = 0,
            //
            // 요약:
            //     검색버튼


            Search = 1,
            //
            // 요약:
            //     수정버튼
            modify = 2,
            //
            // 요약:
            //     삭제버튼
            Delete = 3,
            //
            // 요약:
            //     신규버튼
            New = 4,
            //
            // 요약:
            //     기타버튼
            Etc = 9
        }


        public enum LabelType
        {
            Title,
            Menu,
            Item
        }

        public static void SetLabelStyle(Label lbl, LabelType labeltype)
        {

            switch (labeltype)
            {
                case LabelType.Title:
                    lbl.Image = ResourceImage.GetImage("deco01");
                    lbl.Font = new System.Drawing.Font("굴림", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                    lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(66)))), ((int)(((byte)(75)))));
                    lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    lbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
                    break;
                case LabelType.Menu:
                    lbl.AutoSize = false;
                    lbl.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));                    
                    lbl.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                    lbl.Height = 35;

                    break;
                case LabelType.Item:
                    lbl.AutoSize = false;
                    lbl.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                    lbl.BackColor = Color.MidnightBlue;
                    lbl.ForeColor = Color.White;
                    lbl.Height = 35;
                    lbl.Width = 116;
                    lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    break;
            }
        }

        public static void SetPOPSize(Control ctl)
        {
            ctl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

            if (ctl is DateTimePicker || ctl is ComboBox)
            {
                ctl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            }

            if (ctl is TextBox)
            {
                ctl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            }
        }

        //검색 부분의 판넬 구성
        public static void AdminSearchPanel(Panel pnl)
        {
            AdminSearchPanel(pnl, 1);
        }
        //검색 부분의 판넬 구성
        public static void AdminSearchPanel(Panel pnl, int rowCnt)
        {
            int cnt = pnl.Controls.Count;
            pnl.Tag = rowCnt.ToString();


            int pnlHt = pnl.Height;

            if (pnlHt > 60)
                pnlHt = 60;

            if (pnlHt < 30)
                pnlHt = 30;

            if (rowCnt > 1)
            {
                pnlHt = pnlHt + 20 * (rowCnt - 1);

                if (pnlHt < 40)
                    pnlHt = 40;
            }

            for (int i = 0; i < cnt; i++)
            {
                string getTp = pnl.Controls[i].GetType().ToString();

                if (getTp.Equals("System.Windows.Forms.Label"))
                {
                    Label lab = (Label)pnl.Controls[i];
                    AdminSearchLabel(lab);
                }

                int HalfHeight = pnl.Controls[i].Height;
                HalfHeight = HalfHeight / 2;
                int locX = pnl.Controls[i].Location.X;



                if (rowCnt == 1 || getTp.Equals("System.Windows.Forms.Button"))
                {
                    pnl.Controls[i].Location = new System.Drawing.Point(locX, (pnlHt / 2 - HalfHeight));
                }
                else
                {
                    string tag = "1";
                    if (pnl.Controls[i].Tag != null)
                        tag = pnl.Controls[i].Tag.ToString();

                    if (tag == "2")
                    {
                        double locY = (pnlHt * 3) / 4;
                        pnl.Controls[i].Location = new System.Drawing.Point(locX, (int.Parse(locY.ToString()) - HalfHeight));
                    }
                    else
                    {
                        pnl.Controls[i].Location = new System.Drawing.Point(locX, (pnlHt / 4 - HalfHeight));
                    }

                }
            }
            pnl.BackColor = System.Drawing.Color.White;
            pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl.Dock = System.Windows.Forms.DockStyle.Top;
            pnl.Location = new System.Drawing.Point(0, 40);
            if (rowCnt > 1)
            {
                pnl.Size = new System.Drawing.Size(1000, pnlHt);
            }
            else
            {
                pnl.Size = new System.Drawing.Size(1000, pnlHt);
            }
        }

        //검색 부분의 검색콘트롤러 레이블 디자인 구성
        public static void AdminSearchLabel(Label lab)
        {
            lab.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(88)))), ((int)(((byte)(92)))));
            lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lab.Height = 26;
        }

    }
}
