using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Drawing;
using FarPoint.Win.Spread;
using System.Windows.Forms;

namespace SPAM.Common
{
    public static class FpSpread
    {
        //파포인트 스프레드 크기와 색상 설정
        public static void FpSpreadFrame(FarPoint.Win.Spread.FpSpread fs)
        {

            FpSpreadFrame(fs, true);
            fs.VerticalScrollBarPolicy = ScrollBarPolicy.AsNeeded;
            fs.HorizontalScrollBarPolicy = ScrollBarPolicy.AsNeeded;
        }

        //파포인트 스프레드 크기와 색상 설정
        public static void FpSpreadFrame(FarPoint.Win.Spread.FpSpread fs, bool rowColor)
        {

            SpreadUtil.InitSpread(fs);

            //Sheets[0]설정
            if (fs.Sheets.Count > 0)
            {
                fs.Sheets[0].RowCount = 0;
            }

            //마진값 설정
            fs.Margin = new System.Windows.Forms.Padding(0);

            //컬럼의 동적 이동을 허용함

            fs.AllowColumnMove = true;
            fs.RightToLeft = System.Windows.Forms.RightToLeft.No;

            if (rowColor)
            {
                fs.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(fpSpread_CellClick);
            }

            //FpSpread의 ContextMenu
            SetSubFromContextMenu(fs);
        }

        public static void fpSpread_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            FarPoint.Win.Spread.FpSpread fs = (FarPoint.Win.Spread.FpSpread)sender;//이벤트가 발생한  ToolStripMenuItem를 가져온다.

            int idx = e.Row;

            int rowCnt = fs.Sheets[0].RowCount;
            int colCnt = fs.Sheets[0].ColumnCount;

            //Row별로 처리 할 경우 컬럼별로 설정한 색은 사라짐 색을 유지하기 위해서는 Cell단위로 색을 적용해야 함 
            if (rowCnt > 0)
            {
                for (int i = 0; i < rowCnt; i++)
                {
                    //Row부분에 흰색이 아닐 경우 그 색을 유지 한다.
                    Color rowColor = fs.Sheets[0].Rows.Get(i).BackColor;
                    if (!rowColor.Name.Equals("White") && !rowColor.Name.Equals("0"))
                    {
                        fs.Sheets[0].Rows.Get(i).BackColor = rowColor;
                    }
                    else
                    {
                        for (int j = 0; j < colCnt; j++)
                        {
                            fs.Sheets[0].Cells.Get(i, j).BackColor = fs.Sheets[0].Columns.Get(j).BackColor;

                        }
                    }
                }

                for (int j = 0; j < colCnt; j++)
                {
                    fs.Sheets[0].Cells.Get(idx, j).BackColor = System.Drawing.Color.FromArgb(175, 215, 255);
                }
                /* Row별로 처리 할 경우 컬럼별로 설정한 색은 사라짐

                //for (int i = 0; i < rowCnt; i++)
                //{
                //    fs.Sheets[0].Rows[i].BackColor = Color.White;
                //}
                //fs.Sheets[0].Rows[idx].BackColor = System.Drawing.Color.FromArgb(175, 215, 255);
                 */
            }
        }

        //파포인트 스프레드 크기와 색상 설정 --사용안함
        public static void FpSpreadSheet(FarPoint.Win.Spread.SheetView sv)
        {

            sv.RowCount = 0;
            sv.OperationMode = FarPoint.Win.Spread.OperationMode.SingleSelect;

            if (sv.ColumnHeader.RowCount.Equals(1))
            {
                sv.ColumnHeader.Rows.Get(0).Height = 30F;
            }
            else
            {
                sv.ColumnHeader.Rows.Get(0).Height = 20F;
                sv.ColumnHeader.Rows.Get(1).Height = 20F;
            }

            /*
            sv.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            sv.AutoUpdateNotes = true;
            sv.ColumnHeader.DefaultStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;//System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            sv.ColumnHeader.DefaultStyle.Locked = false;
            sv.ColumnHeader.DefaultStyle.Parent = "HeaderDefault";
            sv.DefaultStyle.BackColor = System.Drawing.Color.White;
            sv.DefaultStyle.Locked = false;
            sv.DefaultStyle.Parent = "DataAreaDefault";
            sv.GrayAreaBackColor = System.Drawing.SystemColors.ButtonHighlight;
            sv.RowHeader.Visible = false;
            sv.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            sv.Rows.Default.Height = 25F;
            */
        }

