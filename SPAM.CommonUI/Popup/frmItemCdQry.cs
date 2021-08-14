using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SPAM.Common;
using SPAM.Manage;

namespace SPAM.CommonUI.Popup
{
    public partial class frmItemCdQry : Form
    {

        #region 생성자



        public frmItemCdQry()
        {
            InitializeComponent();
        }

        public frmItemCdQry(string[] arrParams)
        {
            InitializeComponent();

            if (arrParams.Length > 0)
            {
                txtItemNo.Text = arrParams[0].ToString();
            }
        }


        #endregion

        #region 멤버변수



        private string[] m_returnCode = {string.Empty, string.Empty, string.Empty }; //품목정보

        private enum m_index { itemSeq, ItemNo, itemName }; //품목정보

        #endregion //멤버변수



        private void frmItemCdQry_Load(object sender, EventArgs e)
        {

            SetFpSpread();
            SetControl();

            if (!txtItemNo.Text.Equals(string.Empty))
            {
                Search();
            }
        }

        //콘트롤러 설정
        private void SetControl()
        {
            #region 검색 조건 박스 설정
            //버튼설정 AdminSearchPanel전에 AdminBtn를 먼자 설정헌다--버튼 사이즈 문자로...
            BaseDisplay.AdminBtn(this.btnSearch, BaseDisplay.BtnType.Search);
            BaseDisplay.AdminBtn(this.btnClose, BaseDisplay.BtnType.Etc);
            //검색박스 설정
            BaseDisplay.AdminSearchPanel(pnlHeader);
            #endregion
        }

        //FpSpread 설정
        private void SetFpSpread()
        {
            /*
            설정시 주의 사항
            1.헤더의 RowSpan이 2 이상일 경우 컬럼에 AllowAutoSort가 저용 안됨
            2.컬럼 헤더 합치기(위치는 0부터)
            3.함수 적용 순서 엄수
            */

            ParamPack param = new ParamPack();

            //제조 오더별 실적
            param.Add(FpSpread.SetSheetColumns("품목내부코드", "ItemSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 100, true, false, FpSpread.FpSort.True, null));
            param.Add(FpSpread.SetSheetColumns("품목번호", "ItemNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 100, true, false, FpSpread.FpSort.True, null));
            param.Add(FpSpread.SetSheetColumns("품목명", "ItemNm", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 300, true, true, FpSpread.FpSort.True, null));


            #region FpSpread 설정
            //기존시트 사용시
            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param);

            //시트 생성시
            //this.fpSpread1.Sheets.Clear();
            //this.fpSpread1.Sheets.Add(FpSpread.SetSheet(param));
            //FpSpread.FpSpreadFrame(this.fpSpread1);
            #endregion
        }

        #region Event

        #region 조회 버튼 클릭
        /// <summary>
        /// 조회 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        #endregion

        #region 닫기 버튼 클릭
        /// <summary>
        /// 닫기 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 기타 이벤트


        //파포인트 셀 클릭 이벤트


        private void fpSpread1_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (this.fpSpread1.Sheets[0].RowCount > 0)
            {
                int rowNum = e.Row;
                int colNum = e.Column;


                int celItemSeq = FpSpread.GetSheetColumnByTag(this.fpSpread1.Sheets[0], "ItemSeq");
                int celItemNo = FpSpread.GetSheetColumnByTag(this.fpSpread1.Sheets[0], "ItemNo");
                int celItemNm = FpSpread.GetSheetColumnByTag(this.fpSpread1.Sheets[0], "ItemNm");

                string itemSeq = this.fpSpread1.Sheets[0].Cells.Get(rowNum, celItemSeq).Value.ToString();
                string itemNo = this.fpSpread1.Sheets[0].Cells.Get(rowNum, celItemNo).Value.ToString();
                string itemNm = this.fpSpread1.Sheets[0].Cells.Get(rowNum, celItemNm).Value.ToString();
                SetReturn(itemSeq,itemNo, itemNm);
            }
        }
        //키다운 이벤트 엔터키 처리
        private void frmItemCdQry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (fpSpread1.ActiveSheet.ActiveRow == null)
                {
                    Search();
                }
                else
                {
                    int rowIndex = fpSpread1.ActiveSheet.ActiveRowIndex;

                    int celItemSeq = FpSpread.GetSheetColumnByTag(this.fpSpread1.Sheets[0], "ItemSeq");
                    int celItemNo = FpSpread.GetSheetColumnByTag(this.fpSpread1.Sheets[0], "ItemNo");
                    int celItemNm = FpSpread.GetSheetColumnByTag(this.fpSpread1.Sheets[0], "ItemNm");

                    string itemSeq = this.fpSpread1.Sheets[0].Cells.Get(rowIndex, celItemSeq).Value.ToString();
                    string itemNo = this.fpSpread1.Sheets[0].Cells.Get(rowIndex, celItemNo).Value.ToString();
                    string itemNm = this.fpSpread1.Sheets[0].Cells.Get(rowIndex, celItemNm).Value.ToString();

                    SetReturn(itemSeq,itemNo, itemNm);
                }
            }
        }

        //키다운 이벤트


        private void txtItemNm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        #endregion

        #endregion

        #region DataBind 메소드



        #region 조회
        /// <summary>
        /// 조회
        /// </summary>
        private void Search()
        {
            string shItemNm = this.txtItemNm.Text.Trim();
            string shItemNo = this.txtItemNo.Text.Trim();

            //if (shItemNm.Equals(string.Empty) && shItemNo.Equals(string.Empty))
            //{
            //    MessageBox.Show(this, "조회할 품목명을 입력하세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.txtItemNm.Focus();

            //    return;
            //}

            DataSet ds = null;
            try
            {
                using (CommonService svc = new CommonService())
                {
                   ds = svc.GetItemCodeHelp(shItemNm, shItemNo);
                }

                if (ds.Tables[0].Rows.Count < 1)
                {
                    MessageHandler.DisplayMessage("조회된 데이타가 없습니다.", Common.Controls.MessageType.Warning);
                    this.fpSpread1.Sheets[0].Rows.Count = 0;
                    return;
                }

                FpSpread.SetSheetDataBind(this.fpSpread1.Sheets[0], ds.Tables[0]);

                //MessageHandler.DisplayMessage("저장되었습니다.", Common.Controls.MessageType.Information);
            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
            finally
            {
                if (ds != null) { ds.Dispose(); ds = null; }
            }
        }
        #endregion

        #endregion

        #region 사용자 정의 메소드



        /// <summary>
		/// 팝업
		/// </summary>
		/// <returns>object</returns>
		public object ShowDlg()
        {
            DialogResult dlgResult = this.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                // retVal이 object형 이므로 어떠한 형태로든 return이 가능하다.
                return m_returnCode;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
		/// 조회된 결과 반환
		/// </summary>
		private void SetReturn(string itemSeq, string itemNo, string itemNm)
        {
            m_returnCode[0] = itemSeq;
            m_returnCode[1] = itemNo;
            m_returnCode[2] = itemNm;
            this.DialogResult = DialogResult.OK;
        }

        #endregion
    }
}
