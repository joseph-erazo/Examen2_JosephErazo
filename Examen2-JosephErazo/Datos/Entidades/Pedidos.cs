using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Pedidos
    {
        public string IDcliente { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int Cantidad { get; set; }
        public string NombreProducto { get; set; }
        public DateTime Fecha { get; set; }

        public Pedidos()
        {
        }

        public Pedidos(string iDcliente, string nombre, string codigo, int cantidad, string nombreProducto, DateTime fecha)
        {
            IDcliente = iDcliente;
            Nombre = nombre;
            Codigo = codigo;
            Cantidad = cantidad;
            NombreProducto = nombreProducto;
            Fecha = fecha;
        }
    }
}

