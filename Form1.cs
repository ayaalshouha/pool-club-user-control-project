using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Club_UserControl_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void poolTable1_OnTableCompleted(object sender, PoolTable.PoolTableEventArgs e)
        {

            MessageBox.Show($@"Game Completed! Time Consumed = {e.TimeConsumed} , Total Seconed = {e.TotalSecond}, Hourly Rate = {e.HourlyRate} and Total Fees = {e.TotalFees}. :-)", "Message Box", MessageBoxButtons.OK,
                MessageBoxIcon.Information); 
        }

        private void poolTable2_OnTableCompleted(object sender, PoolTable.PoolTableEventArgs e)
        {
            MessageBox.Show($@"Game Completed! Time Consumed = {e.TimeConsumed} , Total Seconed = {e.TotalSecond}, Hourly Rate = {e.HourlyRate} and Total Fees = {e.TotalFees}. :-)", "Message Box", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        
    }
}
