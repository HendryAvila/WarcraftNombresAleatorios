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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarNicknamesDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarNickGaurdadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.modificarNicksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximagenRaza)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoximagenRaza
            // 
            this.pictureBoximagenRaza.BackColor = System.Drawing.Color.White;
            this.pictureBoximagenRaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoximagenRaza.Location = new System.Drawing.Point(286, 49);
            this.pictureBoximagenRaza.Name = "pictureBoximagenRaza";
            this.pictureBoximagenRaza.Size = new System.Drawing.Size(163, 297);
            this.pictureBoximagenRaza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoximagenRaza.TabIndex = 0;
            this.pictureBoximagenRaza.TabStop = false;
            this.pictureBoximagenRaza.Click += new System.EventHandler(this.pictureBoximagenRaza_Click);
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(302, 409);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(137, 23);
            this.comboBoxRaza.TabIndex = 1;
           
            this.comboBoxRaza.SelectionChangeCommitted += new System.EventHandler(this.comboBoxRaza_SelectionChangeCommitted_1);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNicknamesDataBaseToolStripMenuItem,
            this.mostrarNickGaurdadosToolStripMenuItem,
            this.modificarNicksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
         
            // 
            // agregarNicknamesDataBaseToolStripMenuItem
            // 
            this.agregarNicknamesDataBaseToolStripMenuItem.Name = "agregarNicknamesDataBaseToolStripMenuItem";
            this.agregarNicknamesDataBaseToolStripMenuItem.Size = new System.Drawing.Size(179, 20);
            this.agregarNicknamesDataBaseToolStripMenuItem.Text = "Agregar Nicknames(DataBase)";
            this.agregarNicknamesDataBaseToolStripMenuItem.Click += new System.EventHandler(this.agregarNicknamesDataBaseToolStripMenuItem_Click);
            // 
            // mostrarNickGaurdadosToolStripMenuItem
            // 
            this.mostrarNickGaurdadosToolStripMenuItem.Name = "mostrarNickGaurdadosToolStripMenuItem";
            this.mostrarNickGaurdadosToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.mostrarNickGaurdadosToolStripMenuItem.Text = "Mostrar Nick Gaurdados";
            this.mostrarNickGaurdadosToolStripMenuItem.Click += new System.EventHandler(this.mostrarNickGaurdadosToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::winform.Properties.Resources.OIG;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(721, 657);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // modificarNicksToolStripMenuItem
            // 
            this.modificarNicksToolStripMenuItem.Name = "modificarNicksToolStripMenuItem";
            this.modificarNicksToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.modificarNicksToolStripMenuItem.Text = "Modificar Nicks";
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::winform.Properties.Resources.OIG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 675);
            this.Controls.Add(this.pictureBoximagenRaza);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.comboBoxRaza);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(737, 714);
            this.MinimumSize = new System.Drawing.Size(737, 714);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximagenRaza)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoximagenRaza;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.ComboBox comboBoxClase;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarNicknamesDataBaseToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mostrarNickGaurdadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarNicksToolStripMenuItem;
    }
}

