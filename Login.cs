namespace GeoGame // Define el espacio de nombres para el proyecto.
{
    public partial class Login : Form // Define una clase parcial `Login` que hereda de `Form`, representando una ventana o formulario.
    {
        static readonly Guid IdUser = Guid.NewGuid(); // Declara un identificador único de tipo `Guid` para el usuario, generado de forma aleatoria.

        public Login() // Constructor de la clase `Login`.
        {
            InitializeComponent(); // Llama al método que inicializa los componentes del formulario.
        }

        private void TxtLogin_MouseMove(object sender, MouseEventArgs e) // Controlador del evento `MouseMove` para el campo `TxtLogin`.
        {
            if (!VerificarFormulario()) // Si el formulario no es válido (método `VerificarFormulario` retorna `false`),
                TPTxtLogin.SetToolTip(TxtLogin, "Ingresa un nombre de jugador, por favor."); // Muestra un mensaje en un `ToolTip` para `TxtLogin`.
        }

        private void TxtLogin_TextChanged(object sender, EventArgs e) // Controlador del evento `TextChanged` para el campo `TxtLogin`.
        {
            VerificarFormulario(); // Llama al método `VerificarFormulario` cada vez que el texto cambia para validar el formulario.
        }

        bool VerificarFormulario() // Método privado que verifica si el formulario es válido.
        {
            if (TxtLogin.Text.Trim() != string.Empty) // Comprueba si `TxtLogin` no está vacío.
            {
                TPTxtLogin.Active = false; // Desactiva el `ToolTip`.
                btnLogin.Enabled = true; // Habilita el botón `btnLogin`.
                return true; // Indica que el formulario es válido.
            }
            TPTxtLogin.Active = true; // Activa el `ToolTip`.
            btnLogin.Enabled = false; // Deshabilita el botón `btnLogin`.
            return false; // Indica que el formulario no es válido.
        }

        private void TxtLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) // Controlador del evento `PreviewKeyDown` para `TxtLogin`.
        {
            if (e.KeyCode == Keys.Enter) // Si se presiona la tecla `Enter`,
            {
                CerrarYMostrar(TxtLogin.Text); // Llama al método `CerrarYMostrar` con el texto ingresado en `TxtLogin`.
            }
        }

        void CerrarYMostrar(string username) // Método privado que cierra la ventana actual y muestra la ventana de preguntas.
        {
            Preguntas ventanaNueva = new(IdUser, username); // Crea una nueva ventana `Preguntas`, pasando el `IdUser` y el nombre de usuario.
            this.Hide(); // Oculta la ventana actual.
            ventanaNueva.ShowDialog(); // Muestra la nueva ventana y espera a que se cierre.
            this.Close(); // Cierra la ventana original definitivamente.
        }

        private void btnLogin_MouseClick(object sender, MouseEventArgs e) // Controlador del evento `MouseClick` para `btnLogin`.
        {
            CerrarYMostrar(TxtLogin.Text); // Llama al método `CerrarYMostrar` con el texto ingresado en `TxtLogin`.
        }
    }
}
