using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    internal class Categoria
    {
        private int IDCategoria;
        private string descripcion;

        public int IdCategoria 
        { 
            get { return IDCategoria; } 
            set { IDCategoria = value; }
        }

        public string Descripcion 
        { 
            get { return descripcion; } 
            set { descripcion = value; }
        }
    }
}
