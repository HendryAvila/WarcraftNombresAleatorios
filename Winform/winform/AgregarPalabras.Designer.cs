namespace winform
{
    partial class AgregarPalabras
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxAgregarNick = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonAgregarname = new System.Windows.Forms.Button();
            this.buttonCancelarAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRazaAG = new System.Windows.Forms.ComboBox();
            this.razaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.worldOfWarcraftNombresDataSet4 = new winform.WorldOfWarcraftNombresDataSet4();
            this.comboBoxGeneroAG = new System.Windows.Forms.ComboBox();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldOfWarcraftNombresDataSet2 = new winform.WorldOfWarcraftNombresDataSet2();
            this.comboBoxClaseAG = new System.Windows.Forms.ComboBox();
            this.tipoDePersonajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldOfWarcraftNombresDataSet3 = new winform.WorldOfWarcraftNombresDataSet3();
            this.worldOfWarcraftNombresDataSet = new winform.WorldOfWarcraftNombresDataSet();
            this.razaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.razaTableAdapter = new winform.WorldOfWarcraftNombresDataSetTableAdapters.RazaTableAdapter();
            this.generoTableAdapter = new winform.WorldOfWarcraftNombresDataSet2TableAdapters.GeneroTableAdapter();
            this.tipoDePersonajeTableAdapter = new winform.WorldOfWarcraftNombresDataSet3TableAdapters.TipoDePersonajeTableAdapter();
            this.razaTableAdapter1 = new winform.WorldOfWarcraftNombresDataSet4TableAdapters.RazaTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modificarNicknamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.razaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldOfWarcraftNombresDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldOfWarcraftNombresDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDePersonajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldOfWarcraftNombresDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldOfWarcraftNombresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razaBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-49, -62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBoxAgregarNick
            // 
            this.textBoxAgregarNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxAgregarNick.Location = new System.Drawing.Point(142, 112);
            this.textBoxAgregarNick.Name = "textBoxAgregarNick";
            this.textBoxAgregarNick.Size = new System.Drawing.Size(140, 24);
            this.textBoxAgregarNick.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(546, 244);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // buttonAgregarname
            // 
            this.buttonAgregarname.Location = new System.Drawing.Point(119, 300);
            this.buttonAgregarname.Name = "buttonAgregarname";
            this.buttonAgregarname.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarname.TabIndex = 4;
            this.buttonAgregarname.Text = "Aceptar";
            this.buttonAgregarname.UseVisualStyleBackColor = true;
            this.buttonAgregarname.Click += new System.EventHandler(this.buttonAgregarname_Click);
            // 
            // buttonCancelarAgregar
            // 
            this.buttonCancelarAgregar.Location = new System.Drawing.Point(207, 300);
            this.buttonCancelarAgregar.Name = "buttonCancelarAgregar";
            this.buttonCancelarAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarAgregar.TabIndex = 5;
            this.buttonCancelarAgregar.Text = "Cancelar";
            this.buttonCancelarAgregar.UseVisualStyleBackColor = true;
            this.buttonCancelarAgregar.Click += new System.EventHandler(this.buttonCancelarAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "NickName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Raza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Clase";
            // 
            // comboBoxRazaAG
            // 
            this.comboBoxRazaAG.DataSource = this.razaBindingSource1;
            this.comboBoxRazaAG.DisplayMember = "NombreRaza";
            this.comboBoxRazaAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxRazaAG.FormattingEnabled = true;
            this.comboBoxRazaAG.Location = new System.Drawing.Point(142, 150);
            this.comboBoxRazaAG.Name = "comboBoxRazaAG";
            this.comboBoxRazaAG.Size = new System.Drawing.Size(140, 26);
            this.comboBoxRazaAG.TabIndex = 10;
            this.comboBoxRazaAG.ValueMember = "NombreRaza";
            // 
            // razaBindingSource1
            // 
            this.razaBindingSource1.DataMember = "Raza";
            this.razaBindingSource1.DataSource = this.worldOfWarcraftNombresDataSet4;
            // 
            // worldOfWarcraftNombresDataSet4
            // 
            this.worldOfWarcraftNombresDataSet4.DataSetName = "WorldOfWarcraftNombresDataSet4";
            this.worldOfWarcraftNombresDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxGeneroAG
            // 
            this.comboBoxGeneroAG.DataSource = this.generoBindingSource;
            this.comboBoxGeneroAG.DisplayMember = "Genero";
            this.comboBoxGeneroAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxGeneroAG.FormattingEnabled = true;
            this.comboBoxGeneroAG.Location = new System.Drawing.Point(142, 187);
            this.comboBoxGeneroAG.Name = "comboBoxGeneroAG";
            this.comboBoxGeneroAG.Size = new System.Drawing.Size(140, 26);
            this.comboBoxGeneroAG.TabIndex = 11;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.worldOfWarcraftNombresDataSet2;
            // 
            // worldOfWarcraftNombresDataSet2
            // 
            this.worldOfWarcraftNombresDataSet2.DataSetName = "WorldOfWarcraftNombresDataSet2";
            this.worldOfWarcraftNombresDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxClaseAG
            // 
            this.comboBoxClaseAG.DataSource = this.tipoDePersonajeBindingSource;
            this.comboBoxClaseAG.DisplayMember = "NombreTipoPersonaje";
            this.comboBoxClaseAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxClaseAG.FormattingEnabled = true;
            this.comboBoxClaseAG.Location = new System.Drawing.Point(142, 223);
            this.comboBoxClaseAG.Name = "comboBoxClaseAG";
            this.comboBoxClaseAG.Size = new System.Drawing.Size(140, 26);
            this.comboBoxClaseAG.TabIndex = 12;
            this.comboBoxClaseAG.ValueMember = "NombreTipoPersonaje";
            // 
            // tipoDePersonajeBindingSource
            // 
            this.tipoDePersonajeBindingSource.DataMember = "TipoDePersonaje";
            this.tipoDePersonajeBindingSource.DataSource = this.worldOfWarcraftNombresDataSet3;
            // 
            // worldOfWarcraftNombresDataSet3
            // 
            this.worldOfWarcraftNombresDataSet3.DataSetName = "WorldOfWarcraftNombresDataSet3";
            this.worldOfWarcraftNombresDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // worldOfWarcraftNombresDataSet
            // 
            this.worldOfWarcraftNombresDataSet.DataSetName = "WorldOfWarcraftNombresDataSet";
            this.worldOfWarcraftNombresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // razaBindingSource
            // 
            this.razaBindingSource.DataMember = "Raza";
            this.razaBindingSource.DataSource = this.worldOfWarcraftNombresDataSet;
            // 
            // razaTableAdapter
            // 
            this.razaTableAdapter.ClearBeforeFill = true;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // tipoDePersonajeTableAdapter
            // 
            this.tipoDePersonajeTableAdapter.ClearBeforeFill = true;
            // 
            // razaTableAdapter1
            // 
            this.razaTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarNicknamesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modificarNicknamesToolStripMenuItem
            // 
            this.modificarNicknamesToolStripMenuItem.Name = "modificarNicknamesToolStripMenuItem";
            this.modificarNicknamesToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.modificarNicknamesToolStripMenuItem.Text = "Modificar Nicknames";
            this.modificarNicknamesToolStripMenuItem.Click += new System.EventHandler(this.modificarNicknamesToolStripMenuItem_Click);
            // 
            // AgregarPalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::winform.Properties.Resources.world_of_warcraft_orc_4k;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(415, 458);
            this.Controls.Add(this.comboBoxClaseAG);
            this.Controls.Add(this.comboBoxGeneroAG);
            this.Controls.Add(this.comboBoxRazaAG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelarAgregar);
            this.Controls.Add(this.buttonAgregarname);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxAgregarNick);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AgregarPalabras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPalabras";
            this.Load += new System.EventHandler(this.AgregarPalabras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.razaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldOfWarcraftNombresDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldOfWarcraftNombresDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDePersonajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldOfWarcraftNombresDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldOfWarcraftNombresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razaBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxAgregarNick;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonAgregarname;
        private System.Windows.Forms.Button buttonCancelarAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRazaAG;
        private System.Windows.Forms.ComboBox comboBoxGeneroAG;
        private System.Windows.Forms.ComboBox comboBoxClaseAG;
        private WorldOfWarcraftNombresDataSet worldOfWarcraftNombresDataSet;
        private System.Windows.Forms.BindingSource razaBindingSource;
        private WorldOfWarcraftNombresDataSetTableAdapters.RazaTableAdapter razaTableAdapter;
        private WorldOfWarcraftNombresDataSet2 worldOfWarcraftNombresDataSet2;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private WorldOfWarcraftNombresDataSet2TableAdapters.GeneroTableAdapter generoTableAdapter;
        private WorldOfWarcraftNombresDataSet3 worldOfWarcraftNombresDataSet3;
        private System.Windows.Forms.BindingSource tipoDePersonajeBindingSource;
        private WorldOfWarcraftNombresDataSet3TableAdapters.TipoDePersonajeTableAdapter tipoDePersonajeTableAdapter;
        private WorldOfWarcraftNombresDataSet4 worldOfWarcraftNombresDataSet4;
        private System.Windows.Forms.BindingSource razaBindingSource1;
        private WorldOfWarcraftNombresDataSet4TableAdapters.RazaTableAdapter razaTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificarNicknamesToolStripMenuItem;
    }
}