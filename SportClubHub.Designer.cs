
namespace TPDataBase
{
    partial class SportClubHub
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
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblBienveni3 = new System.Windows.Forms.Label();
            this.lblDeporteFavorito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(13, 412);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(118, 26);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblBienveni3
            // 
            this.lblBienveni3.AutoSize = true;
            this.lblBienveni3.Location = new System.Drawing.Point(310, 25);
            this.lblBienveni3.Name = "lblBienveni3";
            this.lblBienveni3.Size = new System.Drawing.Size(120, 17);
            this.lblBienveni3.TabIndex = 1;
            this.lblBienveni3.Text = "Hola! Bienvenid@";
            // 
            // lblDeporteFavorito
            // 
            this.lblDeporteFavorito.AutoSize = true;
            this.lblDeporteFavorito.Location = new System.Drawing.Point(310, 58);
            this.lblDeporteFavorito.Name = "lblDeporteFavorito";
            this.lblDeporteFavorito.Size = new System.Drawing.Size(114, 17);
            this.lblDeporteFavorito.TabIndex = 2;
            this.lblDeporteFavorito.Text = "Deporte Favorito";
            // 
            // SportClubHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDeporteFavorito);
            this.Controls.Add(this.lblBienveni3);
            this.Controls.Add(this.btnCerrarSesion);
            this.Name = "SportClubHub";
            this.Text = "SportClubHub";
            this.Load += new System.EventHandler(this.SportClubHub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblBienveni3;
        private System.Windows.Forms.Label lblDeporteFavorito;
    }
}