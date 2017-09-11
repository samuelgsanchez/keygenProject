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

        private bool btViewPasswdClicked = false;

        public Register()
        {
            InitializeComponent();
        }


        private void Register_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
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
    }
}
