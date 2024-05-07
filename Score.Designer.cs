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
            SuspendLayout();
            // 
            // llbScore
            // 
            llbScore.AutoSize = true;
            llbScore.Location = new Point(279, 130);
            llbScore.Name = "llbScore";
            llbScore.Size = new Size(13, 15);
            llbScore.TabIndex = 0;
            llbScore.TabStop = true;
            llbScore.Text = "0";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(252, 40);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(59, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 76);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Puntuación";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 222);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 3;
            label3.Text = "Total de aciertos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 253);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 4;
            label4.Text = "Total de fallos";
            // 
            // lblAciertos
            // 
            lblAciertos.AutoSize = true;
            lblAciertos.Location = new Point(294, 220);
            lblAciertos.Name = "lblAciertos";
            lblAciertos.Size = new Size(13, 15);
            lblAciertos.TabIndex = 5;
            lblAciertos.Text = "0";
            // 
            // lblFallos
            // 
            lblFallos.AutoSize = true;
            lblFallos.Location = new Point(294, 253);
            lblFallos.Name = "lblFallos";
            lblFallos.Size = new Size(13, 15);
            lblFallos.TabIndex = 6;
            lblFallos.Text = "0";
            // 
            // Score
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFallos);
            Controls.Add(lblAciertos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblUsername);
            Controls.Add(llbScore);
            Name = "Score";
            Text = "Score";
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
    }
}