using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class Clientes
    {
        public String idCliente { get; set; }
        public String NombreCompañia { get; set; }
        public String NombreContacto { get; set; }
        public String CargoContacto { get; set; }
        public String Direccion { get; set; }
        public String Ciudad { get; set; }
        public String Pais { get; set; }
        public String Telefono { get; set; }

        public Clientes(string idCliente, string nombreCompañia, string nombreContacto, string cargoContacto, string direccion, string ciudad, string pais, string telefono)
        {
            this.idCliente = idCliente;
            NombreCompañia = nombreCompañia;
            NombreContacto = nombreContacto;
            CargoContacto = cargoContacto;
            Direccion = direccion;
            Ciudad = ciudad;
            Pais = pais;
            Telefono = telefono;
        }

    }
}
