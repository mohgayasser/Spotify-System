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
    public partial class PlayListsOfAdmin : Form
    {
        OracleCommandBuilder builder;
        OracleDataAdapter select;
        DataSet selectdataSet;
        OracleDataAdapter adapter;
        DataSet dataSet;
        public PlayListsOfAdmin()
        {
            InitializeComponent();
        }

        private void trackssearch_Click(object sender, EventArgs e)
        {
            string constr = "User Id=hr;Password=hr;Data Source=orcl";
            string cmdstr = " select *  from playlist  where playlist_id=:id";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("id ", search.Text);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dgv_Users.DataSource = dataSet.Tables[0];
        }

        private void PlayListsOfAdmin_Load(object sender, EventArgs e)
        {
            string constr = "User Id=hr;Password=hr;Data Source=orcl";
            string cmdstr = " select *  from playlist ";
            select = new OracleDataAdapter(cmdstr, constr);
            selectdataSet = new DataSet();
            select.Fill(selectdataSet);
            dgv_Users.DataSource = selectdataSet.Tables[0];
        }

        private void dgv_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(select);
            select.Update(selectdataSet.Tables[0]);
        }
    }
}
