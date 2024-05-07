namespace GeoGame
{
    partial class Ranking
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
            lstResultados = new ListView();
            SuspendLayout();
            // 
            // lstResultados
            // 
            lstResultados.Alignment = ListViewAlignment.SnapToGrid;
            lstResultados.Dock = DockStyle.Fill;
            lstResultados.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstResultados.GridLines = true;
            lstResultados.Location = new Point(0, 0);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(800, 450);
            lstResultados.Sorting = SortOrder.Ascending;
            lstResultados.TabIndex = 0;
            lstResultados.UseCompatibleStateImageBehavior = false;
            lstResultados.View = View.List;
            // 
            // Ranking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstResultados);
            Name = "Ranking";
            Text = "Ranking";
            Load += Ranking_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lstResultados;
    }
}