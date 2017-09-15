using PasswordStrengthControlLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyGen
{
    public partial class Login : Form
    {
        private bool btViewPasswdClicked = false;
        private DBConnect db;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            db = new DBConnect();

            label1.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btViewPasswd_Click(object sender, EventArgs e)
        {
            btViewPasswdClicked = !btViewPasswdClicked;

            if (btViewPasswdClicked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(IsValidEmail(textBox1.Text))
            {
                if(db.AuthenticateLogin(textBox1.Text, textBox2.Text) == 1)
                {
                    MessageBox.Show("El inicio de sesión es correcto");
                }
                else
                {
                    MessageBox.Show("El usuario o contraseña no son correctos", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("La dirección de correo electrónico no es válida", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register rg = new Register();
            rg.ShowDialog();
            this.Close();
            
        }
    }
}
