using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1_Jhon_Zuñiga
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string NombreMascota { get; set; }
        public int Estrato { get; set; }

        public Cliente(string nombre, string identificacion, string nombreMascota, int estrato)
        {
            this.Nombre = nombre;
            this.Identificacion = identificacion;
            this.NombreMascota = nombreMascota;
            this.Estrato = estrato;
        }
    }
}