        public static SheetView SetSheet(ParamPack param)
        {
            SheetView sv = new SheetView();

            SetSheetColumn(sv, param, 1);

            return sv;
        }

        public static SheetView SetSheet(ParamPack param, int headerRowCnt)
        {
            SheetView sv = new SheetView();

            SetSheetColumn(sv, param, headerRowCnt);

            return sv;
        }

        public static void SetSheetColumn(SheetView sv, ParamPack param)
        {
            SetSheetColumn(sv, param, 1);
        }
        public static void SetSheetColumn(SheetView sv, ParamPack param, int headerRowCnt)
        {
            Hashtable htss = new Hashtable();

            int columnCnt = param.Count;

            bool LockYn = true;

            // Formulas and custom names must be loaded with R1C1 reference style
            sv.RowHeader.Visible = true;
            sv.ColumnHeader.RowCount = headerRowCnt;
            sv.ColumnCount = columnCnt;
            sv.SheetName = "Sheet1";
            sv.Rows.Default.Height = 25F;

            for (int i = 0; i < columnCnt; i++)
            {
                Hashtable ht = (Hashtable)param[i];

                int rowSpan = headerRowCnt - (int)ht["Span"];

                sv.Columns.Get(i).Label = ht["Label"].ToString();

                sv.ColumnHeader.Cells.Get(rowSpan, i).Value = ht["Label"].ToString();
                sv.ColumnHeader.Cells.Get(rowSpan, i).RowSpan = (int)ht["Span"];
                sv.ColumnHeader.Cells.Get(rowSpan, i).Tag = ht["DataField"].ToString();

                sv.Columns.Get(i).DataField = ht["DataField"].ToString();
                //sv.Columns.Get(i).Font = new System.Drawing.Font("굴림", 9F, (FontStyle)ht["FontStyle"], System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                //sv.Columns.Get(i).HorizontalAlignment = SetAlignment((FpAlignment)ht["Alignment"]);

                float cellWidth = (float)ht["Width"];

                sv.Columns.Get(i).Width = cellWidth;
                sv.Columns.Get(i).Visible = (bool)ht["Visible"];
                sv.Columns.Get(i).Locked = (bool)ht["Lock"];
                //쓰기 컬럼이 있는지화인
                if (!(bool)ht["Lock"])
                {
                    LockYn = false;
                }
                //정렬기능
                if ((FpSort)ht["Sort"] == FpSort.False)
                    sv.Columns.Get(i).AllowAutoSort = false;
                else
                    sv.Columns.Get(i).AllowAutoSort = true;

                /* 배경색 일단 사용안함
                if (ht["BackColor"] != null)
                {
                    sv.Columns.Get(i).BackColor = (Color)ht["BackColor"];
                }
                */
                sv.Columns.Get(i).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;

                switch ((FpCellType)ht["CellType"])
                {
                    case FpCellType.Button:
                        FarPoint.Win.Spread.CellType.ButtonCellType button = new FarPoint.Win.Spread.CellType.ButtonCellType();
                        sv.Columns.Get(i).CellType = button;
                        break;
                    case FpCellType.CheckBox:
                        FarPoint.Win.Spread.CellType.CheckBoxCellType checkBox = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
                        sv.Columns.Get(i).CellType = checkBox;
                        break;
                    case FpCellType.ComboBox:
                        FarPoint.Win.Spread.CellType.ComboBoxCellType comboBox = new FarPoint.Win.Spread.CellType.ComboBoxCellType();

                        //콤보박스에 바인딩할 리스트가 있으면 실행
                        if ((ParamPack)ht["ListBox"] != null)
                        {
                            ParamPack list = (ParamPack)ht["ListBox"];

                            String[] items = new String[list.Count];
                            String[] itemData = new String[list.Count];
                            for (int k = 0; k < list.Count; k++)
                            {
                                items[k] = list.Items[k].ToString();
                                itemData[k] = list.Params[k].ToString();
                            }

                            comboBox.Items = (items);//Text 부분

                            comboBox.ItemData = (itemData);///Value 부분


                            //Value값 지정

                            comboBox.EditorValue = FarPoint.Win.Spread.CellType.EditorValue.ItemData; //이 부분이 빠지면 안됨.. 
                        }

                        sv.Columns.Get(i).CellType = comboBox;
                        break;
                    case FpCellType.DateTime:
                        FarPoint.Win.Spread.CellType.DateTimeCellType dateTime = new FarPoint.Win.Spread.CellType.DateTimeCellType();
                        sv.Columns.Get(i).CellType = dateTime;
                        break;
                    case FpCellType.General:
                        FarPoint.Win.Spread.CellType.GeneralCellType general = new FarPoint.Win.Spread.CellType.GeneralCellType();
                        sv.Columns.Get(i).CellType = general;
                        break;
                    case FpCellType.Text:
                        FarPoint.Win.Spread.CellType.TextCellType text = new FarPoint.Win.Spread.CellType.TextCellType();                        
                        sv.Columns.Get(i).CellType = text;
                        break;
                    case FpCellType.Number:
                        FarPoint.Win.Spread.CellType.NumberCellType Number = new FarPoint.Win.Spread.CellType.NumberCellType();
                        Number.Separator = ",";
                        Number.ShowSeparator = true;
                        Number.DecimalPlaces = 0;
                        sv.Columns.Get(i).CellType = Number;
                        break;
                    case FpCellType.Counter:
                        FarPoint.Win.Spread.CellType.NumberCellType Counter = new FarPoint.Win.Spread.CellType.NumberCellType();
                        Counter.Separator = ",";
                        Counter.ShowSeparator = true;
                        Counter.DecimalPlaces = 0;
                        sv.Columns.Get(i).CellType = Counter;
                        break;
                    case FpCellType.Decimal:
                        FarPoint.Win.Spread.CellType.NumberCellType Decimal = new FarPoint.Win.Spread.CellType.NumberCellType();
                        Decimal.Separator = ",";
                        Decimal.ShowSeparator = true;
                        Decimal.DecimalPlaces = 1;
                        sv.Columns.Get(i).CellType = Decimal;
                        break;
                    case FpCellType.Password:
                        FarPoint.Win.Spread.CellType.TextCellType pass = new FarPoint.Win.Spread.CellType.TextCellType();
                        pass.PasswordChar = '*';
                        sv.Columns.Get(i).CellType = pass;
                        break;
                    default:
                        FarPoint.Win.Spread.CellType.GeneralCellType general2 = new FarPoint.Win.Spread.CellType.GeneralCellType();
                        sv.Columns.Get(i).CellType = general2;
                        
                        break;
                }
            }

            sv.RowCount = 0;
            //읽기모드만 있을 경우
            //if (LockYn)
            //    sv.OperationMode = FarPoint.Win.Spread.OperationMode.SingleSelect;

            //헤더의 높이 조정
            if (headerRowCnt.Equals(1))
            {
                sv.ColumnHeader.Rows.Get(0).Height = 30F;
            }
            else
            {
                sv.ColumnHeader.Rows.Get(0).Height = 20F;
                sv.ColumnHeader.Rows.Get(1).Height = 20F;
            }

        }


