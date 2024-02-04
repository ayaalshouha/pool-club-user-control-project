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
    public partial class CustomMesssageBoxForm : Form
    {
        string timeConsumed = "";
        double totalSecond = 0;
        double hourlyrate = 0;
        double totalfees = 0;
        string TableTitle = ""; 
        public CustomMesssageBoxForm(string timeConsumed, double totalSecond, double hourlyrate, double totalfees, string title)
        {
            InitializeComponent();
            this.timeConsumed = timeConsumed;
            this.totalSecond = totalSecond;
            this.hourlyrate = hourlyrate;
            this.totalfees = totalfees;
            this.TableTitle = title; 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void CustomMesssageBoxForm_Load(object sender, EventArgs e)
        {
            lblHourlyRate.Text = hourlyrate.ToString();
            lblTimeConsumed.Text = timeConsumed.ToString();
            lblTotalFees.Text = totalfees.ToString();
            lblTotalSeconds.Text = totalSecond.ToString();
            lblTableTitle.Text = TableTitle; 
        }
    }
}
