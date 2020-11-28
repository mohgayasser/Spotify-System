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

    public partial class Rrp1 : Form
    {
         CrystalReport1 CR;

        public Rrp1()
        {
            InitializeComponent();
        }

        private void Rrp1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
            {
                Song_type.Items.Add(v.Value);
            }
            foreach (ParameterDiscreteValue v in CR.ParameterFields[1].DefaultValues)
            {
                songDuration.Items.Add(v.Value);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, Song_type.Text);
            CR.SetParameterValue(1, songDuration.Text);
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
