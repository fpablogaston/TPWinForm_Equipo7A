using Actividad2P3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarArticulos ventana = new frmListarArticulos();
            ventana.Show();
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
    }
}
