namespace Exámen_de_geografía
{
    partial class username
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
            this.components = new System.ComponentModel.Container();
            this.nombre = new System.Windows.Forms.Label();
            this.NIngresado = new System.Windows.Forms.TextBox();
            this.Iboton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(172, 201);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(129, 27);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "username:";
            // 
            // NIngresado
            // 
            this.NIngresado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIngresado.Location = new System.Drawing.Point(307, 200);
            this.NIngresado.Name = "NIngresado";
            this.NIngresado.Size = new System.Drawing.Size(323, 32);
            this.NIngresado.TabIndex = 1;
            this.NIngresado.TextChanged += new System.EventHandler(this.NIngresado_TextChanged);
            // 
            // Iboton
            // 
            this.Iboton.BackColor = System.Drawing.Color.Firebrick;
            this.Iboton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iboton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Iboton.Location = new System.Drawing.Point(641, 381);
            this.Iboton.Name = "Iboton";
            this.Iboton.Size = new System.Drawing.Size(111, 38);
            this.Iboton.TabIndex = 2;
            this.Iboton.Text = "Ingresar.";
            this.Iboton.UseVisualStyleBackColor = false;
            this.Iboton.Click += new System.EventHandler(this.Iboton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // username
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.Iboton);
            this.Controls.Add(this.NIngresado);
            this.Controls.Add(this.nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "username";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "username";
            this.Load += new System.EventHandler(this.username_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox NIngresado;
        private System.Windows.Forms.Button Iboton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

