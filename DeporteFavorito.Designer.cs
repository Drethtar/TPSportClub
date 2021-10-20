
namespace TPDataBase
{
    partial class DeporteFavorito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeporteFavorito));
            this.button1 = new System.Windows.Forms.Button();
            this.cbxDeportes = new System.Windows.Forms.ComboBox();
            this.cbxCaracteristicas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.button1.Location = new System.Drawing.Point(310, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cambiar El Deporte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxDeportes
            // 
            this.cbxDeportes.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.cbxDeportes.FormattingEnabled = true;
            this.cbxDeportes.Items.AddRange(new object[] {
            "Esgrima",
            "Football",
            "Boxeo",
            "Natacion",
            "Ajedrez",
            "Atletismo",
            "Ninguno"});
            this.cbxDeportes.Location = new System.Drawing.Point(12, 158);
            this.cbxDeportes.Name = "cbxDeportes";
            this.cbxDeportes.Size = new System.Drawing.Size(163, 44);
            this.cbxDeportes.TabIndex = 2;
            // 
            // cbxCaracteristicas
            // 
            this.cbxCaracteristicas.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.cbxCaracteristicas.FormattingEnabled = true;
            this.cbxCaracteristicas.Items.AddRange(new object[] {
            "De Contacto",
            "Sin Contacto"});
            this.cbxCaracteristicas.Location = new System.Drawing.Point(12, 286);
            this.cbxCaracteristicas.Name = "cbxCaracteristicas";
            this.cbxCaracteristicas.Size = new System.Drawing.Size(163, 44);
            this.cbxCaracteristicas.TabIndex = 3;
            this.cbxCaracteristicas.SelectedIndexChanged += new System.EventHandler(this.cbxCaracteristicas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Deportes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.label3.Location = new System.Drawing.Point(6, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caracteristicas";
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
            // DeporteFavorito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCaracteristicas);
            this.Controls.Add(this.cbxDeportes);
            this.Controls.Add(this.button1);
            this.Name = "DeporteFavorito";
            this.Text = "DeporteFavorito";
            this.Load += new System.EventHandler(this.DeporteFavorito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxDeportes;
        private System.Windows.Forms.ComboBox cbxCaracteristicas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}