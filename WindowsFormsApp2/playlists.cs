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
    public partial class playlists : Form
    {

        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        string user_name;
        public playlists(  string username)
        {
            user_name = username;
            InitializeComponent();
        }
        int count = 0;
        private void playlists_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand songs_namecomm = new OracleCommand();
            songs_namecomm.Connection = conn;
            songs_namecomm.CommandText = "GET_LIKED_PLAYLISTS";
            songs_namecomm.CommandType = CommandType.StoredProcedure;
            songs_namecomm.Parameters.Add("user_name", user_name);
            songs_namecomm.Parameters.Add("playlist_id", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = songs_namecomm.ExecuteReader();
            while (dr.Read())
            {
                addsonginlist(count++, dr[0].ToString());
            }
            dr.Dispose();
            }

        Button[] b = new Button[100];
        IconButton[] likeddynamicbtn = new IconButton[100];
        Panel[] dynamicPanel = new Panel[100];

        private void addsonginlist(int i, string button_name)
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
            b[i].Text = "playlist Number: "+button_name;

            b[i].Name = Convert.ToString(i);

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
                ForeColor = System.Drawing.Color.Black,
                Rotation = 0D,
                UseVisualStyleBackColor = true,
                Dock = DockStyle.Fill,
                IconSize = 40,
                IconColor = Color.Black,
                Name = Convert.ToString(i),
                Text = button_name


            };
            likeddynamicbtn[i].FlatAppearance.BorderSize = 0;
            likeddynamicbtn[i].IconChar = IconChar.Heart;


            // Add a Button Click Event handler

            likeddynamicbtn[i].Click += iconbtn_cliked;

            Controls.Add(dynamicPanel[i]);

            dynamicPanel[i].Controls.Add(likeddynamicbtn[i]);
            dynamicPanel[i].Controls.Add(b[i]);
            panel3.Controls.Add(dynamicPanel[i]);


        }
        private void btn_Click(Object sender, EventArgs e)
        {
            
        }
        private void iconbtn_cliked(Object sender, EventArgs e)
        {
            Button btn = sender as Button;

            //MessageBox.Show(btn.Text.ToString());
           changelike(likeddynamicbtn[Convert.ToInt16(btn.Name)],btn.Text);
        }
        private void changelike(IconButton currentbtn, string playlist_id)
        {
        

            if (currentbtn.IconChar == IconChar.Heart)
            {
               
             
                OracleCommand unlikeplaylist = new OracleCommand();
                unlikeplaylist.Connection = conn;
                unlikeplaylist.CommandText = "DELETE FROM MANAGE_ WHERE PLAYLIST_ID=:playlist_id and L_USERNAME=:user_name";
                unlikeplaylist.CommandType = CommandType.Text;
                unlikeplaylist.Parameters.Add("playlist_id", Convert.ToInt32(playlist_id));
                unlikeplaylist.Parameters.Add("user_name", user_name);
                int result = unlikeplaylist.ExecuteNonQuery();
                if (result != -1)
                {
                    MessageBox.Show("PlayLIst Unliked ");
                }
                currentbtn.IconChar = IconChar.HeartBroken;
            }
            else
            {
                currentbtn.IconChar = IconChar.Heart;

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
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
