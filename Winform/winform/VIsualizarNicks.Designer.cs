namespace winform
{
    partial class VIsualizarNicks
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
            this.dataGridViewVisualizar = new System.Windows.Forms.DataGridView();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.Eliminarfisico = new System.Windows.Forms.Button();
            this.buttonEliminacionLogica = new System.Windows.Forms.Button();
            this.labelfiltro = new System.Windows.Forms.Label();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.labelCampo = new System.Windows.Forms.Label();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.labelfiltroavanzado = new System.Windows.Forms.Label();
            this.comboBoxFiltroAvanzado = new System.Windows.Forms.ComboBox();
            this.textBoxfiltroavanzado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVisualizar
            // 
            this.dataGridViewVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisualizar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewVisualizar.Location = new System.Drawing.Point(7, 38);
            this.dataGridViewVisualizar.Name = "dataGridViewVisualizar";
            this.dataGridViewVisualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVisualizar.Size = new System.Drawing.Size(494, 432);
            this.dataGridViewVisualizar.TabIndex = 0;
            this.dataGridViewVisualizar.SelectionChanged += new System.EventHandler(this.dataGridViewVisualizar_SelectionChanged);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(512, 40);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(64, 34);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // Eliminarfisico
            // 
            this.Eliminarfisico.Location = new System.Drawing.Point(512, 111);
            this.Eliminarfisico.Name = "Eliminarfisico";
            this.Eliminarfisico.Size = new System.Drawing.Size(64, 34);
            this.Eliminarfisico.TabIndex = 2;
            this.Eliminarfisico.Text = "Eliminar Fisico";
            this.Eliminarfisico.UseVisualStyleBackColor = true;
            this.Eliminarfisico.Click += new System.EventHandler(this.Eliminarfisico_Click);
            // 
            // buttonEliminacionLogica
            // 
            this.buttonEliminacionLogica.Location = new System.Drawing.Point(512, 188);
            this.buttonEliminacionLogica.Name = "buttonEliminacionLogica";
            this.buttonEliminacionLogica.Size = new System.Drawing.Size(64, 34);
            this.buttonEliminacionLogica.TabIndex = 3;
            this.buttonEliminacionLogica.Text = "Eliminar Logico";
            this.buttonEliminacionLogica.UseVisualStyleBackColor = true;
            this.buttonEliminacionLogica.Click += new System.EventHandler(this.buttonEliminacionLogica_Click);
            // 
            // labelfiltro
            // 
            this.labelfiltro.AutoSize = true;
            this.labelfiltro.Location = new System.Drawing.Point(13, 14);
            this.labelfiltro.Name = "labelfiltro";
            this.labelfiltro.Size = new System.Drawing.Size(29, 13);
            this.labelfiltro.TabIndex = 4;
            this.labelfiltro.Text = "Filtro";
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.Location = new System.Drawing.Point(55, 12);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiltrar.TabIndex = 5;
            this.textBoxFiltrar.TextChanged += new System.EventHandler(this.textBoxFiltrar_TextChanged);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(66, 584);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 6;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(9, 481);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(40, 13);
            this.labelCampo.TabIndex = 7;
            this.labelCampo.Text = "Campo";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(48, 478);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCampo.TabIndex = 8;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // labelCriterio
            // 
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(9, 511);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(39, 13);
            this.labelCriterio.TabIndex = 9;
            this.labelCriterio.Text = "Criterio";
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(48, 511);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCriterio.TabIndex = 10;
            // 
            // labelfiltroavanzado
            // 
            this.labelfiltroavanzado.AutoSize = true;
            this.labelfiltroavanzado.Location = new System.Drawing.Point(10, 543);
            this.labelfiltroavanzado.Name = "labelfiltroavanzado";
            this.labelfiltroavanzado.Size = new System.Drawing.Size(29, 13);
            this.labelfiltroavanzado.TabIndex = 11;
            this.labelfiltroavanzado.Text = "Filtro";
            // 
            // comboBoxFiltroAvanzado
            // 
            this.comboBoxFiltroAvanzado.FormattingEnabled = true;
            this.comboBoxFiltroAvanzado.Location = new System.Drawing.Point(398, 511);
            this.comboBoxFiltroAvanzado.Name = "comboBoxFiltroAvanzado";
            this.comboBoxFiltroAvanzado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroAvanzado.TabIndex = 12;
            this.comboBoxFiltroAvanzado.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltroAvanzado_SelectedIndexChanged);
            // 
            // textBoxfiltroavanzado
            // 
            this.textBoxfiltroavanzado.Location = new System.Drawing.Point(48, 543);
            this.textBoxfiltroavanzado.Name = "textBoxfiltroavanzado";
            this.textBoxfiltroavanzado.Size = new System.Drawing.Size(121, 20);
            this.textBoxfiltroavanzado.TabIndex = 13;
            // 
            // VIsualizarNicks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 647);
            this.Controls.Add(this.textBoxfiltroavanzado);
            this.Controls.Add(this.comboBoxFiltroAvanzado);
            this.Controls.Add(this.labelfiltroavanzado);
            this.Controls.Add(this.comboBoxCriterio);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.textBoxFiltrar);
            this.Controls.Add(this.labelfiltro);
            this.Controls.Add(this.buttonEliminacionLogica);
            this.Controls.Add(this.Eliminarfisico);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.dataGridViewVisualizar);
            this.Name = "VIsualizarNicks";
            this.Text = "VIsualizarNicks";
            this.Load += new System.EventHandler(this.VIsualizarNicks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVisualizar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button Eliminarfisico;
        private System.Windows.Forms.Button buttonEliminacionLogica;
        private System.Windows.Forms.Label labelfiltro;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.Label labelfiltroavanzado;
        private System.Windows.Forms.ComboBox comboBoxFiltroAvanzado;
        private System.Windows.Forms.TextBox textBoxfiltroavanzado;
    }
}