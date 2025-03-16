namespace WindowsFormsApp1
{
    partial class verlavado
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipolav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docupro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.propietario,
            this.tipolav,
            this.vehiculo,
            this.docupro,
            this.Placa,
            this.Precio});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 392);
            this.dataGridView1.TabIndex = 1;
            // 
            // propietario
            // 
            this.propietario.HeaderText = "Propietario:";
            this.propietario.Name = "propietario";
            // 
            // tipolav
            // 
            this.tipolav.HeaderText = "Tipo De Lavado:";
            this.tipolav.Name = "tipolav";
            // 
            // vehiculo
            // 
            this.vehiculo.HeaderText = "Vehiculo:";
            this.vehiculo.Name = "vehiculo";
            // 
            // docupro
            // 
            this.docupro.HeaderText = "Documento Propietario:";
            this.docupro.Name = "docupro";
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa:";
            this.Placa.Name = "Placa";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio:";
            this.Precio.Name = "Precio";
            // 
            // verlavado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(678, 412);
            this.Controls.Add(this.dataGridView1);
            this.Name = "verlavado";
            this.Text = "verlavado";
            this.Load += new System.EventHandler(this.verlavado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipolav;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn docupro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}