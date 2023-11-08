namespace winform
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoximagenRaza = new System.Windows.Forms.PictureBox();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximagenRaza)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoximagenRaza
            // 
            this.pictureBoximagenRaza.Location = new System.Drawing.Point(286, 49);
            this.pictureBoximagenRaza.Name = "pictureBoximagenRaza";
            this.pictureBoximagenRaza.Size = new System.Drawing.Size(163, 297);
            this.pictureBoximagenRaza.TabIndex = 0;
            this.pictureBoximagenRaza.TabStop = false;
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(302, 409);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(137, 23);
            this.comboBoxRaza.TabIndex = 1;
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(302, 439);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(137, 23);
            this.comboBoxGenero.TabIndex = 2;
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Location = new System.Drawing.Point(302, 470);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(137, 23);
            this.comboBoxClase.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::winform.Properties.Resources.OIG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 675);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.comboBoxRaza);
            this.Controls.Add(this.pictureBoximagenRaza);
            this.MaximumSize = new System.Drawing.Size(737, 714);
            this.MinimumSize = new System.Drawing.Size(737, 714);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximagenRaza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoximagenRaza;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.ComboBox comboBoxClase;
    }
}

