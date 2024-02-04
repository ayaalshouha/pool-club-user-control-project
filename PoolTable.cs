using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Club_UserControl_Project
{
    public partial class PoolTable : UserControl
    {

        private enum TableMode { start = 0 , pause  };
        private TableMode _Mode = TableMode.start;
        public class PoolTableEventArgs : EventArgs
        {
            public string TimeConsumed { get; set; }
            public double TotalSecond { get; set; }
            public double HourlyRate { get; set; }
            public double TotalFees { get; set; }

            public PoolTableEventArgs(string timeconsumed, double totalsecond, double hourlyrate, double totalfees)
            {
                TimeConsumed = timeconsumed;
                TotalSecond = totalsecond;
                HourlyRate = hourlyrate;
                TotalFees = totalfees;
            }
        }

        public event EventHandler<PoolTableEventArgs> OnTableCompleted;
        public void RaiseTableCompleted()
        {
            RaiseTableCompleted(new PoolTableEventArgs(TimeConsumed, TotalSecond, HourlyRate, TotalFees));
        }
        protected virtual void RaiseTableCompleted(PoolTableEventArgs e)
        {
            OnTableCompleted?.Invoke(this, e);
        }


        private string TimeConsumed;
        private double TotalSecond = 0;
        private double HourlyRate = 10;
        private double TotalFees = 0.0;


        [Category("Pool Config"), Description("Rate Per Hour")]
        public double RatePerHour
        {
            get {  return HourlyRate; }
            set
            {
                HourlyRate = value; 
            }
        }

        [Category("Pool Config"), Description("Player Name")]
        public string PlayerName 
        {
            get { return lblPlayerName.Text; }
            set
            {
                lblPlayerName.Text = value;
            }
        }

        [Category("Pool Config"), Description("Table Title")]
        public string TableTitle
        {
            get { return TableHeader.Text; }
            set
            {
                TableHeader.Text = value;
            }
        }


        private string getFormattedTime(double Seconds)
        {
            TimeSpan timespan = TimeSpan.FromSeconds(Seconds);
            return timespan.ToString("hh\\:mm\\:ss");
        }

        public PoolTable()
        {
            InitializeComponent();
            lblTimer.Text = getFormattedTime(TotalSecond); 
        }
        private TableMode CheckTableMode()
        {
            if (btnStart.Text == "Start")
                return TableMode.start; 
            else
                return TableMode.pause;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _Mode = CheckTableMode();

            if (_Mode == TableMode.start)
            {
                tableTimer.Enabled = true;
                btnStart.Text = "Pause";
            }
            else
            {
                tableTimer.Enabled = false;
                btnStart.Text = "Start";
            }
        }

        private void tableTimer_Tick(object sender, EventArgs e)
        {
            TotalSecond++; 
            lblTimer.Text = getFormattedTime(TotalSecond);
        }

        private void _RefreshTable()
        {
            _Mode = TableMode.start;
            btnStart.Text = "Start";
            lblTimer.Text = "00:00:00";
            TotalSecond = 0;
            TotalFees = 0.0;
            lblPlayerName.Text = "Player Name";
            TableHeader.Text = "Table"; 
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            tableTimer.Enabled = false; 
            TimeConsumed = getFormattedTime(TotalSecond);
            TotalFees = HourlyRate * (TotalSecond / 3600); 
            RaiseTableCompleted();
            _RefreshTable(); 
        }
    }
}
