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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            treeView1.ExpandAll();

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
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void nuevaSesion_Click(object sender, EventArgs e)
        {
            OpenFormLogin();
        }
    }
}
