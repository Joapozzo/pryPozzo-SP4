namespace pryPozzo_SP4
{
    partial class Menu
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
            this.dgvImportes = new System.Windows.Forms.DataGridView();
            this.dgvColumna0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValidarDatos = new System.Windows.Forms.Button();
            this.btnMozoDelDia = new System.Windows.Forms.Button();
            this.btnTotales = new System.Windows.Forms.Button();
            this.mrcConsultas = new System.Windows.Forms.GroupBox();
            this.txtMozodelDia = new System.Windows.Forms.TextBox();
            this.lisTotales = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportes)).BeginInit();
            this.mrcConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvImportes
            // 
            this.dgvImportes.AllowUserToAddRows = false;
            this.dgvImportes.AllowUserToDeleteRows = false;
            this.dgvImportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumna0,
            this.dgvColumna1,
            this.dgvColumna2,
            this.dgvColumna3,
            this.dgvColumna4});
            this.dgvImportes.Location = new System.Drawing.Point(9, 11);
            this.dgvImportes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvImportes.Name = "dgvImportes";
            this.dgvImportes.RowHeadersWidth = 51;
            this.dgvImportes.RowTemplate.Height = 24;
            this.dgvImportes.Size = new System.Drawing.Size(623, 274);
            this.dgvImportes.TabIndex = 0;
            // 
            // dgvColumna0
            // 
            this.dgvColumna0.HeaderText = "Nombre Mozo";
            this.dgvColumna0.MinimumWidth = 6;
            this.dgvColumna0.Name = "dgvColumna0";
            this.dgvColumna0.Width = 125;
            // 
            // dgvColumna1
            // 
            this.dgvColumna1.HeaderText = "Comidas";
            this.dgvColumna1.MinimumWidth = 6;
            this.dgvColumna1.Name = "dgvColumna1";
            this.dgvColumna1.Width = 125;
            // 
            // dgvColumna2
            // 
            this.dgvColumna2.HeaderText = "Bebidas Sin Alcohol";
            this.dgvColumna2.MinimumWidth = 6;
            this.dgvColumna2.Name = "dgvColumna2";
            this.dgvColumna2.Width = 125;
            // 
            // dgvColumna3
            // 
            this.dgvColumna3.HeaderText = "Bebidas Con Alcohol";
            this.dgvColumna3.MinimumWidth = 6;
            this.dgvColumna3.Name = "dgvColumna3";
            this.dgvColumna3.Width = 125;
            // 
            // dgvColumna4
            // 
            this.dgvColumna4.HeaderText = "Postres";
            this.dgvColumna4.MinimumWidth = 6;
            this.dgvColumna4.Name = "dgvColumna4";
            this.dgvColumna4.Width = 125;
            // 
            // btnValidarDatos
            // 
            this.btnValidarDatos.Location = new System.Drawing.Point(659, 11);
            this.btnValidarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidarDatos.Name = "btnValidarDatos";
            this.btnValidarDatos.Size = new System.Drawing.Size(81, 37);
            this.btnValidarDatos.TabIndex = 1;
            this.btnValidarDatos.Text = "Validar Datos";
            this.btnValidarDatos.UseVisualStyleBackColor = true;
            this.btnValidarDatos.Click += new System.EventHandler(this.btnValidarDatos_Click);
            // 
            // btnMozoDelDia
            // 
            this.btnMozoDelDia.Enabled = false;
            this.btnMozoDelDia.Location = new System.Drawing.Point(4, 22);
            this.btnMozoDelDia.Margin = new System.Windows.Forms.Padding(2);
            this.btnMozoDelDia.Name = "btnMozoDelDia";
            this.btnMozoDelDia.Size = new System.Drawing.Size(82, 47);
            this.btnMozoDelDia.TabIndex = 2;
            this.btnMozoDelDia.Text = "Mozo del Dia";
            this.btnMozoDelDia.UseVisualStyleBackColor = true;
            this.btnMozoDelDia.Click += new System.EventHandler(this.btnMozoDelDia_Click);
            // 
            // btnTotales
            // 
            this.btnTotales.Enabled = false;
            this.btnTotales.Location = new System.Drawing.Point(4, 90);
            this.btnTotales.Margin = new System.Windows.Forms.Padding(2);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(82, 32);
            this.btnTotales.TabIndex = 3;
            this.btnTotales.Text = "Totales";
            this.btnTotales.UseVisualStyleBackColor = true;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // mrcConsultas
            // 
            this.mrcConsultas.Controls.Add(this.txtMozodelDia);
            this.mrcConsultas.Controls.Add(this.lisTotales);
            this.mrcConsultas.Controls.Add(this.btnMozoDelDia);
            this.mrcConsultas.Controls.Add(this.btnTotales);
            this.mrcConsultas.Location = new System.Drawing.Point(11, 302);
            this.mrcConsultas.Margin = new System.Windows.Forms.Padding(2);
            this.mrcConsultas.Name = "mrcConsultas";
            this.mrcConsultas.Padding = new System.Windows.Forms.Padding(2);
            this.mrcConsultas.Size = new System.Drawing.Size(621, 206);
            this.mrcConsultas.TabIndex = 4;
            this.mrcConsultas.TabStop = false;
            this.mrcConsultas.Text = "Consultas";
            // 
            // txtMozodelDia
            // 
            this.txtMozodelDia.Location = new System.Drawing.Point(91, 22);
            this.txtMozodelDia.Name = "txtMozodelDia";
            this.txtMozodelDia.Size = new System.Drawing.Size(100, 20);
            this.txtMozodelDia.TabIndex = 7;
            // 
            // lisTotales
            // 
            this.lisTotales.FormattingEnabled = true;
            this.lisTotales.Location = new System.Drawing.Point(91, 90);
            this.lisTotales.Name = "lisTotales";
            this.lisTotales.Size = new System.Drawing.Size(178, 95);
            this.lisTotales.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(659, 307);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 37);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 518);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcConsultas);
            this.Controls.Add(this.btnValidarDatos);
            this.Controls.Add(this.dgvImportes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportes)).EndInit();
            this.mrcConsultas.ResumeLayout(false);
            this.mrcConsultas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImportes;
        private System.Windows.Forms.Button btnValidarDatos;
        private System.Windows.Forms.Button btnMozoDelDia;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.GroupBox mrcConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lisTotales;
        private System.Windows.Forms.TextBox txtMozodelDia;
    }
}

