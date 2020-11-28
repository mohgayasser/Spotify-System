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
    public partial class albumsOfAdmin : Form
    {
        OracleCommandBuilder builder;
        OracleDataAdapter select;
        DataSet selectdataSet;
        OracleDataAdapter adapter;
        DataSet dataSet;
        public albumsOfAdmin()
        {
            InitializeComponent();
        }

        private void trackssearch_Click(object sender, EventArgs e)
        {
            string constr = "User Id=hr;Password=hr;Data Source=orcl";
            string cmdstr = " select * from album  where album_name=:name";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("name ", search.Text);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        

        private void albumsOfAdmin_Load(object sender, EventArgs e)
        {
            string constr = "User Id=hr;Password=hr;Data Source=orcl";
            string cmdstr = " select *  from  album ";
            select = new OracleDataAdapter(cmdstr, constr);
            selectdataSet = new DataSet();
            select.Fill(selectdataSet);
            dataGridView1.DataSource = selectdataSet.Tables[0];
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(select);
            select.Update(selectdataSet.Tables[0]);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        
    }
}
