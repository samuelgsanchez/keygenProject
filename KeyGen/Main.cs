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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (LoginValue == 1)
            {
                ActiveControls();
            }
        }

        private void ActiveControls()
        {
            treeView1.Visible = true;
            dataGridView1.Visible = true;

            // Controles del toolStrip
            nuevaSesion.Enabled = false;
            cerrarSesion.Enabled = true;
            insertarEntrada.Enabled = true;
            buscar.Enabled = true;
            bloquearVentana.Enabled = true;
            txBuscar.Enabled = true;

            // Controles del menuStrip
            abrirSesiónToolStripMenuItem.Enabled = false;
            cerrarSesiónToolStripMenuItem.Enabled = true;
            guardarToolStripMenuItem.Enabled = true;
            guardarComoToolStripMenuItem.Enabled = true;
            cambiarContraseñaToolStripMenuItem.Enabled = true;
            imprimirToolStripMenuItem.Enabled = true;
            imprimirToolStripMenuItem1.Enabled = true;
            bloquearEspacioDeTrabajoToolStripMenuItem.Enabled = true;
            añadirGrupoToolStripMenuItem.Enabled = true;
            añadirSubgrupoToolStripMenuItem.Enabled = true;
            editarGrupoToolStripMenuItem.Enabled = true;
            eliminarGrupoToolStripMenuItem.Enabled = true;
            añadirEntradaToolStripMenuItem.Enabled = true;
            buscarEnLaBaseDeDatosToolStripMenuItem.Enabled = true;
            buscarEnEsteGrupoToolStripMenuItem.Enabled = true;

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            cerrarSesionForm();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarSesionForm();
        }

        private void cerrarSesionForm()
        {

            DialogResult dialogResult = MessageBox.Show("¿Estás seguro que quieres cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                LoginValue = 0;
                LoginUser = "";
                Application.Restart();
            }
        }
    }
}
