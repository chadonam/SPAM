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
            string LanguageString;
            if (btnTp == BtnType.Search)
            {
                btn.BackColor = Color.MediumSeaGreen;
                btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                LanguageString = Utils.GetLanguage("조회");
                
                btn.Text = LanguageString;
            }
            else if (btnTp == BtnType.Save)
            {
                btn.BackColor = Color.LightPink;
                btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               LanguageString = Utils.GetLanguage("저장");

                btn.Text = LanguageString;
            }
            else if (btnTp == BtnType.modify)
            {
                btn.BackColor = Color.LightPink;
                btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                LanguageString = Utils.GetLanguage("수정");

                btn.Text = LanguageString;
            }
            else if (btnTp == BtnType.Delete)
            {
                btn.BackColor = Color.LightPink;
                btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                LanguageString = Utils.GetLanguage("삭제");

                btn.Text = LanguageString;
            }
            else if (btnTp == BtnType.New)
            {
                btn.BackColor = Color.LightPink;
                btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               LanguageString = Utils.GetLanguage("신규");

                btn.Text = LanguageString;
            }
            else if (btnTp == BtnType.OK)
            {
                btn.BackColor = Color.Blue;
                btn.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = Color.White;
                btn.Text = "OK";
            }
            else if (btnTp == BtnType.NG)
            {
                btn.BackColor = Color.Red;
                btn.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = Color.White;
                btn.Text = "NG";
            }
            else if (btnTp == BtnType.Etc)
            {
                //btn.BackColor = Color.MediumSeaGreen;
                btn.BackColor = Color.LightPink;
                btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                LanguageString = Utils.GetLanguage(btn.Text);
                btn.Text = LanguageString;
            }

        }

        public static void AdminTxt(TextBox txt, TxtType txtTp)
        {
            if (txtTp == TxtType.Nomal)
            {
                
                txt.BackColor = Color.LightPink;
                txt.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            }
            else if (txtTp == TxtType.Dis)
            {
                //txt.BackColor = Color.LightPink;
                txt.ReadOnly = true;
            }
            else if (txtTp == TxtType.CodeHelp)
            {
                txt.BackColor = Color.Turquoise;
                
            }

        }


        /// <summary>
        /// txtbox의 타입 enum
        /// </summary>
        public enum TxtType
        {
            Nomal = 0,
            Dis = 1,
            CodeHelp = 2
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
            //     OK버튼
            OK = 5,
            //
            // 요약:
            //     NG버튼
            NG = 6,
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
                    lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
                    break;
                case LabelType.Menu:
                    lbl.AutoSize = false;
                    if (ClientGlobal.Language == "KO")
                    {
                        lbl.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                    }
                    else
                    {
                        lbl.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                    }
                    lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lbl.Height = 35;

                    break;
                case LabelType.Item:
                    lbl.AutoSize = false;
                    lbl.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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

        public static void ChangeText(Control ctrl)
        {
            if (ClientGlobal.Language == "KO")
            {
                return;
            }

            string msg, caption;
            msg = ctrl.Text;
            caption = Utils.GetLanguage(msg);
            ctrl.Text = caption;

        }

        public static void ChangeAllControl(Control.ControlCollection conColl)
        {
            foreach (Control con in conColl) {
                ChangeText(con);
            }
        }


    }
}
