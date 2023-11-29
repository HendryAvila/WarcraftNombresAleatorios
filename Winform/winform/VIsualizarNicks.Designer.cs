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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVisualizar
            // 
            this.dataGridViewVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisualizar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewVisualizar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVisualizar.Name = "dataGridViewVisualizar";
            this.dataGridViewVisualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVisualizar.Size = new System.Drawing.Size(494, 456);
            this.dataGridViewVisualizar.TabIndex = 0;
            this.dataGridViewVisualizar.SelectionChanged += new System.EventHandler(this.dataGridViewVisualizar_SelectionChanged);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(512, 12);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(64, 34);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // VIsualizarNicks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 502);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.dataGridViewVisualizar);
            this.Name = "VIsualizarNicks";
            this.Text = "VIsualizarNicks";
            this.Load += new System.EventHandler(this.VIsualizarNicks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisualizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVisualizar;
        private System.Windows.Forms.Button buttonModificar;
    }
}