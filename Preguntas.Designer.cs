namespace GeoGame
{
    partial class Preguntas
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
            picPregunta = new PictureBox();
            lblScoreTitulo = new Label();
            lblScore = new Label();
            lblTemporizador = new Label();
            label2 = new Label();
            lblPregunta = new Label();
            btnRespuestaA = new Button();
            btnRespuestaB = new Button();
            btnRespuestaC = new Button();
            btnRespuestaD = new Button();
            lblUserName = new Label();
            TmrTemporizador = new System.Windows.Forms.Timer(components);
            lblCorrecto = new Label();
            lblIncorrecto = new Label();
            ((System.ComponentModel.ISupportInitialize)picPregunta).BeginInit();
            SuspendLayout();
            // 
            // picPregunta
            // 
            picPregunta.Location = new Point(228, 12);
            picPregunta.Name = "picPregunta";
            picPregunta.Size = new Size(359, 221);
            picPregunta.TabIndex = 0;
            picPregunta.TabStop = false;
            // 
            // lblScoreTitulo
            // 
            lblScoreTitulo.AutoSize = true;
            lblScoreTitulo.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreTitulo.Location = new Point(22, 46);
            lblScoreTitulo.Name = "lblScoreTitulo";
            lblScoreTitulo.Size = new Size(200, 38);
            lblScoreTitulo.TabIndex = 1;
            lblScoreTitulo.Text = "Puntuación:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(97, 84);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(32, 33);
            lblScore.TabIndex = 2;
            lblScore.Text = "0";
            // 
            // lblTemporizador
            // 
            lblTemporizador.AutoSize = true;
            lblTemporizador.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTemporizador.Location = new Point(602, 67);
            lblTemporizador.Name = "lblTemporizador";
            lblTemporizador.Size = new Size(152, 33);
            lblTemporizador.TabIndex = 4;
            lblTemporizador.Text = "01:00:000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(611, 29);
            label2.Name = "label2";
            label2.Size = new Size(141, 38);
            label2.TabIndex = 3;
            label2.Text = "Tiempo:";
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.Location = new Point(352, 236);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(94, 24);
            lblPregunta.TabIndex = 6;
            lblPregunta.Text = "Pregunta";
            lblPregunta.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRespuestaA
            // 
            btnRespuestaA.Location = new Point(123, 275);
            btnRespuestaA.Name = "btnRespuestaA";
            btnRespuestaA.Size = new Size(184, 57);
            btnRespuestaA.TabIndex = 7;
            btnRespuestaA.Text = "Respuesta A";
            btnRespuestaA.UseVisualStyleBackColor = true;
            // 
            // btnRespuestaB
            // 
            btnRespuestaB.Location = new Point(123, 348);
            btnRespuestaB.Name = "btnRespuestaB";
            btnRespuestaB.Size = new Size(184, 57);
            btnRespuestaB.TabIndex = 8;
            btnRespuestaB.Text = "Respuesta B";
            btnRespuestaB.UseVisualStyleBackColor = true;
            // 
            // btnRespuestaC
            // 
            btnRespuestaC.Location = new Point(498, 275);
            btnRespuestaC.Name = "btnRespuestaC";
            btnRespuestaC.Size = new Size(184, 57);
            btnRespuestaC.TabIndex = 9;
            btnRespuestaC.Text = "Respuesta C";
            btnRespuestaC.UseVisualStyleBackColor = true;
            // 
            // btnRespuestaD
            // 
            btnRespuestaD.Location = new Point(498, 348);
            btnRespuestaD.Name = "btnRespuestaD";
            btnRespuestaD.Size = new Size(184, 57);
            btnRespuestaD.TabIndex = 10;
            btnRespuestaD.Text = "Respuesta D";
            btnRespuestaD.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(91, 29);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(62, 15);
            lblUserName.TabIndex = 11;
            lblUserName.Text = "UserName";
            // 
            // TmrTemporizador
            // 
            TmrTemporizador.Tick += TmrTemporizador_Tick;
            // 
            // lblCorrecto
            // 
            lblCorrecto.AutoSize = true;
            lblCorrecto.BackColor = Color.Transparent;
            lblCorrecto.Enabled = false;
            lblCorrecto.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCorrecto.ForeColor = Color.Lime;
            lblCorrecto.Location = new Point(97, 159);
            lblCorrecto.Name = "lblCorrecto";
            lblCorrecto.Size = new Size(55, 37);
            lblCorrecto.TabIndex = 12;
            lblCorrecto.Text = "✔";
            // 
            // lblIncorrecto
            // 
            lblIncorrecto.AutoSize = true;
            lblIncorrecto.BackColor = Color.Transparent;
            lblIncorrecto.Enabled = false;
            lblIncorrecto.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIncorrecto.ForeColor = Color.Red;
            lblIncorrecto.Location = new Point(665, 150);
            lblIncorrecto.Name = "lblIncorrecto";
            lblIncorrecto.Size = new Size(55, 37);
            lblIncorrecto.TabIndex = 13;
            lblIncorrecto.Text = "❌";
            // 
            // Preguntas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 450);
            Controls.Add(lblIncorrecto);
            Controls.Add(lblCorrecto);
            Controls.Add(lblUserName);
            Controls.Add(btnRespuestaD);
            Controls.Add(btnRespuestaC);
            Controls.Add(btnRespuestaB);
            Controls.Add(btnRespuestaA);
            Controls.Add(lblPregunta);
            Controls.Add(lblTemporizador);
            Controls.Add(label2);
            Controls.Add(lblScore);
            Controls.Add(lblScoreTitulo);
            Controls.Add(picPregunta);
            Name = "Preguntas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preguntas";
            ((System.ComponentModel.ISupportInitialize)picPregunta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picPregunta;
        private Label lblScoreTitulo;
        private Label lblScore;
        private Label lblTemporizador;
        private Label label2;
        private Label lblPregunta;
        private Button btnRespuestaA;
        private Button btnRespuestaB;
        private Button btnRespuestaC;
        private Button btnRespuestaD;
        private Label lblUserName;
        private System.Windows.Forms.Timer TmrTemporizador;
        private Label lblCorrecto;
        private Label lblIncorrecto;
    }
}