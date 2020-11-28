using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.Shared;
namespace WindowsFormsApp2
{
    public partial class Report3 : Form
    {
        User_Formula_CR cR;
        public Report3()
        {
            InitializeComponent();
        }

        private void Report3_Load(object sender, EventArgs e)
        {
            cR = new User_Formula_CR();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cR;
        }
    }
}
