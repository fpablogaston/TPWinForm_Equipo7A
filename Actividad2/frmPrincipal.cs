using Actividad2P3;
using negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace Actividad2
{
    public partial class frmPrincipal : Form
    {

        private List<Articulo> listaArticulos;
        public frmPrincipal()
        {
            InitializeComponent();
        }








        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {

                listaArticulos = negocio.listar();

                dgvMain.DataSource = listaArticulos;
                dgvMain.Columns["IdArticulo"].Visible = false;
                dgvMain.Columns["ImagenUrl"].Visible = false;


                pbxMain.Load(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarArticulos ventana = new frmBuscarArticulos();
            ventana.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarArticulos ventana = new frmAgregarArticulos();
            ventana.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarArticulos ventana = new frmModificarArticulos();
            ventana.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarArticulos ventana = new frmEliminarArticulos();
            ventana.Show();
        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerDetalle ventana = new frmVerDetalle();
            ventana.Show();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarca ventana = new frmMarca();
            ventana.Show();
        }

        private void administrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategoria ventana = new frmCategoria();
            ventana.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvMain.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxMain.Load(imagen);
            }
            catch (Exception)
            {
                pbxMain.Load("https://scontent.fepa5-1.fna.fbcdn.net/v/t1.6435-9/118319079_3384586298294379_8674936737719053103_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=833d8c&_nc_ohc=KWD4rmHRd9QQ7kNvwEmDoRF&_nc_oc=AdnQhaQNcWZ-j8HvlmjMUyJvmAXq6k3pL2Qw56EQTIbhhi7LVb4PIJaSwBcwanFcyUsQwZ3IIZb7ORFnOGNLiaV6&_nc_zt=23&_nc_ht=scontent.fepa5-1.fna&_nc_gid=tqWm5R2zPUiYdyqF0vnrkg&oh=00_AfavmsPRFlEM0imFpTAoelDz0usIe-K8KupUcwtHjDditA&oe=68ED6E10");


            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarArticulos alta = new frmAgregarArticulos();
            alta.ShowDialog();
            cargar();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvMain.CurrentRow.DataBoundItem;
            frmAgregarArticulos modificar = new frmAgregarArticulos(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
    }
}

