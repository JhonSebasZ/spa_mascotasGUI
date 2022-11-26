using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1_Jhon_Zuñiga
{
    internal class Spa
    {
        public Cliente cliente;
        public Servicio servicio;

        public float CalcularValorServicio()
        {
            return servicio.CalcularValorTotal(cliente.Estrato);
        }
    }
}
