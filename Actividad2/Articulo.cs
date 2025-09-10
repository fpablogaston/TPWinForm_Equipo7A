using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    internal class Articulo
    {
        private int codigoArticulo;
        private string nombre;
        private string descripcion;
        private Marca marca;
        private Categoria categoria;
        private string imagenUrl;
        private float precio;

        public int CodigoArticulo
        {
            get { return CodigoArticulo; }
            set { CodigoArticulo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Marca Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public string ImagenUrl
        {
            get { return imagenUrl; }
            set { imagenUrl = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
