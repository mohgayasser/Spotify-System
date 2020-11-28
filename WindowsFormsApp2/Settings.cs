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
    public partial class Settings : Form
    {
        string ordb = "Data Source = orcl; User Id = hr; Password = hr;";
        OracleConnection conn;
        private string userName;
        public Settings( string uname)
        {
            userName = uname;
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select  birth_day, birth_month, birth_year, gender," +
                                 " pass, e_mail from listener where user_name = :name ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", userName);

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Firstname.Text = userName;
           //     Firstname.ReadOnly = true;
                Birthday.Value.AddDays(Convert.ToInt32(dr[0].ToString()));
                Birthday.Value.AddMonths(Convert.ToInt32(dr[1].ToString()));
                Birthday.Value.AddYears(Convert.ToInt32(dr[2].ToString()));
                Password.Text = dr[4].ToString();
                Email.Text = dr[5].ToString();
                if (dr[3].ToString() == "M" || dr[3].ToString() == "m")
                {
                    male.Checked = true;
                    female.Checked = false;
                }
                else
                {
                    female.Checked = true;
                    male.Checked = false;
                }
            }
            dr.Close();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"update listener set user_name=:name, birth_day = :day, 
                               birth_month = :month, birth_year = :year, gender = :gender, 
                               pass = :pass, e_mail = :email where user_name = :name";
            cmd.Parameters.Add("name", Firstname.Text);
            cmd.Parameters.Add("day", Convert.ToInt32(Birthday.Value.Day.ToString()));
            cmd.Parameters.Add("month", Convert.ToInt32(Birthday.Value.Month.ToString()));
            cmd.Parameters.Add("year", Convert.ToInt32(Birthday.Value.Year.ToString()));

            if (male.Checked == true)
            {
                cmd.Parameters.Add("gender", "M");
            }
            else if (female.Checked == true)
            {
                cmd.Parameters.Add("gender", "F");
            }
            cmd.Parameters.Add("pass", Password.Text);
            cmd.Parameters.Add("email", Email.Text);
            cmd.Parameters.Add("name", userName);

            int n = cmd.ExecuteNonQuery();
            if (n != -1)
            {
                MessageBox.Show("Data updated");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //OracleCommand deleteaccountcomm = new OracleCommand();
            //deleteaccountcomm.Connection = conn;
            //deleteaccountcomm.CommandText = "DELETE_ACCOUNT";
            //deleteaccountcomm.CommandType = CommandType.StoredProcedure;
            //deleteaccountcomm.Parameters.Add("email",Email.Text);
            //int ret = deleteaccountcomm.ExecuteNonQuery();
            //if (ret != 0)
            //{
            //    this.Hide();
            //    var form2 = new Login();
            //    form2.Closed += (s, args) => this.Close();
            //    form2.Show();
            //}


        }
    }
}
