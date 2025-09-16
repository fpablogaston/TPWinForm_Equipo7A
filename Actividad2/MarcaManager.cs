using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace Actividad2P3
{
    public partial class MarcaManager : Form
    {
        private Marca marca = null;

        public MarcaManager(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }
        public MarcaManager()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (marca == null)
                    marca = new Marca();

                marca.Descripcion = txtNombre.Text;

                if (marca.IdMarca == 0)
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Marca agregada exitosamente");
                }

                else
                {
                    negocio.modificar(marca);
                    MessageBox.Show("Marca modificada exitosamente");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MarcaManager_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            List<Marca> marcas = negocio.listar();
            try
            {

                if (marca != null && marca.IdMarca != 0)
                {
                    Text = "Modificar Marca";
                    txtNombre.Text = marca.Descripcion;
                    btnAceptar.Text = "Modificar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
