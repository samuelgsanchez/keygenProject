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
    public partial class addGroup : Form
    {
        public addGroup()
        {
            InitializeComponent();
        }

        private void addGroup_Load(object sender, EventArgs e)
        {
            change_Properties();
        }

        private void change_Properties()
        {
            label1.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            ToolTip tooltip1 = new System.Windows.Forms.ToolTip();
            tooltip1.SetToolTip(button1, "Escoja un icono");

            separator.AutoSize = false;
            separator.Height = 2;
            separator.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
