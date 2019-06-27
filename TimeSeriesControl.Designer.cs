namespace TimeSeriesControl
{
    partial class TimeSeriesControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnLeftSide = new System.Windows.Forms.Panel();
            this.pnRightSide = new System.Windows.Forms.Panel();
            this.lblVoltageValue = new System.Windows.Forms.Label();
            this.lblImpedanceValue = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbtnImpedance = new RoundButton();
            this.rbtnOnOff = new RoundButton();
            this.tlpMain.SuspendLayout();
            this.pnLeftSide.SuspendLayout();
            this.pnRightSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.White;
            this.tlpMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnLeftSide, 0, 0);
            this.tlpMain.Controls.Add(this.pnRightSide, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(780, 146);
            this.tlpMain.TabIndex = 1;
            // 
            // pnLeftSide
            // 
            this.pnLeftSide.BackColor = System.Drawing.Color.White;
            this.pnLeftSide.Controls.Add(this.rbtnImpedance);
            this.pnLeftSide.Controls.Add(this.rbtnOnOff);
            this.pnLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLeftSide.Location = new System.Drawing.Point(4, 4);
            this.pnLeftSide.Name = "pnLeftSide";
            this.pnLeftSide.Size = new System.Drawing.Size(164, 138);
            this.pnLeftSide.TabIndex = 1;
            // 
            // pnRightSide
            // 
            this.pnRightSide.Controls.Add(this.lblVoltageValue);
            this.pnRightSide.Controls.Add(this.lblImpedanceValue);
            this.pnRightSide.Controls.Add(this.chart);
            this.pnRightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRightSide.Location = new System.Drawing.Point(175, 4);
            this.pnRightSide.Name = "pnRightSide";
            this.pnRightSide.Size = new System.Drawing.Size(601, 138);
            this.pnRightSide.TabIndex = 5;
            // 
            // lblVoltageValue
            // 
            this.lblVoltageValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVoltageValue.BackColor = System.Drawing.Color.Transparent;
            this.lblVoltageValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(41)))));
            this.lblVoltageValue.Location = new System.Drawing.Point(538, 125);
            this.lblVoltageValue.Name = "lblVoltageValue";
            this.lblVoltageValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVoltageValue.Size = new System.Drawing.Size(60, 13);
            this.lblVoltageValue.TabIndex = 4;
            this.lblVoltageValue.Text = "0.00 uVrms";
            this.lblVoltageValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblImpedanceValue
            // 
            this.lblImpedanceValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblImpedanceValue.BackColor = System.Drawing.Color.Transparent;
            this.lblImpedanceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(41)))));
            this.lblImpedanceValue.Location = new System.Drawing.Point(3, 125);
            this.lblImpedanceValue.Name = "lblImpedanceValue";
            this.lblImpedanceValue.Size = new System.Drawing.Size(59, 13);
            this.lblImpedanceValue.TabIndex = 5;
            this.lblImpedanceValue.Text = "0.00 kOhm";
            this.lblImpedanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(601, 138);
            this.chart.TabIndex = 6;
            this.chart.Text = "chart1";
            // 
            // rbtnImpedance
            // 
            this.rbtnImpedance.BackColor = System.Drawing.Color.White;
            this.rbtnImpedance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbtnImpedance.ForeColor = System.Drawing.Color.Black;
            this.rbtnImpedance.Location = new System.Drawing.Point(76, 3);
            this.rbtnImpedance.Name = "rbtnImpedance";
            this.rbtnImpedance.Size = new System.Drawing.Size(50, 50);
            this.rbtnImpedance.TabIndex = 3;
            this.rbtnImpedance.Text = "1";
            this.rbtnImpedance.UseVisualStyleBackColor = false;
            this.rbtnImpedance.Click += new System.EventHandler(this.RbtnImpedance_Click);
            this.rbtnImpedance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RbtnImpedance_MouseDown);
            this.rbtnImpedance.MouseLeave += new System.EventHandler(this.RbtnImpedance_MouseLeave);
            this.rbtnImpedance.MouseHover += new System.EventHandler(this.RbtnImpedance_MouseHover);
            this.rbtnImpedance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RbtnImpedance_MouseUp);
            // 
            // rbtnOnOff
            // 
            this.rbtnOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbtnOnOff.ForeColor = System.Drawing.Color.White;
            this.rbtnOnOff.Location = new System.Drawing.Point(3, 3);
            this.rbtnOnOff.Name = "rbtnOnOff";
            this.rbtnOnOff.Size = new System.Drawing.Size(50, 50);
            this.rbtnOnOff.TabIndex = 2;
            this.rbtnOnOff.Text = "1";
            this.rbtnOnOff.UseVisualStyleBackColor = true;
            this.rbtnOnOff.Click += new System.EventHandler(this.RbtnOnOff_Click);
            this.rbtnOnOff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RbtnOnOff_MouseDown);
            this.rbtnOnOff.MouseLeave += new System.EventHandler(this.RbtnOnOff_MouseLeave);
            this.rbtnOnOff.MouseHover += new System.EventHandler(this.RbtnOnOff_MouseHover);
            this.rbtnOnOff.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RbtnOnOff_MouseUp);
            // 
            // TimeSeriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "TimeSeriesControl";
            this.Size = new System.Drawing.Size(780, 146);
            this.Load += new System.EventHandler(this.TimeSeriesControl_Load);
            this.SizeChanged += new System.EventHandler(this.TimeSeriesControl_SizeChanged);
            this.tlpMain.ResumeLayout(false);
            this.pnLeftSide.ResumeLayout(false);
            this.pnRightSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnLeftSide;
        private System.Windows.Forms.Panel pnRightSide;
        private System.Windows.Forms.Label lblImpedanceValue;
        private System.Windows.Forms.Label lblVoltageValue;
        private RoundButton rbtnImpedance;
        private RoundButton rbtnOnOff;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}
