namespace Fase1_Jhon_Zuñiga
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        // Evento Boton
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        // Evento Enter
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true; //elimina el sonido
                Ingresar();
            }
        }

        // Funciones
        private void Ingresar()
        {
            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Ingrese su contraseña");
                txtContraseña.Focus();
            }
            else
            {
                if (txtContraseña.Text == "123")
                {
                    SpaMascotas frmSpa = new();
                    txtContraseña.Text = "";
                    frmSpa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    txtContraseña.Clear();
                    txtContraseña.Focus();
                }
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}