        //셀의 데이타를 문자형으로 전환
        //Null값 체크를 위해 사용
        public static string StringCellValue(object value, string baseStr)
        {
            string reVal = baseStr;
            if (value != null)
                reVal = value.ToString();

            return reVal;

        }
        //날짜를 데이타에 저장할 타임으로 변환
        public static string InDateCellValue(object value)
        {
            string reVal = string.Empty;
            if (value != null)
                reVal = value.ToString().Replace("-", string.Empty).Replace(" ", string.Empty).Replace(":", string.Empty);

            if (reVal.Length > 8)
                reVal = reVal.Substring(0, 8);

            return reVal;
        }

        #region 해쉬테이블 생성 - FontStyle 디폴트 세팅
        //해쉬테이블 생성
        //Label/DataField/CellType/Alignment/Width/Visible/Lock
        public static Hashtable SetSheetColumns(
              string headerNm
            , string dataField
            , FpCellType cellType
            , FpAlignment alignment
            , Single width
            , bool visible
            , bool lockYn
            , FpSort sort
            , ParamPack list)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Label", headerNm);
            ht.Add("DataField", dataField);
            ht.Add("CellType", cellType);
            ht.Add("FontStyle", FontStyle.Regular);
            ht.Add("Alignment", alignment);
            ht.Add("Width", width);
            ht.Add("BackColor", System.Drawing.Color.White);
            ht.Add("Visible", visible);
            ht.Add("Lock", lockYn);
            ht.Add("Sort", sort);
            ht.Add("Span", 1);
            ht.Add("ListBox", list);

