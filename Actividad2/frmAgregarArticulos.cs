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
        private Articulo articulo = null;
        public frmAgregarArticulos()
        {
            InitializeComponent();
        }

        public frmAgregarArticulos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

        }

        private void frmAgregarArticulos_Load(object sender, EventArgs e)
        {
            try
            {

                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                List<Categoria> categorias = categoriaNegocio.listar();
                cboCategoria.DataSource = categorias;
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.ValueMember = "IdCategoria";
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                List<Marca> marcas = marcaNegocio.listar();
                cboMarca.DataSource = marcas;
                cboMarca.DisplayMember = "Descripcion";
                cboMarca.ValueMember = "IdMarca";

                if (articulo != null)
                {
                    Text = "Modificar Articulo";
                    txbCodigo.Text = articulo.CodigoArticulo;
                    txbNombre.Text = articulo.Nombre;
                    txbDescripcion.Text = articulo.Descripcion;
                    cboMarca.SelectedValue = articulo.Marca.IdMarca;
                    cboCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                    txbImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txbPrecio.Text = articulo.Precio.ToString();
                    btnAgregar.Text = "Modificar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodigoArticulo = txbCodigo.Text;
                articulo.Nombre = txbNombre.Text;
                articulo.Descripcion = txbDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.ImagenUrl = txbImagen.Text;
                articulo.Precio = decimal.Parse(txbPrecio.Text);

                if (articulo.IdArticulo == 0)
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado exitosamente.");
                }
                else
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado exitosamente.");
                }
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

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
