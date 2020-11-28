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
    public partial class report2 : Form
    {
        Song_playlist_CR CR;
        public report2()
        {
            InitializeComponent();
        }

        private void report2_Load(object sender, EventArgs e)
        {
            CR = new Song_playlist_CR();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
