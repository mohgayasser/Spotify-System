using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //462
            if (panel1.Left == 460)
            {
                panel2.Visible = true;
                panel2.Left = 460;
                panel1.Visible = false;
                panel1.Left = 38;
                panel1.Visible = true;
                bunifuSeparator1.Left = bunifuThinButton22.Left;
                bunifuSeparator1.Width = bunifuThinButton22.Width;

            }



        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

            if (panel2.Left == 460)
            {
                panel1.Visible = false;
                panel1.Left = 460;
                panel2.Visible = false;
                panel2.Left = 38;
                panel2.Visible = true;
                bunifuSeparator1.Left = bunifuThinButton21.Left;
                bunifuSeparator1.Width = bunifuThinButton21.Width;

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

      
        }

      

        private void signin_Click(object sender, EventArgs e)
        {
            invalidPass.Visible = false;
            invalidmail.Visible = false;
            OracleCommand signincheckcomm = new OracleCommand();
            signincheckcomm.Connection = conn;
            signincheckcomm.CommandText = "select  pass ,USER_NAME  from listener where e_mail = :email ";
            signincheckcomm.CommandType = CommandType.Text;
            signincheckcomm.Parameters.Add("email", signinemail.Text);
            OracleDataReader signinreader = signincheckcomm.ExecuteReader();
            if (signinreader.Read())
            {
                if (signinPass.Text == signinreader[0].ToString())
                {
                    if (signinreader[1].ToString().Contains("A"))
                    {
                        this.Hide();
                        var form2 = new Admin();
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                    else
                    {
                        this.Hide();
                        var form2 = new User(signinreader[1].ToString());
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                }
                else
                {
                    invalidPass.Visible = true;
                    signinPass.Text = "";
                }
            }
            else
            {
                invalidmail.Visible = true;
                signinemail.Text = "";
            }
        }

        private void signup_Click_2(object sender, EventArgs e)
        {
            if (Email.Text != "")
            {
                OracleCommand signupcheckcomm = new OracleCommand();
                signupcheckcomm.Connection = conn;
                signupcheckcomm.CommandText = "select e_mail from listener";

                signupcheckcomm.CommandType = CommandType.Text;
                OracleDataReader checkreader = signupcheckcomm.ExecuteReader();
                bool ret = false;
                while (checkreader.Read())
                {
                    if (checkreader[0].ToString() == Email.Text)
                    {
                        ret = true;

                    }
                }

                if (!ret)
                {
                    MessageBox.Show("correctemail ");
                    OracleCommand signupcomm = new OracleCommand();
                    signupcomm.Connection = conn;
                    signupcomm.CommandText = "insert into listener Values(:uname,:birthday,:birthmonth,:birthyear,:gender,:email,:pass)";
                    signupcomm.Parameters.Add("uname", Firstname.Text + " " + LastName.Text);
                    signupcomm.Parameters.Add("birthday", Convert.ToInt32(Birthday.Value.Day.ToString()));
                    signupcomm.Parameters.Add("birthmonth", Convert.ToInt32(Birthday.Value.Month.ToString()));
                    signupcomm.Parameters.Add("birthyear", Convert.ToInt32(Birthday.Value.Year.ToString()));
                    if (male.Checked == true)
                    {
                        signupcomm.Parameters.Add("gender", "M");
                    }
                    else if (female.Checked == true)
                    {
                        signupcomm.Parameters.Add("gender", "F");
                    }
                    signupcomm.Parameters.Add("email", Email.Text);
                    signupcomm.Parameters.Add("pass", Password.Text);
                    signupcomm.CommandType = CommandType.Text;
                    int result = signupcomm.ExecuteNonQuery();
                    if (result != -1)
                    {
                        this.Hide();
                        var form2 = new User(Firstname.Text + " " + LastName.Text);
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                }
                else
                {
                    Existemail.Visible = true;
                    Email.Text = "";

                }
            }
            else
            {
                Existemail.Visible = true;
                Email.Text = "";

            }
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

      
    }
}