using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_FORM_PRESENTATION
{
    public partial class LandingPageofVoter : Form
    {
        public Point mouseLoc;
        public LandingPageofVoter()
        {
            InitializeComponent();
        }

        private void createAccLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //RENZ PAGKA CLICK MARERECORD SIYA SA DATABASE YUNG USERNAME OR EMAIL THEN NEXT PAGE
            string conn = " datasource=localhost;database=login;port=3307;username=root;password =; ";
            string query = "select * from login where (username) = '" + Username.Text + "' ";
            MySqlConnection connection = new MySqlConnection(conn);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            try
                {
                connection.Open();
                reader = command.ExecuteReader();
                connection.Close();
                Login_Form login = new Login_Form();
                login.Show();
                CustomMessageBox customMessage = new CustomMessageBox("Vote Created");
                customMessage.ShowDialog();

                this.Hide();

                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }


            }

        private void MouseMoveEvent(object sender, MouseEventArgs e)
            {
            mouseLoc = new Point(-e.X, -e.Y);
            }

        private void MouseDownEvent(object sender, MouseEventArgs e)
            {
            if (e.Button == MouseButtons.Left)
                {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLoc.X, mouseLoc.Y);
                Location = mousePose;

                }
            }
        }
}
