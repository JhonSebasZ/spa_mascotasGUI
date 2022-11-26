using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1_Jhon_Zuñiga
{
    internal class Servicio
    {
        public string Tipo { get; set; }
        public float ValorServicio { get; set; }
        public Descuento descuento { get; set; }
        public DateTime Date { get; set; }

        public Servicio(string tipo, DateTime date)
        {
            this.Tipo = tipo;
            this.Date = date;

            ValorServicio = tipo switch
            {
                "servicio1" => 45000,
                "servicio2" => 80000,
                "servicio3" => 100000,
                _ => 0,
            };
        }

        public float CalcularValorTotal(int estrato)
        {
            descuento = new Descuento(estrato, ValorServicio);
            return ValorServicio - descuento.CalcularDescuento();
        }
    }
}
