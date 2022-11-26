namespace Fase1_Jhon_Zuñiga
{
    public partial class SpaMascotas : Form
    {
        private Spa spa = new();
        private float valorTotal = 0;

        bool errorNombrePropietario = false;
        bool errorNombreMascota = false;
        bool errorIdentificacionPropietario = false;
        public SpaMascotas()
        {
            InitializeComponent();
        }

        // Eventos click de los botones
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarFormulario())
            {
                if (!errorNombrePropietario && !errorNombreMascota && !errorIdentificacionPropietario)
                {
                    Cliente cliente = new(txtPropietario.Text, txtIdentificacion.Text, txtMascota.Text, cbxEstrato.SelectedIndex + 1);
                    Servicio servicio = new(DefinirServicio(), DateTime.Now);

                    spa.cliente = cliente;
                    spa.servicio = servicio;

                    valorTotal = spa.CalcularValorServicio();
                    MessageBox.Show("Datos Guardados Correctamente");
                    btnMostrar.Enabled = true;
                    btnMostrar.Focus();
                }
                else
                {
                    MessageBox.Show("Tiene errores en los campos ingresados");
                }
            }
            else
            {
                MessageBox.Show("Todos los datos son obligatorios");
            }

        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Reporte reporte = new(this, Limpiar);

            reporte.lbDate.Text = spa.servicio.Date.ToString();
            reporte.lbIdentificacion.Text = spa.cliente.Identificacion;
            reporte.lbPropietario.Text = spa.cliente.Nombre;
            reporte.lbMascota.Text = spa.cliente.NombreMascota;
            reporte.lbValorServicio.Text = "$" + spa.servicio.ValorServicio.ToString();
            reporte.lbDescuento.Text = "$ " + spa.servicio.descuento.ValorDescuento.ToString();
            reporte.lbValorTotal.Text = "$ " + valorTotal.ToString();
            if (spa.cliente.Estrato < 4)
            {
                reporte.lbEstrato.Text = spa.cliente.Estrato.ToString();
            }
            else
            {
                reporte.lbEstrato.Text = "Mayor a 4";
            }

            if (spa.servicio.Tipo == "servicio1")
            {
                reporte.lbServicio.Text = "Baño y Corte";
            }
            else if (spa.servicio.Tipo == "servicio2")
            {
                reporte.lbServicio.Text = "Baño, Corte y Vacuna antigarrapatas";
            }
            else
            {
                reporte.lbServicio.Text = "Baño, Corte, Vacuna antigarrapatas y Antiparácitos";
            }

            this.Enabled = false;
            reporte.Show();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Inicio frmInicio = new();
                frmInicio.Show();
                frmInicio.txtContraseña.Focus();
            }
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // Eventos Combobox
        private void CbxEstrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtServicio1.Checked)
            {
                CalcularValorTotal(45000);
            }
            if (rbtServicio2.Checked)
            {
                CalcularValorTotal(80000);
            }
            if (rbtServicio3.Checked)
            {
                CalcularValorTotal(100000);
            }
        }

        // Eventos Radio button
        private void RbtServicio1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtServicio1.Checked && cbxEstrato.SelectedIndex != -1)
            {
                CalcularValorTotal(45000);
            }
        }

        private void RbtServicio2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtServicio2.Checked && cbxEstrato.SelectedIndex != -1)
            {
                CalcularValorTotal(80000);
            }
        }

        private void RbtServicio3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtServicio3.Checked && cbxEstrato.SelectedIndex != -1)
            {
                CalcularValorTotal(100000);
            }
        }

        // Eventos formulario
        private void SpaMascotas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        // Eventos de cambio de texto
        private void txtPropietario_TextChanged(object sender, EventArgs e)
        {
            if (txtPropietario.Text.Length > 0)
            {
                if (VerificarErrorLetras(txtPropietario.Text))
                {
                    errorPropietario.SetError(txtPropietario, "Solo se admites caracteres tipo letra a - z");
                    errorNombrePropietario = true;
                }
                else
                {
                    errorPropietario.Clear();
                    errorNombrePropietario = false;
                }
            }
            else
            {
                errorPropietario.Clear();
                errorNombrePropietario=false;
            }
        }
        private void txtMascota_TextChanged(object sender, EventArgs e)
        {
            if (txtMascota.Text.Length > 0)
            {
                if (VerificarErrorLetras(txtMascota.Text))
                {
                    errorMascota.SetError(txtMascota, "Solo se admites caracteres tipo letra a - z");
                    errorNombreMascota = true;
                }
                else
                {
                    errorMascota.Clear();
                    errorNombreMascota = false;
                }
            }
            else
            {
                errorMascota.Clear();
                errorNombreMascota = false;
            }
        }
        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text.Length > 0)
            {
                if (VerificarErrorNumeros(txtIdentificacion.Text))
                {
                    errorIdentificacion.SetError(txtIdentificacion, "Solo se aceptan datos numericos");
                    errorIdentificacionPropietario = true;
                }
                else
                {
                    errorIdentificacion.Clear();
                    errorIdentificacionPropietario = false;
                }
            }
            else
            {
                errorIdentificacion.Clear();
                errorIdentificacionPropietario = false;
            }
        }

        //Eventos Enter
        private void txtPropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                txtIdentificacion.Focus();
            }
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                txtMascota.Focus();
            }
        }

        private void cbxEstrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                rbtServicio1.Focus();
            }
        }

        private void txtMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                cbxEstrato.Focus();
                cbxEstrato.DroppedDown = true;
            }
        }

        private void rbtServicio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnGuardar.Focus();
                btnGuardar.PerformClick();
            }
        }

        private void rbtServicio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnGuardar.Focus();
                btnGuardar.PerformClick();
            }
        }

        private void rbtServicio3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnGuardar.Focus();
                btnGuardar.PerformClick();
            }
        }

        private void btnGuardar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnMostrar.Focus();
                btnMostrar.PerformClick();
            }
        }

        // Funciones
        private bool VerificarErrorLetras(string entrada)
        {
            bool error = false;
            foreach (char caracter in entrada)
            {
                if (!char.IsLetter(caracter))
                {
                   if (caracter != ' ')
                    {
                        error = true;
                        break;
                    }
                }
            }
            return error;
        }

        private bool VerificarErrorNumeros(string entrada)
        {
            bool error = false;
            foreach (char caracter in entrada)
            {
                if (!char.IsNumber(caracter))
                {
                    error = true;
                    break;
                }
            }
            return error;
        }

        private bool VerificarFormulario()
        {
            if (txtIdentificacion.Text == "" ||
                txtMascota.Text == "" ||
                txtPropietario.Text == "" ||
                cbxEstrato.SelectedIndex == -1 ||
                DefinirServicio() == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private string DefinirServicio()
        {
            if (rbtServicio1.Checked)
            {
                return "servicio1";
            }
            else if (rbtServicio2.Checked)
            {
                return "servicio2";
            }
            else if (rbtServicio3.Checked)
            {
                return "servicio3";
            }
            else
            {
                return null;
            }
        }

        private void CalcularValorTotal(float valor)
        {
            float descuento;
            if (cbxEstrato.SelectedIndex + 1 == 1 || cbxEstrato.SelectedIndex + 1 == 2)
            {
                descuento = valor * 0.15f;
            }
            else if (cbxEstrato.SelectedIndex + 1 == 3 || cbxEstrato.SelectedIndex + 1 == 4)
            {
                descuento = valor * 0.10f;
            }
            else
            {
                descuento = valor * 0.05f;
            }

            float valorTotal = valor - descuento;

            txtDescuento.Text = "$ " + descuento.ToString();
            txtCostoServicio.Text = "$ " + valorTotal.ToString();
        }

        public void Limpiar()
        {
            txtIdentificacion.Text = "";
            txtPropietario.Text = "";
            txtMascota.Text = "";
            cbxEstrato.SelectedIndex = -1;
            rbtServicio1.Checked = false;
            rbtServicio2.Checked = false;
            rbtServicio3.Checked = false;
            txtDescuento.Text = "";
            txtCostoServicio.Text = "";

            btnMostrar.Enabled = false;
            txtPropietario.Focus();
        }

        private void SpaMascotas_Load(object sender, EventArgs e)
        {

        }
    }
}
