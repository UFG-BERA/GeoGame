namespace GeoGame
{
    partial class Score
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
            llbScore = new LinkLabel();
            lblUsername = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblAciertos = new Label();
            lblFallos = new Label();
            btnReinentar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // llbScore
            // 
            llbScore.AutoSize = true;
            llbScore.Cursor = Cursors.Hand;
            llbScore.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            llbScore.Location = new Point(307, 200);
            llbScore.Name = "llbScore";
            llbScore.Size = new Size(42, 46);
            llbScore.TabIndex = 0;
            llbScore.TabStop = true;
            llbScore.Text = "0";
            llbScore.TextAlign = ContentAlignment.MiddleCenter;
            llbScore.LinkClicked += llbScore_LinkClicked;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(12, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(190, 40);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(221, 104);
            label2.Name = "label2";
            label2.Size = new Size(350, 33);
            label2.TabIndex = 2;
            label2.Text = "Tu puntuación fue de:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 376);
            label3.Name = "label3";
            label3.Size = new Size(180, 20);
            label3.TabIndex = 3;
            label3.Text = "Total de aciertos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 418);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 4;
            label4.Text = "Total de fallos";
            // 
            // lblAciertos
            // 
            lblAciertos.AutoSize = true;
            lblAciertos.FlatStyle = FlatStyle.Flat;
            lblAciertos.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAciertos.ForeColor = Color.Green;
            lblAciertos.Location = new Point(190, 371);
            lblAciertos.Name = "lblAciertos";
            lblAciertos.Size = new Size(25, 25);
            lblAciertos.TabIndex = 5;
            lblAciertos.Text = "0";
            // 
            // lblFallos
            // 
            lblFallos.AutoSize = true;
            lblFallos.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFallos.ForeColor = Color.Red;
            lblFallos.Location = new Point(167, 413);
            lblFallos.Name = "lblFallos";
            lblFallos.Size = new Size(25, 25);
            lblFallos.TabIndex = 6;
            lblFallos.Text = "0";
            // 
            // btnReinentar
            // 
            btnReinentar.Font = new Font("Showcard Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReinentar.ForeColor = SystemColors.ActiveCaptionText;
            btnReinentar.Location = new Point(502, 376);
            btnReinentar.Name = "btnReinentar";
            btnReinentar.Size = new Size(286, 62);
            btnReinentar.TabIndex = 7;
            btnReinentar.Tag = "Volver a jugar";
            btnReinentar.Text = "Reintentar";
            btnReinentar.UseVisualStyleBackColor = true;
            btnReinentar.Click += btnReinentar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(422, 213);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 8;
            label1.Text = "Puntos";
            // 
            // Score
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnReinentar);
            Controls.Add(lblFallos);
            Controls.Add(lblAciertos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblUsername);
            Controls.Add(llbScore);
            MaximizeBox = false;
            Name = "Score";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Score";
            KeyDown += Score_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llbScore;
        private Label lblUsername;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblAciertos;
        private Label lblFallos;
        private Button btnReinentar;
        private Label label1;
    }
}