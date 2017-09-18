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
using System.Threading;

namespace KeyGen
{
    public partial class Login : Form
    {
        private bool btViewPasswdClicked = false;
        private int correctValue = 0;
        private string user;
        private DBConnect db;
        Thread th;

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

        private void btAceptar_Click(object sender, EventArgs e)
        {

            correctValue = db.AuthenticateLogin(textBox1.Text, textBox2.Text);

            if (correctValue == 1)
            {
                user = textBox1.Text;
                // Abre el formulario principal con los datos del usuario
                this.Dispose();
                th = new Thread(openMainFormUser);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                
            }
            else
            {
                MessageBox.Show("El usuario o contraseña no son correctos", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rg = new Register();
            rg.ShowDialog();
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Abre el formulario principal sin haber hecho el login
            th = new Thread(openMainForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        // Abre el formulario principal con los datos del usuario
        private void openMainFormUser()
        {
            Application.Run(new Main(correctValue, user));
        }

        // Abre el formulario principal sin haber hecho el login
        private void openMainForm()
        {
            Application.Run(new Main());
        }
    }
}
