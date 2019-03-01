namespace AppliPourGit
{
    partial class FsaisieService
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
            this.TbId = new System.Windows.Forms.TextBox();
            this.TbLibelle = new System.Windows.Forms.TextBox();
            this.Lbld = new System.Windows.Forms.Label();
            this.LblLibelle = new System.Windows.Forms.Label();
            this.LblTitre = new System.Windows.Forms.Label();
            this.LblDesc = new System.Windows.Forms.Label();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(293, 241);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(100, 20);
            this.TbId.TabIndex = 0;
            // 
            // TbLibelle
            // 
            this.TbLibelle.Location = new System.Drawing.Point(293, 307);
            this.TbLibelle.Name = "TbLibelle";
            this.TbLibelle.Size = new System.Drawing.Size(100, 20);
            this.TbLibelle.TabIndex = 1;
            this.TbLibelle.TextChanged += new System.EventHandler(this.TbLibelle_TextChanged);
            // 
            // Lbld
            // 
            this.Lbld.AutoSize = true;
            this.Lbld.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbld.Location = new System.Drawing.Point(219, 232);
            this.Lbld.Name = "Lbld";
            this.Lbld.Size = new System.Drawing.Size(45, 29);
            this.Lbld.TabIndex = 2;
            this.Lbld.Text = "Id :";
            // 
            // LblLibelle
            // 
            this.LblLibelle.AutoSize = true;
            this.LblLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLibelle.Location = new System.Drawing.Point(166, 298);
            this.LblLibelle.Name = "LblLibelle";
            this.LblLibelle.Size = new System.Drawing.Size(98, 29);
            this.LblLibelle.TabIndex = 3;
            this.LblLibelle.Text = "Libellé :";
            // 
            // LblTitre
            // 
            this.LblTitre.AutoSize = true;
            this.LblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitre.Location = new System.Drawing.Point(198, 32);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(276, 39);
            this.LblTitre.TabIndex = 4;
            this.LblTitre.Text = "Nouveau service";
            this.LblTitre.Click += new System.EventHandler(this.LblTitre_Click);
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesc.Location = new System.Drawing.Point(124, 102);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(424, 25);
            this.LblDesc.TabIndex = 5;
            this.LblDesc.Text = "Saisir les informations du service à ajouter ";
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(171, 385);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(105, 32);
            this.BtnAnnuler.TabIndex = 6;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(348, 385);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(105, 32);
            this.BtnValider.TabIndex = 7;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            // 
            // FsaisieService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 558);
            this.Controls.Add(this.BtnValider);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.LblDesc);
            this.Controls.Add(this.LblTitre);
            this.Controls.Add(this.LblLibelle);
            this.Controls.Add(this.Lbld);
            this.Controls.Add(this.TbLibelle);
            this.Controls.Add(this.TbId);
            this.Name = "FsaisieService";
            this.Text = "FsaisieService";
            this.Load += new System.EventHandler(this.FsaisieService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.TextBox TbLibelle;
        private System.Windows.Forms.Label Lbld;
        private System.Windows.Forms.Label LblLibelle;
        private System.Windows.Forms.Label LblTitre;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnValider;
    }
}