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

        public int AuthenticateLogin(string user, string password)
        {
            int res = 0;

            string query = "SELECT * FROM users WHERE user = '" + user + "' and password = AES_ENCRYPT('" + password + "','samplekey')";

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

        public int InsertRegister(string user, string password)
        {
            int res = 0;

            string query = "INSERT INTO users(user, password) VALUES('" + user + "',AES_ENCRYPT('" + password + "','samplekey'))";

            if(this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, cn);

                try
                {
                    res = cmd.ExecuteNonQuery();
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Este nombre de usuario ya existe.\n" + ex.Message, "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El usuario no se ha podido registrar. Póngase en contacto " +
                        "con el administrador del sistema si el problema persiste.\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                this.CloseConnection();
            }

            return res;

        }

        public void GenerateCategories()
        {
            string queryId = "SELECT LAST_INSERT_ID()";

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(queryId, cn);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int id_user = dr.GetInt32(0);

                    this.CloseConnection();

                    string queryProcedure = "CALL insert_categories(" + id_user + ")";

                    MySqlCommand cmd2 = new MySqlCommand(queryProcedure, cn);

                    if(this.OpenConnection())
                    {
                        cmd2.ExecuteNonQuery();
                        this.CloseConnection();
                    }
                    
                }
            }
        }

        public void ObtainCategories(int user_account)
        {
            string query = "SELECT * FROM categories WHERE user_account = " + user_account;
        }
    }
}