            return ht;
        }

        //해쉬테이블 생성
        //Label/DataField/CellType/Alignment/Width/Visible/Lock
        public static Hashtable SetSheetColumns(
              string headerNm
            , string dataField
            , FpCellType cellType
            , FpAlignment alignment
            , Single width
            , System.Drawing.Color bgColor
            , bool visible
            , bool lockYn
            , FpSort sort
            , int rowSpan
            , ParamPack list)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Label", headerNm);
            ht.Add("DataField", dataField);
            ht.Add("CellType", cellType);
            ht.Add("FontStyle", FontStyle.Regular);
            ht.Add("Alignment", alignment);
            ht.Add("Width", width);
            ht.Add("BackColor", bgColor);
            ht.Add("Visible", visible);
            ht.Add("Lock", lockYn);
            ht.Add("Sort", sort);
            ht.Add("Span", rowSpan);
            ht.Add("ListBox", list);

            return ht;
        }
        #endregion


        //해쉬테이블 생성
        //Label/DataField/CellType/FontStyle/Alignment/Width/Visible/Lock
        public static Hashtable SetSheetColumns(
              string headerNm
            , string dataField
            , FpCellType cellType
            , FontStyle fontStyle
            , FpAlignment alignment
            , Single width
            , bool visible
            , bool lockYn
            , FpSort sort
            , ParamPack list)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Label", headerNm);
            ht.Add("DataField", dataField);
            ht.Add("CellType", cellType);
            ht.Add("FontStyle", fontStyle);
            ht.Add("Alignment", alignment);
            ht.Add("Width", width);
            ht.Add("BackColor", null);
            ht.Add("Visible", visible);
            ht.Add("Lock", lockYn);
            ht.Add("Sort", sort);
            ht.Add("Span", 1);
            ht.Add("ListBox", list);

            return ht;
        }

        //해쉬테이블 생성
        //Label/DataField/CellType/FontStyle/Alignment/Width/Visible/Lock
        public static Hashtable SetSheetColumns(
              string headerNm
            , string dataField
            , FpCellType cellType
            , FontStyle fontStyle
            , FpAlignment alignment
            , Single width
            , System.Drawing.Color bgColor
            , bool visible
            , bool lockYn
            , FpSort sort
            , int rowSpan
            , ParamPack list)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Label", headerNm);
            ht.Add("DataField", dataField);
            ht.Add("CellType", cellType);
            ht.Add("FontStyle", fontStyle);
            ht.Add("Alignment", alignment);
            ht.Add("Width", width);
            ht.Add("BackColor", bgColor);
            ht.Add("Visible", visible);
            ht.Add("Lock", lockYn);
            ht.Add("Sort", sort);
            ht.Add("Span", rowSpan);
            ht.Add("ListBox", list);

            return ht;
        }

        /// <summary>
        /// 데이타 테이블 시트에 바인딩--DataField이용
        /// </summary>
        public static void SetSheetDataBind(FarPoint.Win.Spread.SheetView sv, DataTable dt)
        {
            //초기화

            sv.RowCount = 0;

            int dtColCnt = dt.Columns.Count;
            int dtRowCnt = dt.Rows.Count;
            int svCellCnt = sv.Columns.Count;

            //Tag위치를 찾기 위한 헤더 RowCount 조회
            int headerRow = sv.ColumnHeader.RowCount - 1;//위치좌표는 0부터이므로 -1을 한다.

            /*
            for (int i = 0; i < svCellCnt; i++)
            {
                string dataFieldNm = string.Empty;
                if (sv.ColumnHeader.Cells.Get(headerRow, i).Tag == null)
                {
                    dataFieldNm = sv.ColumnHeader.Cells.Get(0, i).Tag.ToString().ToLower();
                }
                else
                {
                    dataFieldNm = sv.ColumnHeader.Cells.Get(headerRow, i).Tag.ToString().ToLower();
                }

                sv.Columns.Get(i).DataField = dataFieldNm;
            }

            sv.DataSource = dt;
            */


            Hashtable ht = new Hashtable();

            //데이타 Row수 만큼 행을 만든다.
            sv.RowCount = dtRowCnt;

            for (int i = 0; i < dtColCnt; i++)
            {
                ht.Add(dt.Columns[i].ColumnName.ToLower(), i);
            }

            for (int i = 0; i < svCellCnt; i++)
            {
                string dataFieldNm = string.Empty;
                if (sv.ColumnHeader.Cells.Get(headerRow, i).Tag == null)
                {
                    dataFieldNm = sv.ColumnHeader.Cells.Get(0, i).Tag.ToString().ToLower();
                }
                else
                {
                    dataFieldNm = sv.ColumnHeader.Cells.Get(headerRow, i).Tag.ToString().ToLower();
                }
                //테그정보를 못 찾을 경우에 DataField를 확인
                if (dataFieldNm.Equals(string.Empty))
                {
                    dataFieldNm = sv.Columns.Get(i).DataField.ToLower();
                }

                if (ht[dataFieldNm] != null)
                {
                    //this.fpSpread1_Sheet1.Cells.Get(행, 열).Value

                    for (int j = 0; j < dtRowCnt; j++)
                    {
                        sv.Cells.Get(j, i).Value = dt.Rows[j][(int)ht[dataFieldNm]];
                    }
                }
            }

        }

        /// <summary>
        /// 데이타 테이블 컬럼에 따른 Cell 위치 기져오기
        /// </summary>
        public static int GetSheetColumnByTag(FarPoint.Win.Spread.SheetView sv, string tagNm)
        {
            int column = 0;

            int svCellCnt = sv.Columns.Count;

            //Tag위치를 찾기 위한 헤더 RowCount 조회
            int headerRow = sv.ColumnHeader.RowCount - 1;//위치좌표는 0부터이므로 -1을 한다.

            for (int i = 0; i < svCellCnt; i++)
            {
                string dataFieldNm = string.Empty;
                if (sv.ColumnHeader.Cells.Get(headerRow, i).Tag == null)
                {
                    dataFieldNm = sv.ColumnHeader.Cells.Get(0, i).Tag.ToString().ToLower();
                }
                else
                {
                    dataFieldNm = sv.ColumnHeader.Cells.Get(headerRow, i).Tag.ToString().ToLower();
                }

                if (dataFieldNm.Equals(tagNm.ToLower()))
                {
                    column = i;
                    break;
                }
            }

            return column;
        }

        /// <summary>
        /// 데이타 테이블 시트에 바인딩--ColumnHeader의 Tag 이용
        /// </summary>
        public static void SetSheetTagDataBind(FarPoint.Win.Spread.SheetView sv, DataTable dt)
        {
            Hashtable ht = new Hashtable();

            int dtColCnt = dt.Columns.Count;
            int dtRowCnt = dt.Rows.Count;
            //데이타 Row수 만큼 행을 만든다.
            sv.RowCount = dtRowCnt;

            //Tag위치를 찾기 위한 헤더 RowCount 조회
            int headerRow = sv.ColumnHeader.RowCount - 1;//위치좌표는 0부터이므로 -1을 한다.

            for (int i = 0; i < dtColCnt; i++)
            {
                ht.Add(dt.Columns[i].ColumnName.ToLower(), i);
            }

            int svCellCnt = sv.Columns.Count;

            for (int i = 0; i < svCellCnt; i++)
            {
                string dataFieldNm = sv.ColumnHeader.Cells.Get(headerRow, i).Tag.ToString().ToLower();

                if (ht[dataFieldNm] != null)
                {
                    //this.fpSpread1_Sheet1.Cells.Get(행, 열).Value

                    for (int j = 0; j < dtRowCnt; j++)
                    {
                        sv.Cells.Get(j, i).Value = dt.Rows[j][(int)ht[dataFieldNm]].ToString();
                    }
                }
            }
        }

        /// <summary>
        /// 파포인트 시트 저장

        /// </summary>
        public static void SaveExcel(FarPoint.Win.Spread.FpSpread fpSpread)
        {
            string fileName = string.Empty;
            bool saveYn = false;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Excel 파일 (*.xls)|*.xls|모든 파일 (*.*)|*.*";

            //저장할 파일 경로를 호출 한다.
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;

                //저장시 콤보박스는 벨류값이  저장됨

                string sheetNm = fpSpread.ActiveSheet.SheetName;
                //라인 설정
                FarPoint.Win.LineBorder lineBorder = new FarPoint.Win.LineBorder(System.Drawing.SystemColors.WindowFrame);

                FarPoint.Win.Spread.FpSpread fs = new FarPoint.Win.Spread.FpSpread();

                FarPoint.Win.Spread.SheetView sv = new SheetView();
                sv = (FarPoint.Win.Spread.SheetView)(FarPoint.Win.Serializer.LoadObjectXml(typeof(FarPoint.Win.Spread.SheetView), FarPoint.Win.Serializer.GetObjectXml(fpSpread.ActiveSheet, "CopySheet"), "CopySheet"));

                sv.RowHeader.Visible = false;
                sv.SheetName = sheetNm;

                int svCellCnt = sv.ColumnCount;
                int svRowCnt = sv.RowCount;


                for (int i = 0; i < svCellCnt; i++)
                {
                    if (sv.Columns.Get(i).CellType == null)
                    {
                        continue;
                    }

                    string cellTp = sv.Columns.Get(i).CellType.ToString();
                    bool visible = sv.Columns.Get(i).Visible;

                    if (cellTp.Equals("CheckBoxCellType") || !visible)
                    {
                        sv.Columns.Remove(i, 1);
                        svCellCnt--;

                        //sv.Columns.Get(i).Visible = false;
                    }
                    else
                    {
                        for (int j = 0; j < svRowCnt; j++)
                        {
                            //셀별 속성 설정-배경색:화이트, 라인설정
                            sv.Cells.Get(j, i).Border = lineBorder;
                            sv.Cells.Get(j, i).BackColor = Color.White;
                            //콤보박스일경우 벨류값대신 화면에 보이는 Text값으로 변경

                            if (cellTp.Equals("ComboBoxCellType"))
                            {
                                sv.Cells.Get(j, i).Value = FpSpread.StringCellValue(sv.Cells.Get(j, i).Text, string.Empty);
                            }
                        }
                    }
                }

                int headRowCnt = sv.ColumnHeader.RowCount;
                for (int i = 0; i < svCellCnt; i++)
                {
                    for (int j = 0; j < headRowCnt; j++)
                    {
                        sv.ColumnHeader.Cells.Get(j, i).Border = lineBorder;
                    }
                }

                //헤더부분


                //sv.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.White;
                //sv.ColumnHeader.DefaultStyle.Border = lineBorder;
                ////셀부분


                //sv.DefaultStyle.Border = lineBorder;

                sv.Protect = false;//엑셀출력시 시트보호 해제방법

                fs.Sheets.Add(sv);

                saveYn = fs.SaveExcel(fileName, FarPoint.Excel.ExcelSaveFlags.SaveBothCustomRowAndColumnHeaders);

                fs.Dispose();

                //fpSpread.ActiveSheet.Protect = false;//엑셀출력시 시트보호 해제방법

                //saveYn = fpSpread.SaveExcel(fileName, FarPoint.Excel.ExcelSaveFlags.SaveBothCustomRowAndColumnHeaders);

                //fpSpread.ActiveSheet.Protect = true;//저장후 다시 true로 원 위치 시킴


                //FarPoint.Excel.ExcelSaveFlags
                //FarPoint.Win.Spread.Model.IncludeHeaders.None
            }
            //저장에 성공하면 저장된 파일을 연다.
            if (saveYn)
            {
                System.Diagnostics.Process.Start(fileName);
            }

        }

        /// <summary>
        /// Spread.Alignment - 셀의 정렬 방식 설정
        /// </summary>
        public static CellHorizontalAlignment SetAlignment(FpAlignment align)
        {
            CellHorizontalAlignment cha = new CellHorizontalAlignment();

            if (FpAlignment.General.Equals(align))
                cha = CellHorizontalAlignment.General;
            else if (FpAlignment.Center.Equals(align))
                cha = CellHorizontalAlignment.Center;
            else if (FpAlignment.Left.Equals(align))
                cha = CellHorizontalAlignment.Left;
            else if (FpAlignment.Right.Equals(align))
                cha = CellHorizontalAlignment.Right;
            else
                cha = CellHorizontalAlignment.General;

            return cha;
        }

        /// <summary>
        /// FarPoint Spread SheetView 의 바인딩 데이타 머지(데이타 필드로 머지)
        /// </summary>
        public static void FarPointCellMerge(FarPoint.Win.Spread.SheetView sv, string dataField)
        {
            int columnCnt = sv.Columns.Count;
            int mergeColumn = -1;

            for (int i = 0; i < columnCnt; i++)
            {
                string getDataField = sv.Columns.Get(i).DataField.ToLower();

                if (getDataField.Trim().Equals(dataField.ToLower().Trim()))
                {
                    mergeColumn = i;
                    break;
                }
            }
            if (!mergeColumn.Equals(-1))
                FarPointCellMerge(sv, mergeColumn);
        }

        /// <summary>
        /// FarPoint Spread SheetView 의 바인딩 데이타 머지
        /// </summary>
        public static void FarPointCellMerge(FarPoint.Win.Spread.SheetView sv, int column)
        {
            int colCnt = sv.RowCount;
            string oldValue = string.Empty;
            string newValue = string.Empty;
            int row = 0;
            int rowSpan = 1;
            for (int i = 0; i < colCnt; i++)
            {
                newValue = sv.Cells.Get(i, column).Value.ToString();

                if (newValue.Equals(oldValue))
                {
                    rowSpan++;
                }
                else
                {
                    oldValue = sv.Cells.Get(i, column).Value.ToString();
                    sv.Cells.Get(row, column).RowSpan = rowSpan;
                    //재설정




                    row = i;
                    rowSpan = 1;
                }

                if (i.Equals(colCnt - 1) && rowSpan > 1)
                {
                    sv.Cells.Get(row, column).RowSpan = rowSpan;
                }
            }
        }

        //시트에 바인딩 된 데이타 계산하기
        public static void SetDataCalculation(FarPoint.Win.Spread.SheetView sv, string BaseCel, ParamPack param, int BaseColSpan)
        {
            int rowCnt = sv.RowCount;
            int celBaseCel = FpSpread.GetSheetColumnByTag(sv, BaseCel);

            ParamPack celParam = new ParamPack();
            Hashtable ht = new Hashtable();

            for (int i = 0; i < param.Count; i++)
            {
                int cel = FpSpread.GetSheetColumnByTag(sv, param.Items[i].ToString());
                celParam.Add(cel.ToString(), param.Params[i].ToString());
            }

            for (int i = 0; i < celParam.Count; i++)
            {
                ht.Add(celParam.Items[i].ToString(), 0);
            }

            int setCnt = 0;

            string baseNm = string.Empty;//현재행 조건 명

            string newBaseNm = string.Empty;//다음행 조건명

        }

        /// <summary>
        /// HorizontalAlignment
        /// </summary>
        public enum FpAlignment
        {
            // 요약:
            //     Aligns the cell contents according to the cell's interpretation of the contents
            General = 0,
            //
            // 요약:
            //     Aligns the cell contents to the left
            Left = 1,
            //
            // 요약:
            //     Centers the contents in the cell horizontally
            Center = 2,
            //
            // 요약:
            //     Aligns the cell contents to the right
            Right = 3
        }

        /// <summary>
        /// Spread.CellType
        /// </summary>
        public enum FpCellType
        {
            // 요약:
            //     ComboBoxCellType
            ComboBox = 0,
            //
            // 요약:
            //     ButtonCellType
            Button = 1,
            //
            // 요약:
            //     CheckBoxCellType
            CheckBox = 2,
            //
            // 요약:
            //     TextCellType
            Text = 3,
            //
            // 요약:
            //     GeneralCellType
            General = 4,
            //
            // 요약:
            //     DateTimeCellType
            DateTime = 5,
            //
            // 요약:
            //     NumberCellType
            Number = 6,
            //
            // 요약:
            //     NumberCellType
            Counter = 7,
            //
            // 요약:
            //     NumberCellType
            Decimal = 8,
            //
            // 요약:
            //     NumberCellType
            Password = 9,

        }

        /// <summary>
        /// Spread.CellType
        /// </summary>
        public enum FpSort
        {
            // 요약:
            //     AllowAutoSort = true
            True = 1,
            //
            // 요약:
            //     AllowAutoSort = false
            False = 0
        }
        //가변적으로 셀안의 배경삭 설정시사용

        public static Color CellBgColor(int i)
        {
            Color clr = new Color();

            i = i % 15;

            switch (i)
            {
                case 0: clr = System.Drawing.Color.Tan; break;
                case 1: clr = System.Drawing.Color.NavajoWhite; break;
                case 2: clr = System.Drawing.Color.Gold; break;
                case 3: clr = System.Drawing.Color.Yellow; break;
                case 4: clr = System.Drawing.Color.Chartreuse; break;
                case 5: clr = System.Drawing.Color.PaleGreen; break;
                case 6: clr = System.Drawing.Color.SpringGreen; break;
                case 7: clr = System.Drawing.Color.Aquamarine; break;
                case 8: clr = System.Drawing.Color.PaleTurquoise; break;
                case 9: clr = System.Drawing.Color.LightBlue; break;
                case 10: clr = System.Drawing.Color.LightSkyBlue; break;
                case 11: clr = System.Drawing.Color.Thistle; break;
                case 12: clr = System.Drawing.Color.Pink; break;
                case 13: clr = System.Drawing.Color.LavenderBlush; break;
                case 14: clr = System.Drawing.Color.Silver; break;
            }

            return clr;

        }

        #region FpSpread의 ContextMenu

        //FpSpread의 왼쪽 마우스 클릭시 호출되는 ContextMenu 만들기


        public static void SetSubFromContextMenu(FarPoint.Win.Spread.FpSpread fs)
        {
            ContextMenuStrip cns = new ContextMenuStrip();

            ToolStripMenuItem tsmExcel = new ToolStripMenuItem();
            tsmExcel.Name = "tsmExcel";
            tsmExcel.Text = "엑셀출력";
            tsmExcel.Click += new System.EventHandler(SubFormContextMenuStrip_Click);

            ToolStripMenuItem tsmPrintView = new ToolStripMenuItem();
            tsmPrintView.Name = "tsmNewFrom";
            tsmPrintView.Text = "새창으로 보기";
            tsmPrintView.Click += new System.EventHandler(SubFormContextMenuStrip_Click);

            cns.Items.AddRange(new ToolStripItem[] { tsmExcel });
            cns.ResumeLayout(false);

            fs.ContextMenuStrip = cns;
            fs.ResumeLayout(false);
        }

        //FpSpread의 ContextMenu 이베트 발생 처리
        public static void SubFormContextMenuStrip_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;//이벤트가 발생한  ToolStripMenuItem를 가져온다.

            ContextMenuStrip cns = (ContextMenuStrip)tsmi.Owner;//부모 메뉴 알아낸다.

            FarPoint.Win.Spread.FpSpread fs = (FarPoint.Win.Spread.FpSpread)cns.SourceControl;//부모 메뉴에 연결된 콘트롤로를 알아낸다. FpSpread로 변환한다.

            string tsmMuNm = tsmi.Name.ToString();

            switch (tsmMuNm.ToUpper())
            {
                case "TSMEXCEL":
                    SaveExcel(fs);
                    break;
                case "TSMNEWFROM":
                    SetNewFrom(fs);
                    break;
            }
        }

        //FpSpread의 첫번째 시트를 새로운 FpSpread에 담아 새로은 폼으로 만들오 호출 한다.
        public static void SetNewFrom(FarPoint.Win.Spread.FpSpread fs)
        {
            //새로운 FpSpread 만든다.
            FarPoint.Win.Spread.FpSpread newFs = new FarPoint.Win.Spread.FpSpread();
            FpSpread.FpSpreadFrame(newFs);

            //시트를 카피한다.
            FarPoint.Win.Spread.SheetView sv = new SheetView();
            sv = (FarPoint.Win.Spread.SheetView)(FarPoint.Win.Serializer.LoadObjectXml(typeof(FarPoint.Win.Spread.SheetView), FarPoint.Win.Serializer.GetObjectXml(fs.ActiveSheet, "CopySheet"), "CopySheet"));
            newFs.Sheets.Add(sv);

            //새로운 폼으로 만든다.
            Form fm = new Form();
            fm.WindowState = FormWindowState.Maximized;
            fm.Padding = new System.Windows.Forms.Padding(10);
            newFs.Dock = DockStyle.Fill;
            fm.Controls.Add(newFs);//새로운 FpSpread 삽입.
            fm.Show();//일반 팝업으로 호출---모달 팝업 안됨
        }

        #endregion


    }
}
