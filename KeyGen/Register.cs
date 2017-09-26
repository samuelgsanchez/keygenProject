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
    public partial class Register : Form
    {

        DBConnect db;

        private bool btViewPasswdClicked = false;

        public Register()
        {
            InitializeComponent();
        }


        private void Register_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
            db = new DBConnect();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int x = PasswordStregthManager.Instance.GetPasswordScore(textBox1.Text, textBox2.Text);
            string str = PasswordStregthManager.Instance.GetPasswordStrength(textBox1.Text, textBox2.Text);
            Color col = PasswordStregthManager.Instance.GetPasswordColor(textBox1.Text, textBox2.Text);

            this.SetPasswordControls(this.passwordStrengthControl2, x, str, Color.Black, col);

        }

        private void SetPasswordControls(PasswordStrengthControl cont, int s, string text, Color f, Color b)
        {
            cont.Strength = s;
            cont.SolidColor = b;
            cont.ForeColor = f;
            cont.StrengthText = text;
        }

        private void passwordStrengthControl2_StrengthChangedEventHandler(object sender, StrengthChangedEventArgs e)
        {
            label4.Text = "Nivel de seguridad: " + e.Text;
        }

        private void btViewPasswd_Click(object sender, EventArgs e)
        {

            btViewPasswdClicked = !btViewPasswdClicked;

            if(btViewPasswdClicked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            bool user = false, passwords = false, empty = false;

            if(textBox1.TextLength < 6) { errorProvider1.SetError(textBox1, "El usuario debe tener más de 6 caracteres"); } else { errorProvider1.Clear(); user = true; }
            if (CheckPasswords(textBox2.Text, textBox3.Text)) { passwords = true;  }
            if(!(textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "")) { empty = true; }

            if(!passwords) { label6.Text = "Las contraseñas no coinciden"; } else { label6.Text = ""; }
            if(!empty) { MessageBox.Show("No puedes dejar ningún campo vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }


            if(user && passwords && empty)
            {
                int res = db.InsertRegister(textBox1.Text, textBox2.Text);
                if (res == 1)
                {
                    MessageBox.Show("Usuario registrado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.GenerateCategories();
                    this.Close();
                }
            }

            
        }

        private bool CheckPasswords(string pwd1, string pwd2)
        {
            if (pwd1.Equals(pwd2)) { return true; } else { return false; }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
