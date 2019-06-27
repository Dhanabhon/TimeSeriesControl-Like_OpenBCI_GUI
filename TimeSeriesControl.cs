using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region Import
using System.Windows.Forms.DataVisualization.Charting;
#endregion Import

namespace TimeSeriesControl
{
    public partial class TimeSeriesControl: UserControl
    {
        #region Global Variables
        private int channelNumber = 1; // Default
        private int bufferSize = 128;  // Defalut
        private bool isOn = false;
        private bool isActive = false;

        private readonly Color[] channelColors = {
                Color.FromArgb(129, 129, 129),
                Color.FromArgb(124, 75, 129),
                Color.FromArgb(54, 87, 158),
                Color.FromArgb(49, 113, 89),
                Color.FromArgb(221, 178, 13),
                Color.FromArgb(253, 94, 52),
                Color.FromArgb(224, 56, 45),
                Color.FromArgb(162, 82, 49)
            };
        #endregion Global Variables

        #region Properties
        public bool IsOn
        {
            get
            {
                return this.isOn;
            }
        }

        public bool ImpledanceIsActive
        {
            get
            {
                return this.isActive;
            }
        }

        public int ChannelNumber
        {
            get
            {
                return this.channelNumber;
            }
            set
            {
                if (this.channelNumber <= 0)
                    this.channelNumber = 1;

                this.channelNumber = value;
                this.rbtnOnOff.Text = this.channelNumber.ToString();
                this.rbtnOnOff.BackColor = (this.channelColors[(this.channelNumber - 1) % 8]);
                this.chart.Series[0].Color = (this.channelColors[(this.channelNumber - 1) % 8]);
            }
        }

        public bool VoltageLabelEnabled
        {
            get
            {
                return this.lblVoltageValue.Enabled;
            }
            set
            {
                this.lblVoltageValue.Enabled = value;
            }
        }

        public string VoltageValue
        {
            get
            {
                return this.lblVoltageValue.Text;
            }
            set
            {
                this.lblVoltageValue.Text = value;
            }
        }

        public bool ImpedanceLabelEnabled
        {
            get
            {
                return this.lblImpedanceValue.Enabled;
            }
            set
            {
                this.lblImpedanceValue.Enabled = value;
            }
        }

        public string ImpedanceValue
        {
            get
            {
                return this.lblImpedanceValue.Text;
            }
            set
            {
                this.lblImpedanceValue.Text = value;
            }
        }

        public int SetBufferSize
        {
            get
            {
                return this.bufferSize;
            }
            set
            {
                this.bufferSize = value;
            }
        }
        #endregion Properties

        #region Contructor
        public TimeSeriesControl()
        {
            InitializeComponent();
        }
        #endregion Contructor

        #region Methods
        private void Initialize()
        {
            #region Initialize Label, TableLayoutPanel and Button
            this.lblImpedanceValue.Visible = false;

            this.tlpMain.ColumnStyles[0].Width = (this.rbtnOnOff.Width + this.rbtnImpedance.Width) + 20; // 20 is offset

            this.rbtnOnOff.Left = (this.pnLeftSide.Width - this.rbtnOnOff.Width) / 2 - (this.rbtnOnOff.Width / 2);
            this.rbtnOnOff.Top = (this.pnLeftSide.Height) / 2 - (this.rbtnOnOff.Height / 2);
            this.rbtnOnOff.Text = this.channelNumber.ToString();
            this.rbtnOnOff.BackColor = (this.channelColors[(this.channelNumber - 1) % 8]);

            this.rbtnImpedance.Left = (this.pnLeftSide.Width - this.rbtnImpedance.Width) / 2 + (this.rbtnImpedance.Width / 2);
            this.rbtnImpedance.Top = (this.pnLeftSide.Height) / 2 - (this.rbtnImpedance.Height / 2);
            this.rbtnImpedance.Text = "\u2126";
            this.rbtnImpedance.BackColor = Color.White;
            #endregion Initialize Label, TableLayoutPanel and Button

            #region Initialize Chart
            this.chart.Legends[0].Enabled = false;
            this.chart.Series.Add(this.channelNumber.ToString());
            this.chart.Series[0].BorderWidth = 2;

            this.chart.Series[0].ChartType = SeriesChartType.FastLine;
            this.chart.Series[0].Color = (this.channelColors[(this.channelNumber - 1) % 8]);

            this.chart.Series[0].IsVisibleInLegend = false;

            this.chart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            this.chart.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            this.chart.ChartAreas[0].AxisY.Maximum = Double.NaN;
            this.chart.ChartAreas[0].AxisY.Minimum = Double.NaN;

            this.chart.ChartAreas[0].AxisX.Maximum = 128;

            this.chart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            this.chart.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;

            this.Add(0.0);
            #endregion Initilize Chart

        }

