using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library
{
    public class CrearOfertas
    {
        public CrearOfertas(listaCategoria categoria, string descripcion, int precio)
        {
            this.Categoria = categoria;
            this.Descripcion = descripcion;
            this.Precio = precio;
        }

        public string Descripcion { get; set; }
        public listaCategoria Categoria { get; set; }
        public int Precio { get; set; }
        
}
}