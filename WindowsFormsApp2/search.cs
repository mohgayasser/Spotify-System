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
    public partial class search : Form
    {
        int count = 0;
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        private IconButton currentsong;
        string username;
        public System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public search( string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            count = 0;
            OracleCommand ALLSONGS = new OracleCommand();
            ALLSONGS.Connection = conn;
            ALLSONGS.CommandText = "select SONG_NAME,SONGLINK  from SONG ";
            ALLSONGS.CommandType = CommandType.Text;
            OracleDataReader ALLSONGSREADER = ALLSONGS.ExecuteReader();
            while (ALLSONGSREADER.Read())
            {
                addsonginlist(count++, ALLSONGSREADER[0].ToString(), ALLSONGSREADER[1].ToString());

            }
            ALLSONGSREADER.Close();
            conn.Dispose();
        }
        Button[] b = new Button[100];
        IconButton[] likeddynamicbtn = new IconButton[100];
        Panel[] dynamicPanel = new Panel[100];

        private void addsonginlist(int i ,string button_name ,string button_link)
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

            ///Album name 
            b[i].Text = Convert.ToString(i)+"-"+ button_name;

            b[i].Name = button_link;

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
            panel3.Controls.Add(dynamicPanel[i]);


        }
        private void btn_Click(Object sender, EventArgs e)
        {
                Button btns = sender as Button;
                playsong(btns.Name);
            
        }
        public void pusedbutton()
        {
            player.Stop();

        }
        public void playsong(string songlink)
        {

            player.SoundLocation = songlink;
            player.Play();
        }

        private void iconbtn_cliked(Object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            try {
                //{
                int index = Convert.ToInt16(Convert.ToString(Convert.ToString(btn.Name[0]) + Convert.ToString(btn.Name[1])));
             
             changelike(likeddynamicbtn[index], index,1);
            }
            catch
            {
                int index = Convert.ToInt16((Convert.ToString(btn.Name[0])));
               changelike(likeddynamicbtn[Convert.ToInt16(Convert.ToString(btn.Name[0]))],index,0);

            }



        }
        private void changelike(IconButton currentbtn, int index,int know)
        {
        


            if (currentbtn.IconChar == IconChar.Heart)
            {

                currentbtn.IconChar = IconChar.Gratipay;

            }
            else
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                currentbtn.IconChar = IconChar.Heart;

                OracleCommand likedsongComm = new OracleCommand();
                likedsongComm.Connection = conn;
                likedsongComm.CommandText = "insertlikedsonge ";
                likedsongComm.CommandType = CommandType.StoredProcedure;
                likedsongComm.Parameters.Add("USerName", username);
            if(know==0)
                likedsongComm.Parameters.Add("SONG_name", b[index].Text.Substring(2));
            else
              likedsongComm.Parameters.Add("SONG_name", b[index].Text.Substring(3));

                int result = likedsongComm.ExecuteNonQuery();
                if (result!=-1)
                {
                    MessageBox.Show("Done");

                }
                conn.Dispose();
            }
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
            panel3.Visible = false;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void trackssearch_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            panel3.Controls.Clear();
            OracleCommand SearchSongConn = new OracleCommand();
            SearchSongConn.Connection = conn;
            SearchSongConn.CommandText = "GET_ALL_Songs ";
            SearchSongConn.CommandType = CommandType.StoredProcedure;
            SearchSongConn.Parameters.Add("SONG_name", bunifuMaterialTextbox1.Text);
            SearchSongConn.Parameters.Add("SONG_Link", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            int search = SearchSongConn.ExecuteNonQuery();
          
                addsonginlist(count, bunifuMaterialTextbox1.Text, SearchSongConn.Parameters["SONG_Link"].Value.ToString());
                count++;
            conn.Dispose();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            openchildForm(new playlistsongs(bunifuMaterialTextbox1.Text));
      
        }
    }
}
