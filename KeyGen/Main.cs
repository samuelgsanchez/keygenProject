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
    public partial class Main : Form
    {
        Thread th;
        private int LoginValue;
        private string LoginUser;

        public Main()
        {
            InitializeComponent();

        }

        public Main(int LoginValue, string LoginUser)
        {
            InitializeComponent();
            treeView1.ExpandAll();

            this.LoginValue = LoginValue;
            this.LoginUser = LoginUser;

            this.Text = "KeyGen - " + LoginUser;
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abrirSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormLogin();
        }

        private void OpenFormLogin()
        {
            this.Close();
            th = new Thread(openLoginForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            
        }

        private void openLoginForm()
        {
            Application.Run(new Login());
        }

        private void nuevaSesion_Click(object sender, EventArgs e)
        {
            OpenFormLogin();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if (LoginValue == 1)
            {
                treeView1.Visible = true;
                
            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void Main_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
