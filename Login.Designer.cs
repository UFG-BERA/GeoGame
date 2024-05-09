namespace GeoGame
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            username = new Label();
            TxtLogin = new TextBox();
            btnLogin = new Button();
            TPTxtLogin = new ToolTip(components);
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.BorderStyle = BorderStyle.FixedSingle;
            username.FlatStyle = FlatStyle.Popup;
            username.Font = new Font("Romantic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 2);
            username.Location = new Point(153, 141);
            username.Name = "username";
            username.Size = new Size(339, 47);
            username.TabIndex = 0;
            username.Text = "Nombre de usuario:";
            // 
            // TxtLogin
            // 
            TxtLogin.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtLogin.Location = new Point(153, 191);
            TxtLogin.Multiline = true;
            TxtLogin.Name = "TxtLogin";
            TxtLogin.PlaceholderText = "Username123";
            TxtLogin.Size = new Size(545, 45);
            TxtLogin.TabIndex = 1;
            TxtLogin.TextChanged += TxtLogin_TextChanged;
            TxtLogin.MouseMove += TxtLogin_MouseMove;
            TxtLogin.PreviewKeyDown += TxtLogin_PreviewKeyDown;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Enabled = false;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Romantic", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnLogin.Location = new Point(523, 362);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(265, 76);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "INICIAR JUEGO";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.MouseClick += btnLogin_MouseClick;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(TxtLogin);
            Controls.Add(username);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private TextBox TxtLogin;
        private Button btnLogin;
        private ToolTip TPTxtLogin;
    }
}