using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1_Jhon_Zuñiga
{
    internal class Descuento
    {
        private int estrato;
        private float valorServicio;
        public float ValorDescuento { get; set; }

        public Descuento(int estrato, float valorServicio)
        {
            this.estrato = estrato;
            this.valorServicio = valorServicio;
        }

        public float CalcularDescuento()
        {
            switch (estrato)
            {
                case 1:
                case 2:
                    ValorDescuento = valorServicio * 0.15f;
                    return ValorDescuento;
                case 3:
                case 4:
                    ValorDescuento = valorServicio * 0.10f;
                    return ValorDescuento;
                case 5:
                    ValorDescuento = valorServicio * 0.05f;
                    return ValorDescuento;
                default:
                    return 0;
            }
        }

    }
}
