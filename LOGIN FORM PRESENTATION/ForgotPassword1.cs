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

namespace LOGIN_FORM_PRESENTATION
{
    public partial class ForgotPassword1 : Form
    {
        public ForgotPassword1()
        {
            InitializeComponent();
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButt_Click(object sender, EventArgs e)
            {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
            }

        private void escapeButt_Click(object sender, EventArgs e)
            {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
            }

        private void changepasswordButt_Click(object sender, EventArgs e)
            {
            try
                {
                string conn = " datasource=localhost;database=login;port=3306;username=root;password =; ";
                string query = "UPDATE `login` SET  `password`='"+newpasswordBox.Text+"' WHERE `email` = '"+emailBox.Text+"' ";
                MySqlConnection connection = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                    {
                    CustomMessageBox customMessage = new CustomMessageBox("Password Changed");
                    customMessage.ShowDialog();
                    }
                else if (newpasswordBox.Text != newpasswordBox.Text)
                    {
                    CustomMessageBox customMessage = new CustomMessageBox("Password Doesn't Match");
                    customMessage.ShowDialog();
                    }
                else
                    { 
                    Login_Form login = new Login_Form();
                    login.Show();
                    this.Hide();
                    }
                 
                connection.Close();
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }

            }

        private void hidePassBt_Click(object sender, EventArgs e)
            {
            if (newpasswordBox.PasswordChar == '*')
                {
                showPassBt.BringToFront();
                newpasswordBox.PasswordChar = '\0';
                }
            }

        private void showPassBt_Click(object sender, EventArgs e)
            {
            if (newpasswordBox.PasswordChar == '\0')
                {
                hidePassBt.BringToFront();
                newpasswordBox.PasswordChar = '*';
                }
            }
        }
}
