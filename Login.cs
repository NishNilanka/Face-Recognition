using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MultiFaceRec
{
    public partial class Login : Form
    {
        public string myConnection = "datasource=127.0.0.1; port=3306; username=root; password=";


        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string Query = "insert into sql328888.accounts (username,password) values('" + textBox3.Text + "','" + textBox4.Text + "');";
            //MySqlConnection myConn = new MySqlConnection(myConnection);
            //MySqlCommand cmdDataBase = new MySqlCommand(Query, myConn);
            //MySqlDataReader myReader;
            //myConn.Open();
            //myReader = cmdDataBase.ExecuteReader();
            //MessageBox.Show("Saved");
            //while (myReader.Read())
            //{
            //}
            //myConn.Close();
            var MainForm = new FrmPrincipal();
            MainForm.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

        }
    }
}
