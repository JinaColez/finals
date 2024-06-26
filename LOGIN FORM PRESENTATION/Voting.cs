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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LOGIN_FORM_PRESENTATION
{
    public partial class Voting : Form
    {
        public Voting()
            {
            InitializeComponent();

            voteBox.Items.Add("VOTE");
            voteBox.Items.Add("RENZ");
            voteBox.Items.Add("BARDS");
            voteBox.Items.Add("MARK");
            voteBox.Items.Add("IMOT");
            voteBox.Items.Add("VINCE");
            voteBox.Items.Add("CHARLIE");
            voteBox.Items.Add("MJ");
            voteBox.Items.Add("IAN");
            voteBox.Items.Add("JAKE");
            voteBox.Items.Add("CARLO");

            voteBox.SelectedIndex = 0;

            voteBox.SelectedIndexChanged += voteBox_SelectedIndexChanged; 
            }

        private void VINCE_Click(object sender, EventArgs e)
        {

        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            LandingPageofVoter LPV = new LandingPageofVoter();
            LPV.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void voteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedindex  = voteBox.SelectedIndex;
            switch ( selectedindex )
                {
                case 0:
                    pictureBox2.BringToFront();
                    break;
                case 1:
                    RENZ.BringToFront();
                    break;
                case 2:
                    BARDS.BringToFront();
                    break;
                case 3:
                    MARK.BringToFront();
                    break;
                case 4:
                    IMOT.BringToFront();
                    break;
                case 5:
                    VINCE.BringToFront();
                    break;
                case 6:
                    CHARLIE.BringToFront();
                    break;
                case 7:
                    MJ.BringToFront();
                    break;
                case 8:
                    IAN.BringToFront();
                    break;
                case 9:
                    JAKE.BringToFront();
                    break;
                case 10:
                    CARLO.BringToFront();
                    break;





                }
                
            }

      

        private void VOTEBTN_Click(object sender, EventArgs e)
        {
            try
                {
                string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";
                string query = "insert into votersdata (username, candidate ,votecount) values( '"+Username.Text+"','"+voteBox.SelectedIndex+"','"+"1"+"')";
                MySqlConnection connection = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                try
                    {
                    connection.Open();
                    reader = command.ExecuteReader();
                    connection.Close();
                    CustomMessageBox customMessage = new CustomMessageBox("Voted");
                    customMessage.ShowDialog();

                    this.Hide();

                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }

            //RENZ PAGKA CLICK NG VOTE MAPUPUNTA SA NEXT PAGE
           
        }

        private void Voting_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void IAN_Click(object sender, EventArgs e)
        {

        }

        private void MARK_Click(object sender, EventArgs e)
        {

        }

        private void JAKE_Click(object sender, EventArgs e)
        {

        }

        private void IMOT_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            
        }
    }
}
