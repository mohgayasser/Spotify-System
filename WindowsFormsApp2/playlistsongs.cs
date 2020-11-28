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
using FontAwesome.Sharp;
namespace WindowsFormsApp2
{
    public partial class playlistsongs : Form
    {
        int count = 0;
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        string playlist_ID;
        public playlistsongs( string playlist_ID)
        {
            InitializeComponent();
            this.playlist_ID = playlist_ID;
        }

        private void playlistsongs_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand playlistsongscomm = new OracleCommand();
            playlistsongscomm.Connection = conn;
            playlistsongscomm.CommandText = "getplaylistsongs";
            playlistsongscomm.CommandType = CommandType.StoredProcedure;

            playlistsongscomm.Parameters.Add("playlist_id", playlist_ID);
            playlistsongscomm.Parameters.Add("songsname", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = playlistsongscomm.ExecuteReader();
            while (dr.Read())
            {

                OracleCommand songscomm = new OracleCommand();
                songscomm.Connection = conn;
                songscomm.CommandText = "getsongsofplaylist";
                songscomm.CommandType = CommandType.StoredProcedure;
                songscomm.Parameters.Add("songname", dr[0].ToString());
               // MessageBox.Show(dr[0].ToString());
                songscomm.Parameters.Add("SONG_Link", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader drsonglink = songscomm.ExecuteReader();
                while (drsonglink.Read())
                {
                    addsonginlist(count++, dr[0].ToString(), drsonglink[0].ToString());
                }
                drsonglink.Close();


            }
            dr.Close();
            conn.Dispose();
           
        }

        /// /////////////////////////////////////////////////////////////

        private IconButton currentsong;
        public System.Media.SoundPlayer player = new System.Media.SoundPlayer();
   

        Button[] b = new Button[100];
        IconButton[] likeddynamicbtn = new IconButton[100];
        Panel[] dynamicPanel = new Panel[100];

        private void addsonginlist(int i,string playlistsongs,string songs_link)
        {


            // Set Button properties

            dynamicPanel[i] = new Panel();
            dynamicPanel[i].Dock = DockStyle.Top;
            dynamicPanel[i].Location = new System.Drawing.Point(0, 45);
            dynamicPanel[i].Name = "Panel" + i;
            dynamicPanel[i].Size = new System.Drawing.Size(619, 52);
            dynamicPanel[i].TabIndex = 0;

            dynamicPanel[i].BackColor = Color.LavenderBlush;




            b[i] = new Button();
            b[i].Height = 52;

            b[i].Width = 554;
            b[i].FlatStyle = FlatStyle.Flat;

            b[i].FlatAppearance.BorderSize = 0;
            b[i].Location = new Point(0, 0);
            b[i].Dock = DockStyle.Left;
            ////////////////////////////////////////////////////////////////////
            ///song name    album Name
            b[i].Text = Convert.ToString(i) + "-" + playlistsongs;
            /////////////////////////////////////////////////////////////////////
            b[i].Name = songs_link;

            b[i].Font = new Font("Century Gothic", 11);



            // Add a Button Click Event handler

            b[i].Click += btn_Click;

            ////////Icon Button
            likeddynamicbtn[i] = new IconButton
            {
                Height = 52,
                Width = 58,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Flip = FontAwesome.Sharp.FlipOrientation.Normal,
                ForeColor = System.Drawing.Color.Cornsilk,
                Rotation = 0D,
                UseVisualStyleBackColor = true,
                Dock = DockStyle.Fill,
                IconSize = 40,
                IconColor = Color.Black,
                Name = Convert.ToString(i),


            };
            likeddynamicbtn[i].FlatAppearance.BorderSize = 0;
            likeddynamicbtn[i].IconChar = IconChar.Gratipay;


            // Add a Button Click Event handler

            likeddynamicbtn[i].Click += iconbtn_cliked;

            Controls.Add(dynamicPanel[i]);

            dynamicPanel[i].Controls.Add(likeddynamicbtn[i]);
            dynamicPanel[i].Controls.Add(b[i]);
            panel2.Controls.Add(dynamicPanel[i]);


        }
        private void btn_Click(Object sender, EventArgs e)
        {
            Button btns = sender as Button;
            playsong(btns.Name);
        }
        private void iconbtn_cliked(Object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            try
            {
                //{
                int index = Convert.ToInt16(Convert.ToString(Convert.ToString(btn.Name[0]) + Convert.ToString(btn.Name[1])));
                MessageBox.Show(Convert.ToString(index));
                changelike(likeddynamicbtn[index], index, 1);
            }
            catch
            {
                int index = Convert.ToInt16((Convert.ToString(btn.Name[0])));
                MessageBox.Show(Convert.ToString(index));
                changelike(likeddynamicbtn[Convert.ToInt16(Convert.ToString(btn.Name[0]))], index, 0);

            }
        }
        private void changelike(IconButton currentbtn, int index, int know)
        {


            if (currentbtn.IconChar == IconChar.Heart)
            {

                currentbtn.IconChar = IconChar.Gratipay;

            }
            else
            {
                currentbtn.IconChar = IconChar.Heart;

            }
        }
        public void playsong(string songlink)
        {

            player.SoundLocation = songlink;
            player.Play();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
