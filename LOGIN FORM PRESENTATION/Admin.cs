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
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;

namespace LOGIN_FORM_PRESENTATION
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void gridview()
            {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand("select * from login", con);
            try
                {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
        private void Admin_Load(object sender, EventArgs e)
            {
            gridview(); 
            groupBoxData.Hide();
            groupBoxDelete.Hide();
            groupBoxUpdate.Hide();
            }

        private void dataGridBT_Click(object sender, EventArgs e)
            {
            gridview(); /* THIS IS TO REFRESH THE GRID VIEW*/
            groupBoxData.Show();
            groupBoxDelete.Hide();
            groupBoxUpdate.Hide();
            }

        private void dataEditBT_Click(object sender, EventArgs e)
            {
            groupBoxData.Hide();
            groupBoxDelete.Hide();
            groupBoxUpdate.Show();
            }

        
        private void dataDeleteBT_Click(object sender, EventArgs e)
            {
            groupBoxData.Hide();
            groupBoxDelete.Show();
            groupBoxUpdate.Hide();
            }


        /*ACCOUNT EDIT GROUP BOX*/
        private void accountEditBT_Click(object sender, EventArgs e)
            {
            try
                {
                string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";

                string query = "UPDATE `login` SET `username`='"+usernameTextBox.Text+"',`email`='"+emailTextBox.Text+"',`password`='"+passwordTextBox.Text+"' WHERE `id` = '"+idTextBox.Text+"' ";
                MySqlConnection myConn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, myConn);
                MySqlDataReader reader;
                try
                    {
                    myConn.Open();
                    reader = cmd.ExecuteReader();
                    CustomMessageBox customMessage = new CustomMessageBox("Account Edited");
                    customMessage.Show();
                    myConn.Close();
                    }
                catch (Exception ex)
                    {
                    CustomMessageBox customMessage = new CustomMessageBox(ex.Message);
                    customMessage.Show();  
                    }
                }
            catch (Exception ex)
                {
                CustomMessageBox customMessage = new CustomMessageBox(ex.Message);
                customMessage.Show();
                }

            }

        private void logoutBT_Click(object sender, EventArgs e)
            {
            Login_Form backtoLogin = new Login_Form();
            backtoLogin.Show();
            this.Hide();
            }

        private void deleteUserNIdBT_Click(object sender, EventArgs e)
            {
            try
                {
                string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";

                string query = "DELETE FROM `login` WHERE `id`='"+deleteIDTextBox+"' ";
                MySqlConnection myConn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, myConn);
                MySqlDataReader reader;
                try
                    {
                    myConn.Open();
                    reader = cmd.ExecuteReader();
                    CustomMessageBox customMessage = new CustomMessageBox("Account Removed");
                    customMessage.Show();
                    myConn.Close();
                    }
                catch (Exception ex)
                    {
                    CustomMessageBox customMessage = new CustomMessageBox(ex.Message);
                    customMessage.Show();
                    }
                }
            catch (Exception ex)
                {
                CustomMessageBox customMessage = new CustomMessageBox(ex.Message);
                customMessage.Show();
                }

            }
        
        }
}
