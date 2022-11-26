using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase1_Jhon_Zuñiga
{
    public partial class Reporte : Form
    {
        Form frmSpaMascotas;
        Action limpiarFrm;

        public Reporte(Form frmSpaMascotas, Action limpiarFrm)
        {
            InitializeComponent();

            this.frmSpaMascotas = frmSpaMascotas;
            this.limpiarFrm = limpiarFrm;
        }

        // Evento Boton
        private void BtnRegresar(object sender, EventArgs e)
        {
            frmSpaMascotas.Enabled = true;
            this.Hide();
            frmSpaMascotas.Show();
            limpiarFrm();
        }

        // Evento cerrar
        private void Reporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
               e.Cancel = true;
            }
        }

        // Evento Enter
        private void BtnRegresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                frmSpaMascotas.Enabled = true;
                this.Hide();
                frmSpaMascotas.Show();
                limpiarFrm();
            }
        }
    }
}
