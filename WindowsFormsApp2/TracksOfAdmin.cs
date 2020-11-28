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
    public partial class TracksOfAdmin : Form
    {
        OracleCommandBuilder builder;
        OracleDataAdapter select;
        DataSet selectdataSet;
        OracleDataAdapter adapter;
        DataSet dataSet;
        bool selectstatment = false;
        public TracksOfAdmin()
        {
            InitializeComponent();
        }

        private void TracksOfAdmin_Load(object sender, EventArgs e)
        {
            string constr = "User Id=hr;Password=hr;Data Source=orcl";
            string cmdstr = @" select  s.song_name, s.album_name, s.song_duration, s.songlink, p.playlist_name
                                from playlist p , song s
                            where p.playlist_id = s.playlist_id ";
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

        private void trackssearch_Click(object sender, EventArgs e)
        {
            string constr = "User Id=hr;Password=hr;Data Source=orcl";
            string cmdstr = @" select  s.song_name, s.album_name, s.song_duration, s.songlink, p.playlist_name
                                from playlist p , song s
                            where p.playlist_id = s.playlist_id   and s.song_name =:song_name";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("song_name ", search.Text);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dgv_Users.DataSource = dataSet.Tables[0];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
