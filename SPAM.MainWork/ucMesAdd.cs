using SPAM.Common;
using SPAM.Manage;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Net;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;

namespace SPAM.MainWork
{
    public partial class ucMesAdd : UserControl
    {
        public ucMesAdd()
        {
            InitializeComponent();
            InitControl();
            SetFpSpread();
        }

        #region Control 초기화
        private void InitControl()
        {
            BaseDisplay.AdminBtn(btnSearch, BaseDisplay.BtnType.Search);
            BaseDisplay.AdminBtn(btnSave, BaseDisplay.BtnType.Save);
            BaseDisplay.AdminBtn(btnDel, BaseDisplay.BtnType.Delete);
            BaseDisplay.AdminBtn(btnEtc, BaseDisplay.BtnType.Etc);
            BaseDisplay.AdminBtn(btnEtc2, BaseDisplay.BtnType.Etc);

            BaseDisplay.SetLabelStyle(lblMesQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblKoL, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblVNL, BaseDisplay.LabelType.Item);



        }
        #region FpSpread 설정
        private void SetFpSpread()
        {
            ParamPack group = new ParamPack();

            using (CommonService svc = new CommonService())
            {
                DataTable dt1 = svc.GetGroupCombo().Tables[0];
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    group.Add(dt1.Rows[i]["ItemNm"].ToString(), dt1.Rows[i]["ItemCd"].ToString());
                }
            }

            ParamPack param = new ParamPack();


            param.Add(FpSpread.SetSheetColumns("한국어", "KO", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("베트남어", "VT", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
           



            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);


        }
        #endregion

        #endregion

        #region 저장

        private void Save(string WorkingTag)
        {
            int status;
            string result;
            DataSet ds = null;


            try
            {
                string KO;
                string VT;

                KO = txtKoL.Text;
                VT = txtVNL.Text;




                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetMes(WorkingTag, KO, VT);
                }


                if (ds != null)
                {
                    status = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                    result = ds.Tables[0].Rows[0][1].ToString();
                    if (status == 0)
                    {
                        MessageHandler.DisplayMessage(result, Common.Controls.MessageType.Warning);
                    }
                    else
                    {
                        if (WorkingTag == "A")
                        {
                            MessageHandler.DisplayMessage("저장되었습니다.", Common.Controls.MessageType.Warning);
                        }
                        else
                        {
                            MessageHandler.DisplayMessage("삭제되었습니다.", Common.Controls.MessageType.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }

        }

        #endregion

        #region Action

        #region 초기화버튼클릭
        private void btnEtc_Click(object sender, EventArgs e)
        {
            DefaultControl();


        }
        #endregion

        #region 번역버튼클릭
        private void btnEtc2_Click(object sender, EventArgs e) 
        {
            txtVNL.Text = Translate(txtKoL.Text);


        }
        #endregion

        #region 저장버튼 Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            Save("A");
            btnSave.Enabled = true;
            DefaultControl();
            Search();

        }
        #endregion

        #region 삭제버튼 Click
        private void btnDel_Click(object sender, EventArgs e)
        {
            btnDel.Enabled = false;
            Save("D");
            btnDel.Enabled = true;
            DefaultControl();
            Search();
        }
        #endregion
        #endregion

        #region 조회버튼 Click
        private void btnQry_Click(object sender, EventArgs e)
        {
            Search();
        }
        #endregion

        #region 기타 메소드
        private void DefaultControl()
        {

            txtKoL.Text = string.Empty;
            txtVNL.Text = string.Empty;
        }
        #endregion

        #region 조회

        private void Search()
        {

            DataSet ds = null;
            string mes = txtMesQ.Text;

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetMes(mes);
                }

                if (ds != null)
                {
                    //fpSpread1.Sheets[0].DataSource = ds;
                    FpSpread.SetSheetDataBind(this.fpSpread1.Sheets[0], ds.Tables[0]);


                }


            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }

        }

        #endregion

        #region 번역
        public static string Translate(string korea)
        {

            string url = "https://openapi.naver.com/v1/papago/n2mt";


            string clientid = "tjvN7vcWnA6xps7lHvkF";
            string secret = "zKR0bo2EIU";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", clientid);
            request.Headers.Add("X-Naver-Client-Secret", secret);
            request.Method = "POST";
            byte[] byteDataParams = Encoding.UTF8.GetBytes("source=ko&target=vi&text=" + korea);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteDataParams.Length;
            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string text = reader.ReadToEnd();
            stream.Close();
            response.Close();
            reader.Close();

            JObject jobj = JObject.Parse(text);
            string result = jobj["message"]["result"]["translatedText"].ToString();
            return result;

        }
        #endregion

        private void fpSpread1_CellClick_1(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0)
            {
                return;
            }
            //SetSpreadRowColor(fpSpread1);
            //fpSpread1.Sheets[0].Rows[e.Row].BackColor = Color.FromKnownColor(KnownColor.Pink);
            txtKoL.Text = fpSpread1.Sheets[0].Cells[e.Row, 0].Value.ToString();
            txtVNL.Text = fpSpread1.Sheets[0].Cells[e.Row, 1].Value.ToString();
            txtVNL.ReadOnly = true;
        }
    }


}
