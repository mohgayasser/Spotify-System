using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {

        }
        private Form activeform = null;

        private void openchildForm(Form childForm)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            openchildForm(new Rrp1());
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            openchildForm(new report2());
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            openchildForm(new Report3());
        }
    }
}
