using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SPAM.Common
{
    public class SpreadUtil
    {
        public static void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            if (ClientGlobal.DBAccess == "R")
            {
                //spread.Sheets[0].Reset();

                // Formulas and custom names must be loaded with R1C1 reference style
                spread.Sheets[0].ActiveSkin = FarPoint.Win.Spread.DefaultSkins.Professional2;
                spread.Sheets[0].ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
                spread.Sheets[0].RowCount = 10;
                //read.Sheets[0].ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(228, 236, 246);
                //spread.Sheets[0].ColumnHeader.DefaultStyle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
                //spread.Sheets[0].ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.Black;
                //spread.Sheets[0].ColumnHeader.DefaultStyle.Parent = "HeaderDefault";
                //spread.Sheets[0].DefaultStyle.BackColor = System.Drawing.Color.White;
                //spread.Sheets[0].DefaultStyle.ForeColor = System.Drawing.Color.Black;
                //spread.Sheets[0].RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(131, 134, 141);
                //spread.Sheets[0].RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(228, 236, 246);
                //spread.Sheets[0].RowHeader.DefaultStyle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
                //spread.Sheets[0].RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.Black;
                //spread.Sheets[0].RowHeader.DefaultStyle.Parent = "HeaderDefault";
                spread.Sheets[0].Rows.Default.Height = 25F;
                //spread.Sheets[0].SheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(131, 134, 141);
                //spread.Sheets[0].SheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(228, 236, 246);
                //spread.Sheets[0].SheetCornerStyle.ForeColor = System.Drawing.Color.White;
                //spread.Sheets[0].SheetCornerStyle.Parent = "HeaderDefault";
                spread.Sheets[0].ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;

                spread.Sheets[0].SetColumnAllowAutoSort(-1, true);
                spread.Sheets[0].ColumnHeader.AutoSortIndex = 0;

                spread.AllowColumnMove = true;
                spread.Sheets[0].DefaultStyle.Locked = true;

                FpSpread.SetSubFromContextMenu(spread);
            }
            else
            {
                //spread.Sheets[0].Reset();
                spread.HorizontalScrollBarHeight = 30;
                spread.VerticalScrollBarWidth = 30;

                // Formulas and custom names must be loaded with R1C1 reference style
                spread.Sheets[0].ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
                spread.Sheets[0].RowCount = 10;
                //spread.Sheets[0].ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin2", System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(222))))), FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.DimGray, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(93)))), ((int)(((byte)(90))))), System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(222))))), System.Drawing.Color.White, true, true, true, true, true);
                //spread.Sheets[0].ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(131, 134, 141);
                spread.Sheets[0].ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(228, 236, 246);
                spread.Sheets[0].ColumnHeader.DefaultStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
                spread.Sheets[0].ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.Black;
                spread.Sheets[0].ColumnHeader.DefaultStyle.Parent = "HeaderDefault";
                spread.Sheets[0].DefaultStyle.BackColor = System.Drawing.Color.White;
                spread.Sheets[0].DefaultStyle.ForeColor = System.Drawing.Color.Black;
                //spread.Sheets[0].RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(131, 134, 141);
                spread.Sheets[0].RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(228, 236, 246);
                spread.Sheets[0].RowHeader.DefaultStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
                spread.Sheets[0].RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.Black;
                spread.Sheets[0].RowHeader.DefaultStyle.Parent = "HeaderDefault";
                spread.Sheets[0].RowHeader.Columns[0].Width = 50;
                spread.Sheets[0].Rows.Default.Height = 40F;
                spread.Sheets[0].Rows.Default.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                //spread.Sheets[0].SheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(131, 134, 141);
                spread.Sheets[0].SheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(228, 236, 246);
                spread.Sheets[0].SheetCornerStyle.ForeColor = System.Drawing.Color.White;
                spread.Sheets[0].SheetCornerStyle.Parent = "HeaderDefault";
                spread.Sheets[0].ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;

                spread.Sheets[0].SetColumnAllowAutoSort(-1, true);
                spread.Sheets[0].ColumnHeader.AutoSortIndex = 0;

                spread.AllowColumnMove = true;
                spread.Sheets[0].DefaultStyle.Locked = true;
            }
        }

        public static int GetColumnIndex(FarPoint.Win.Spread.FpSpread spread, string tagName)
        {
            int nIndex = -1;

            for (int i = 0; i < spread.Sheets[0].Columns.Count; i++)
            {
                if (spread.Sheets[0].Columns[i].Tag.ToString() == tagName)
                {
                    nIndex = i;
                    break;
                }
            }

            return nIndex;
        }

        public static FarPoint.Win.Spread.CellType.NumberCellType GetNumberCellType(int decimalplaces)
        {
            FarPoint.Win.Spread.CellType.NumberCellType celltype = new FarPoint.Win.Spread.CellType.NumberCellType();
            celltype.Separator = ",";
            celltype.ShowSeparator = true;
            celltype.DecimalPlaces = decimalplaces;

            return celltype;
        }




    }
}
