namespace Iset_2018_Systemes_experts
{
    partial class FicQuestion
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
            this.LblQuestion = new System.Windows.Forms.Label();
            this.Tb_Reponse = new System.Windows.Forms.TextBox();
            this.Btn_Conf = new System.Windows.Forms.Button();
            this.Btn_Ann = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblQuestion
            // 
            this.LblQuestion.AutoSize = true;
            this.LblQuestion.Location = new System.Drawing.Point(20, 19);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(65, 17);
            this.LblQuestion.TabIndex = 0;
            this.LblQuestion.Text = "Question";
            // 
            // Tb_Reponse
            // 
            this.Tb_Reponse.Location = new System.Drawing.Point(23, 39);
            this.Tb_Reponse.Name = "Tb_Reponse";
            this.Tb_Reponse.Size = new System.Drawing.Size(100, 22);
            this.Tb_Reponse.TabIndex = 1;
            // 
            // Btn_Conf
            // 
            this.Btn_Conf.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Conf.Location = new System.Drawing.Point(129, 38);
            this.Btn_Conf.Name = "Btn_Conf";
            this.Btn_Conf.Size = new System.Drawing.Size(84, 23);
            this.Btn_Conf.TabIndex = 2;
            this.Btn_Conf.Text = "Confirmer";
            this.Btn_Conf.UseVisualStyleBackColor = true;
            // 
            // Btn_Ann
            // 
            this.Btn_Ann.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Ann.Location = new System.Drawing.Point(219, 38);
            this.Btn_Ann.Name = "Btn_Ann";
            this.Btn_Ann.Size = new System.Drawing.Size(80, 23);
            this.Btn_Ann.TabIndex = 3;
            this.Btn_Ann.Text = "Annuler";
            this.Btn_Ann.UseVisualStyleBackColor = true;
            // 
            // FicQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 88);
            this.Controls.Add(this.Btn_Ann);
            this.Controls.Add(this.Btn_Conf);
            this.Controls.Add(this.Tb_Reponse);
            this.Controls.Add(this.LblQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FicQuestion";
            this.Text = "FicQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.TextBox Tb_Reponse;
        private System.Windows.Forms.Button Btn_Conf;
        private System.Windows.Forms.Button Btn_Ann;
    }
}