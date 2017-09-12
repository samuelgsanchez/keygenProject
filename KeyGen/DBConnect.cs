using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace KeyGen
{
    class DBConnect
    {
        private MySqlConnection cn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnect()
        {
            Connection();
        }

        private void Connection()
        {
            server = "localhost";
            database = "keygen";
            uid = "root";
            password = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" +
                                        "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            cn = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                cn.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                switch(ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Please, contact administrator", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                cn.Close();
                return true;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public int AuthenticateLogin(string email, string password)
        {
            int res = 0;

            string query = "SELECT * FROM users WHERE email = '" + email + "' and password = '" + password + "'";

            if(this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    res = 1;
                    this.CloseConnection();
                }
                else
                {
                    res = -1;
                    this.CloseConnection();
                }
            }

            return res;
        }
    }
}
