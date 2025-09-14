using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio; 

namespace Actividad2P3
{
    public partial class frmAgregarArticulos : Form
    {
        public frmAgregarArticulos()
        {
            InitializeComponent();
        }

        private void frmAgregarArticulos_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cboCategoria.DataSource = categoriaNegocio.listar();
            cboCategoria.DisplayMember = "Descripcion";
            cboMarca.DataSource = marcaNegocio.listar();
            cboMarca.DisplayMember = "Descripcion";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                nuevo.CodigoArticulo = txbCodigo.Text;
                nuevo.Nombre = txbNombre.Text;
                nuevo.Descripcion = txbDescripcion.Text;
                nuevo.Marca = (Marca)cboMarca.SelectedItem;
                nuevo.Categoria = (Categoria)cboCategoria.SelectedItem;
                nuevo.ImagenUrl = txbImagen.Text;
                nuevo.Precio = decimal.Parse(txbPrecio.Text);

                negocio.agregar(nuevo);
                MessageBox.Show("Articulo agregado exitosamente.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txbImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txbImagen.Text);
        }
            private void cargarImagen(string imagen)
        {
            try
            {
                pbxNuevoArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxNuevoArticulo.Load("https://scontent.fepa5-1.fna.fbcdn.net/v/t1.6435-9/118319079_3384586298294379_8674936737719053103_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=833d8c&_nc_ohc=KWD4rmHRd9QQ7kNvwEmDoRF&_nc_oc=AdnQhaQNcWZ-j8HvlmjMUyJvmAXq6k3pL2Qw56EQTIbhhi7LVb4PIJaSwBcwanFcyUsQwZ3IIZb7ORFnOGNLiaV6&_nc_zt=23&_nc_ht=scontent.fepa5-1.fna&_nc_gid=tqWm5R2zPUiYdyqF0vnrkg&oh=00_AfavmsPRFlEM0imFpTAoelDz0usIe-K8KupUcwtHjDditA&oe=68ED6E10");


            }
        }
    }
}
