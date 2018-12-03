namespace Iset_2018_Systemes_experts
{
    partial class FicPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ecran_Principal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ecran_Principal
            // 
            this.Ecran_Principal.AutoSize = true;
            this.Ecran_Principal.Location = new System.Drawing.Point(24, 22);
            this.Ecran_Principal.Name = "Ecran_Principal";
            this.Ecran_Principal.Size = new System.Drawing.Size(46, 17);
            this.Ecran_Principal.TabIndex = 0;
            this.Ecran_Principal.Text = "label1";
            // 
            // FicPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 565);
            this.Controls.Add(this.Ecran_Principal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FicPrincipal";
            this.Text = "Systèmes experts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ecran_Principal;
    }
}

