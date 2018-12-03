namespace Iset_2018_Systemes_experts
{
    partial class Ecran_Principal
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
            this.Lbl_Regle = new System.Windows.Forms.Label();
            this.Tb_Regle = new System.Windows.Forms.TextBox();
            this.Btn_Charger = new System.Windows.Forms.Button();
            this.Btn_Resoudre = new System.Windows.Forms.Button();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.Tb_Fait = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Regle
            // 
            this.Lbl_Regle.AutoSize = true;
            this.Lbl_Regle.Location = new System.Drawing.Point(17, 11);
            this.Lbl_Regle.Name = "Lbl_Regle";
            this.Lbl_Regle.Size = new System.Drawing.Size(46, 17);
            this.Lbl_Regle.TabIndex = 0;
            this.Lbl_Regle.Text = "label1";
            // 
            // Tb_Regle
            // 
            this.Tb_Regle.Location = new System.Drawing.Point(20, 31);
            this.Tb_Regle.Multiline = true;
            this.Tb_Regle.Name = "Tb_Regle";
            this.Tb_Regle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Tb_Regle.Size = new System.Drawing.Size(848, 370);
            this.Tb_Regle.TabIndex = 1;
            // 
            // Btn_Charger
            // 
            this.Btn_Charger.Location = new System.Drawing.Point(20, 407);
            this.Btn_Charger.Name = "Btn_Charger";
            this.Btn_Charger.Size = new System.Drawing.Size(92, 37);
            this.Btn_Charger.TabIndex = 2;
            this.Btn_Charger.Text = "Charger";
            this.Btn_Charger.UseVisualStyleBackColor = true;
            this.Btn_Charger.Click += new System.EventHandler(this.Btn_Charger_Click);
            // 
            // Btn_Resoudre
            // 
            this.Btn_Resoudre.Location = new System.Drawing.Point(118, 407);
            this.Btn_Resoudre.Name = "Btn_Resoudre";
            this.Btn_Resoudre.Size = new System.Drawing.Size(92, 37);
            this.Btn_Resoudre.TabIndex = 3;
            this.Btn_Resoudre.Text = "Résoudre";
            this.Btn_Resoudre.UseVisualStyleBackColor = true;
            this.Btn_Resoudre.Click += new System.EventHandler(this.Btn_Resoudre_Click);
            // 
            // Btn_Quitter
            // 
            this.Btn_Quitter.Location = new System.Drawing.Point(776, 407);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(92, 37);
            this.Btn_Quitter.TabIndex = 4;
            this.Btn_Quitter.Text = "Quitter";
            this.Btn_Quitter.UseVisualStyleBackColor = true;
            this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // Tb_Fait
            // 
            this.Tb_Fait.Location = new System.Drawing.Point(20, 450);
            this.Tb_Fait.Multiline = true;
            this.Tb_Fait.Name = "Tb_Fait";
            this.Tb_Fait.ReadOnly = true;
            this.Tb_Fait.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_Fait.Size = new System.Drawing.Size(848, 83);
            this.Tb_Fait.TabIndex = 5;
            // 
            // Ecran_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 595);
            this.ControlBox = false;
            this.Controls.Add(this.Tb_Fait);
            this.Controls.Add(this.Btn_Quitter);
            this.Controls.Add(this.Btn_Resoudre);
            this.Controls.Add(this.Btn_Charger);
            this.Controls.Add(this.Tb_Regle);
            this.Controls.Add(this.Lbl_Regle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ecran_Principal";
            this.Text = "Systèmes experts";
            this.Load += new System.EventHandler(this.Ecran_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Regle;
        private System.Windows.Forms.TextBox Tb_Regle;
        private System.Windows.Forms.Button Btn_Charger;
        private System.Windows.Forms.Button Btn_Resoudre;
        private System.Windows.Forms.Button Btn_Quitter;
        private System.Windows.Forms.TextBox Tb_Fait;
    }
}

