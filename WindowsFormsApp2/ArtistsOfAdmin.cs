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
    public partial class ArtistsOfAdmin : Form
    {
        OracleCommandBuilder builder;
        OracleDataAdapter select;
        DataSet selectdataSet;
        OracleDataAdapter adapter;
        DataSet dataSet;
        public ArtistsOfAdmin()
        {
            InitializeComponent();
        }

        private void trackssearch_Click(object sender, EventArgs e)
        {
            string constr = "User Id=hr;Password=hr;Data Source=orcl";
            string cmdstr = " select * from artist  where artist_name=:name";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("name ", search.Text);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dgv_Users.DataSource = dataSet.Tables[0];
        }

        private void ArtistsOfAdmin_Load(object sender, EventArgs e)
        {
            string constr = "User Id=hr;Password=hr;Data Source=orcl";
            string cmdstr = " select *  from artist ";
            select = new OracleDataAdapter(cmdstr, constr);
            selectdataSet = new DataSet();
            select.Fill(selectdataSet);
            dgv_Users.DataSource = selectdataSet.Tables[0];
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(select);
            select.Update(selectdataSet.Tables[0]);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
    }
}
