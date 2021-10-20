
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportClubHub));
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblBienveni3 = new System.Windows.Forms.Label();
            this.lblDeporteFavorito = new System.Windows.Forms.Label();
            this.btnCambiarDeporteFavorito = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Orange;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(13, 399);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(137, 39);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblBienveni3
            // 
            this.lblBienveni3.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienveni3.Location = new System.Drawing.Point(-2, 75);
            this.lblBienveni3.Name = "lblBienveni3";
            this.lblBienveni3.Size = new System.Drawing.Size(802, 81);
            this.lblBienveni3.TabIndex = 1;
            this.lblBienveni3.Text = "Hola! Bienvenid@";
            this.lblBienveni3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeporteFavorito
            // 
            this.lblDeporteFavorito.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F);
            this.lblDeporteFavorito.Location = new System.Drawing.Point(0, 156);
            this.lblDeporteFavorito.Name = "lblDeporteFavorito";
            this.lblDeporteFavorito.Size = new System.Drawing.Size(800, 75);
            this.lblDeporteFavorito.TabIndex = 2;
            this.lblDeporteFavorito.Text = "Deporte Favorito";
            this.lblDeporteFavorito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCambiarDeporteFavorito
            // 
            this.btnCambiarDeporteFavorito.BackColor = System.Drawing.Color.Orange;
            this.btnCambiarDeporteFavorito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarDeporteFavorito.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.btnCambiarDeporteFavorito.Location = new System.Drawing.Point(533, 399);
            this.btnCambiarDeporteFavorito.Name = "btnCambiarDeporteFavorito";
            this.btnCambiarDeporteFavorito.Size = new System.Drawing.Size(255, 39);
            this.btnCambiarDeporteFavorito.TabIndex = 3;
            this.btnCambiarDeporteFavorito.Text = "Cambiar Mi Deporte Favorito";
            this.btnCambiarDeporteFavorito.UseVisualStyleBackColor = false;
            this.btnCambiarDeporteFavorito.Click += new System.EventHandler(this.btnCambiarDeporteFavorito_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 72);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // SportClubHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCambiarDeporteFavorito);
            this.Controls.Add(this.lblDeporteFavorito);
            this.Controls.Add(this.lblBienveni3);
            this.Controls.Add(this.btnCerrarSesion);
            this.Name = "SportClubHub";
            this.Text = "SportClubHub";
            this.Load += new System.EventHandler(this.SportClubHub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblBienveni3;
        private System.Windows.Forms.Label lblDeporteFavorito;
        private System.Windows.Forms.Button btnCambiarDeporteFavorito;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}