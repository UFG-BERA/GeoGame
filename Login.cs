namespace GeoGame
{
    public partial class Login : Form
    {
        static readonly Guid IdUser = Guid.NewGuid();
        public Login()
        {
            InitializeComponent();
        }

        private void TxtLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (!VerificarFormulario())
                TPTxtLogin.SetToolTip(TxtLogin, "Ingresa un nombre de jugador, por favor.");
        }

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {
            VerificarFormulario();
        }

        bool VerificarFormulario()
        {
            if (TxtLogin.Text.Trim() != string.Empty)
            {
                TPTxtLogin.Active = false;
                btnLogin.Enabled = true;
                return true;
            }
            TPTxtLogin.Active = true;
            btnLogin.Enabled = false;
            return false;
        }


        private void TxtLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CerrarYMostrar(TxtLogin.Text);
            }
        }


        void CerrarYMostrar(string username)
        {
            Preguntas ventanaNueva = new(IdUser, username);
            this.Hide(); // Oculta la ventana actual
            ventanaNueva.ShowDialog(); // Muestra la nueva ventana y espera a que se cierre
            this.Close(); // Cierra definitivamente la ventana original

        }

        private void btnLogin_MouseClick(object sender, MouseEventArgs e)
        {
            CerrarYMostrar(TxtLogin.Text);
        }
    }
}
