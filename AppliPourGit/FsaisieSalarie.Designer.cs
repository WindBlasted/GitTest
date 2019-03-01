namespace AppliPourGit
{
    partial class FsaisieSalarie
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
            this.lbl_default = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.grp_saisie_info = new System.Windows.Forms.GroupBox();
            this.tbx_nom_salarie = new System.Windows.Forms.TextBox();
            this.tbx_prenom_salarié = new System.Windows.Forms.TextBox();
            this.lbl_nom_salarie = new System.Windows.Forms.Label();
            this.lbl_prenom_salarie = new System.Windows.Forms.Label();
            this.grp_saisie_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_default
            // 
            this.lbl_default.AutoSize = true;
            this.lbl_default.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_default.Location = new System.Drawing.Point(270, 53);
            this.lbl_default.Name = "lbl_default";
            this.lbl_default.Size = new System.Drawing.Size(226, 25);
            this.lbl_default.TabIndex = 0;
            this.lbl_default.Text = "Création d\'un employé";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_submit.Location = new System.Drawing.Point(226, 337);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Valider";
            this.btn_submit.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancel.Location = new System.Drawing.Point(480, 337);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // grp_saisie_info
            // 
            this.grp_saisie_info.Controls.Add(this.lbl_prenom_salarie);
            this.grp_saisie_info.Controls.Add(this.lbl_nom_salarie);
            this.grp_saisie_info.Controls.Add(this.tbx_prenom_salarié);
            this.grp_saisie_info.Controls.Add(this.tbx_nom_salarie);
            this.grp_saisie_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_saisie_info.Location = new System.Drawing.Point(226, 123);
            this.grp_saisie_info.Name = "grp_saisie_info";
            this.grp_saisie_info.Size = new System.Drawing.Size(329, 208);
            this.grp_saisie_info.TabIndex = 3;
            this.grp_saisie_info.TabStop = false;
            this.grp_saisie_info.Text = "Saisie des information";
            // 
            // tbx_nom_salarie
            // 
            this.tbx_nom_salarie.Location = new System.Drawing.Point(116, 61);
            this.tbx_nom_salarie.Name = "tbx_nom_salarie";
            this.tbx_nom_salarie.Size = new System.Drawing.Size(120, 22);
            this.tbx_nom_salarie.TabIndex = 0;
            // 
            // tbx_prenom_salarié
            // 
            this.tbx_prenom_salarié.Location = new System.Drawing.Point(116, 148);
            this.tbx_prenom_salarié.Name = "tbx_prenom_salarié";
            this.tbx_prenom_salarié.Size = new System.Drawing.Size(120, 22);
            this.tbx_prenom_salarié.TabIndex = 1;
            // 
            // lbl_nom_salarie
            // 
            this.lbl_nom_salarie.AutoSize = true;
            this.lbl_nom_salarie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_salarie.Location = new System.Drawing.Point(113, 42);
            this.lbl_nom_salarie.Name = "lbl_nom_salarie";
            this.lbl_nom_salarie.Size = new System.Drawing.Size(105, 16);
            this.lbl_nom_salarie.TabIndex = 2;
            this.lbl_nom_salarie.Text = "Nom du salarié :";
            // 
            // lbl_prenom_salarie
            // 
            this.lbl_prenom_salarie.AutoSize = true;
            this.lbl_prenom_salarie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prenom_salarie.Location = new System.Drawing.Point(113, 129);
            this.lbl_prenom_salarie.Name = "lbl_prenom_salarie";
            this.lbl_prenom_salarie.Size = new System.Drawing.Size(123, 16);
            this.lbl_prenom_salarie.TabIndex = 3;
            this.lbl_prenom_salarie.Text = "Prenom du salarié :";
            // 
            // FsaisieSalarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.grp_saisie_info);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_default);
            this.Name = "FsaisieSalarie";
            this.Text = "FsaisieSalarie";
            this.grp_saisie_info.ResumeLayout(false);
            this.grp_saisie_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_default;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox grp_saisie_info;
        private System.Windows.Forms.Label lbl_prenom_salarie;
        private System.Windows.Forms.Label lbl_nom_salarie;
        private System.Windows.Forms.TextBox tbx_prenom_salarié;
        private System.Windows.Forms.TextBox tbx_nom_salarie;
    }
}