        public void Add(double data)
        {
            if (this.chart.Series[0].Points == null)
                return;

            DataPointCollection points = this.chart.Series[0].Points;

            points.AddY(data);

            int count = points.Count;
            int num = count - this.bufferSize;
            for (int i = 0; i < num; i++)
            {
                points.RemoveAt(0);
            }

            this.chart.Invalidate();
        }

        public void Clear()
        {
            this.chart.Series.Clear();
        }

        public void ClearData()
        {
            foreach (Series series in this.chart.Series)
                series.Points.Clear();
        }

        private void RecalculateButtonSizeScale()
        {
            this.rbtnOnOff.Left = (this.pnLeftSide.Width - this.rbtnOnOff.Width) / 2 - (this.rbtnOnOff.Width / 2);
            this.rbtnOnOff.Top = (this.pnLeftSide.Height) / 2 - (this.rbtnOnOff.Height / 2);

            this.rbtnImpedance.Left = (this.pnLeftSide.Width - this.rbtnImpedance.Width) / 2 + (this.rbtnImpedance.Width / 2);
            this.rbtnImpedance.Top = (this.pnLeftSide.Height) / 2 - (this.rbtnImpedance.Height / 2);
        }
        #endregion Methods

        #region Events
        private void TimeSeriesControl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void TimeSeriesControl_SizeChanged(object sender, EventArgs e)
        {
            this.RecalculateButtonSizeScale();
        }

        private void RbtnOnOff_Click(object sender, EventArgs e)
        {
            if (!this.isOn)
                this.isOn = true;
            else
                this.isOn = false;
        }

        private void RbtnOnOff_MouseHover(object sender, EventArgs e)
        {
            this.rbtnOnOff.BackColor = Color.FromArgb(177, 184, 193);

        }

        private void RbtnOnOff_MouseLeave(object sender, EventArgs e)
        {
            if (this.isOn)
                this.rbtnOnOff.BackColor = Color.Black;
            else
                this.rbtnOnOff.BackColor = (this.channelColors[(this.channelNumber - 1) % 8]);
        }

        private void RbtnOnOff_MouseDown(object sender, MouseEventArgs e)
        {
            this.rbtnOnOff.BackColor = Color.FromArgb(150, 170, 200);
        }

        private void RbtnOnOff_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.isOn)
                this.rbtnOnOff.BackColor = Color.Black;
            else
                this.rbtnOnOff.BackColor = Color.FromArgb(177, 184, 193);
        }

        private void RbtnImpedance_Click(object sender, EventArgs e)
        {
            if (!this.isActive)
            {
                this.isActive = true;
                this.lblImpedanceValue.Visible = true;
            }
            else
            {
                this.isActive = false;
                this.lblImpedanceValue.Visible = false;
            }
        }

        private void RbtnImpedance_MouseHover(object sender, EventArgs e)
        {
            this.rbtnImpedance.BackColor = Color.FromArgb(177, 184, 193);
            this.rbtnImpedance.ForeColor = Color.White;
        }

        private void RbtnImpedance_MouseLeave(object sender, EventArgs e)
        {
            if (this.isActive)
            {
                this.rbtnImpedance.BackColor = Color.Black;
                this.rbtnImpedance.ForeColor = Color.White;
            }
            else
            {
                this.rbtnImpedance.BackColor = Color.White;
                this.rbtnImpedance.ForeColor = Color.Black;
            }
        }

        private void RbtnImpedance_MouseDown(object sender, MouseEventArgs e)
        {
            this.rbtnImpedance.BackColor = Color.FromArgb(150, 170, 200);
        }

        private void RbtnImpedance_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.isActive)
            {
                this.rbtnImpedance.BackColor = Color.Black;
                this.rbtnImpedance.ForeColor = Color.White;
            }
            else
            {
                this.rbtnImpedance.BackColor = Color.FromArgb(177, 184, 193);
            }
        }
        #endregion Events

    } // class
} // namespace
