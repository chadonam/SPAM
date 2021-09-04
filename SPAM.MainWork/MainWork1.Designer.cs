namespace SPAM.MainWork
{
    partial class MainWork1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            FarPoint.Win.Chart.LabelArea labelArea1 = new FarPoint.Win.Chart.LabelArea();
            FarPoint.Win.Chart.LegendArea legendArea1 = new FarPoint.Win.Chart.LegendArea();
            FarPoint.Win.Chart.YPlotArea yPlotArea1 = new FarPoint.Win.Chart.YPlotArea();
            FarPoint.Win.Chart.Wall wall1 = new FarPoint.Win.Chart.Wall();
            FarPoint.Win.Chart.Wall wall2 = new FarPoint.Win.Chart.Wall();
            FarPoint.Win.Chart.DirectionalLight directionalLight1 = new FarPoint.Win.Chart.DirectionalLight();
            FarPoint.Win.Chart.BarSeries barSeries1 = new FarPoint.Win.Chart.BarSeries();
            FarPoint.Win.Chart.Wall wall3 = new FarPoint.Win.Chart.Wall();
            FarPoint.Win.Chart.IndexAxis indexAxis1 = new FarPoint.Win.Chart.IndexAxis();
            FarPoint.Win.Chart.ValueAxis valueAxis1 = new FarPoint.Win.Chart.ValueAxis();
            FarPoint.Win.Chart.IndexAxis indexAxis2 = new FarPoint.Win.Chart.IndexAxis();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.fpChart1 = new FarPoint.Win.Chart.FpChart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 620F));
            this.tableLayoutPanel1.Controls.Add(this.fpSpread1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fpChart1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1500, 900);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // fpSpread1
            // 
            this.fpSpread1.AccessibleDescription = "";
            this.fpSpread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpSpread1.Location = new System.Drawing.Point(3, 3);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.fpSpread1.Size = new System.Drawing.Size(874, 894);
            this.fpSpread1.TabIndex = 1;
            this.fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.fpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.fpSpread1_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.fpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // fpChart1
            // 
            this.fpChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpChart1.Location = new System.Drawing.Point(883, 3);
            labelArea1.AlignmentX = 0.5F;
            labelArea1.Location = new System.Drawing.PointF(0.5F, 0.1F);
            labelArea1.Padding = new FarPoint.Win.Chart.PaddingF(1.5F, 1.5F, 1.5F, 1.5F);
            labelArea1.Text = "Bar Chart";
            this.fpChart1.Model.LabelAreas.AddRange(new FarPoint.Win.Chart.LabelArea[] {
            labelArea1});
            legendArea1.AlignmentX = 1F;
            legendArea1.AlignmentY = 0.5F;
            legendArea1.Location = new System.Drawing.PointF(0.98F, 0.5F);
            legendArea1.Padding = new FarPoint.Win.Chart.PaddingF(3F, 3F, 3F, 3F);
            this.fpChart1.Model.LegendAreas.AddRange(new FarPoint.Win.Chart.LegendArea[] {
            legendArea1});
            wall1.Visible = true;
            yPlotArea1.BackWall = wall1;
            wall2.Visible = true;
            yPlotArea1.BottomWall = wall2;
            yPlotArea1.Elevation = 15F;
            yPlotArea1.GlobalAmbientLight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            directionalLight1.AmbientColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            directionalLight1.DiffuseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            directionalLight1.DirectionX = 10F;
            directionalLight1.DirectionY = 20F;
            directionalLight1.DirectionZ = 30F;
            directionalLight1.SpecularColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            yPlotArea1.Lights.Clear();
            yPlotArea1.Lights.AddRange(new FarPoint.Win.Chart.Light[] {
            directionalLight1});
            yPlotArea1.Location = new System.Drawing.PointF(0.2F, 0.2F);
            yPlotArea1.Projection = new FarPoint.Win.Chart.OrthogonalProjection();
            yPlotArea1.Rotation = -10F;
            barSeries1.SeriesName = "series";
            yPlotArea1.Series.AddRange(new FarPoint.Win.Chart.Series[] {
            barSeries1});
            wall3.Visible = true;
            yPlotArea1.SideWall = wall3;
            yPlotArea1.Size = new System.Drawing.SizeF(0.6F, 0.6F);
            yPlotArea1.XAxis = indexAxis1;
            yPlotArea1.YAxes.Clear();
            yPlotArea1.YAxes.AddRange(new FarPoint.Win.Chart.ValueAxis[] {
            valueAxis1});
            yPlotArea1.ZAxis = indexAxis2;
            this.fpChart1.Model.PlotAreas.AddRange(new FarPoint.Win.Chart.PlotArea[] {
            yPlotArea1});
            this.fpChart1.Name = "fpChart1";
            this.fpChart1.Size = new System.Drawing.Size(614, 894);
            this.fpChart1.TabIndex = 2;
            this.fpChart1.Text = "fpChart1";
            // 
            // MainWork1
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWork1";
            this.Size = new System.Drawing.Size(1500, 900);
            this.Load += new System.EventHandler(this.MainWork1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private FarPoint.Win.Chart.FpChart fpChart1;
    }
}