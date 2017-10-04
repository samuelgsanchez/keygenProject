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
using System.IO;

namespace KeyGen
{
    public partial class Main : Form
    {
        private Thread th;
        private DBConnect db;
        private int LoginValue;
        private string LoginUser;

        public Main()
        {
            InitializeComponent();

        }

        public Main(int LoginValue, string LoginUser)
        {
            InitializeComponent();

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
                db = new DBConnect();
                ActiveControls();
                int idAccount = db.ObtainIdAccount(LoginUser);
                List<Categories> listCategories = db.ObtainCategories(idAccount);
                LoadCategories(listCategories);

            }
        }

        private void ActiveControls()
        {
            treeView1.Enabled = true;
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

        private void LoadCategories(List<Categories> listCategories)
        {

            LoadImageList(listCategories);

            for(int i=0; i<listCategories.Count; i++)
            {

                if (listCategories[i].Tree_level.Equals("raiz"))
                {
                    treeView1.Nodes.Add("raiz", listCategories[i].Name);
                    treeView1.Nodes["raiz"].ImageIndex = i;
                    treeView1.Nodes["raiz"].SelectedImageIndex = i;
                }
                if(listCategories[i].Tree_level.Equals("General"))
                {
                    
                    treeView1.Nodes["raiz"].Nodes.Add(listCategories[i].Name, listCategories[i].Name);
                    treeView1.Nodes["raiz"].Nodes[listCategories[i].Name].ImageIndex = i;
                    treeView1.Nodes["raiz"].Nodes[listCategories[i].Name].SelectedImageIndex = i;
                }
            }

            treeView1.ExpandAll();
        }

        private void LoadImageList(List<Categories> listCategories)
        {
            
            for (int i = 0; i < listCategories.Count; i++)
            {
                Image img = BytesToIcon(listCategories[i].Icon);

                treeImageList.Images.Add(""+i,img);
            }
        }

        private Image BytesToIcon(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
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

        private void añadirGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormAddGroup();
        }

        private void cmAddGroup_Click(object sender, EventArgs e)
        {
            openFormAddGroup();
        }

        private void openFormAddGroup()
        {
            addGroup addg = new addGroup();
            addg.ShowDialog();
        }
    }
}
