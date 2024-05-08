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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ranking));
            lstResultados = new ListView();
            SuspendLayout();
            // 
            // lstResultados
            // 
            resources.ApplyResources(lstResultados, "lstResultados");
            lstResultados.GridLines = true;
            lstResultados.MultiSelect = false;
            lstResultados.Name = "lstResultados";
            lstResultados.UseCompatibleStateImageBehavior = false;
            lstResultados.View = View.Details;
            lstResultados.SelectedIndexChanged += lstResultados_SelectedIndexChanged;
            // 
            // Ranking
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lstResultados);
            IsMdiContainer = true;
            KeyPreview = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Ranking";
            ShowIcon = false;
            Load += Ranking_Load;
            KeyDown += Ranking_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private ListView lstResultados;
    }
}