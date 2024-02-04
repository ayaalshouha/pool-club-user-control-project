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
            PoolTable poolTable = (PoolTable)sender;
            string TableTitle = poolTable.TableTitle;
            CustomMesssageBoxForm form = new CustomMesssageBoxForm(e.TimeConsumed, e.TotalSecond, e.HourlyRate, e.TotalFees, TableTitle); 
            form.ShowDialog();
        }
    }
}
