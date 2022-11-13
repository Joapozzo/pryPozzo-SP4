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
            this.lblMozoDelDia = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mrcConsultas = new System.Windows.Forms.GroupBox();
            this.lblTotales = new System.Windows.Forms.Label();
            this.lblMozoDia = new System.Windows.Forms.Label();
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
            this.dgvImportes.Location = new System.Drawing.Point(12, 12);
            this.dgvImportes.Name = "dgvImportes";
            this.dgvImportes.RowHeadersWidth = 51;
            this.dgvImportes.RowTemplate.Height = 24;
            this.dgvImportes.Size = new System.Drawing.Size(679, 248);
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
            this.btnValidarDatos.Location = new System.Drawing.Point(697, 12);
            this.btnValidarDatos.Name = "btnValidarDatos";
            this.btnValidarDatos.Size = new System.Drawing.Size(108, 45);
            this.btnValidarDatos.TabIndex = 1;
            this.btnValidarDatos.Text = "Validar Datos";
            this.btnValidarDatos.UseVisualStyleBackColor = true;
            this.btnValidarDatos.Click += new System.EventHandler(this.btnValidarDatos_Click);
            // 
            // lblMozoDelDia
            // 
            this.lblMozoDelDia.Location = new System.Drawing.Point(15, 35);
            this.lblMozoDelDia.Name = "lblMozoDelDia";
            this.lblMozoDelDia.Size = new System.Drawing.Size(109, 23);
            this.lblMozoDelDia.TabIndex = 2;
            this.lblMozoDelDia.Text = "Mozo del Dia";
            this.lblMozoDelDia.UseVisualStyleBackColor = true;
            this.lblMozoDelDia.Click += new System.EventHandler(this.lblMozoDelDia_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Totales";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // mrcConsultas
            // 
            this.mrcConsultas.Controls.Add(this.lblTotales);
            this.mrcConsultas.Controls.Add(this.lblMozoDia);
            this.mrcConsultas.Controls.Add(this.lblMozoDelDia);
            this.mrcConsultas.Controls.Add(this.button3);
            this.mrcConsultas.Location = new System.Drawing.Point(12, 277);
            this.mrcConsultas.Name = "mrcConsultas";
            this.mrcConsultas.Size = new System.Drawing.Size(551, 148);
            this.mrcConsultas.TabIndex = 4;
            this.mrcConsultas.TabStop = false;
            this.mrcConsultas.Text = "Consultas";
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Location = new System.Drawing.Point(158, 113);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(10, 16);
            this.lblTotales.TabIndex = 5;
            this.lblTotales.Text = ":";
            // 
            // lblMozoDia
            // 
            this.lblMozoDia.AutoSize = true;
            this.lblMozoDia.Location = new System.Drawing.Point(158, 38);
            this.lblMozoDia.Name = "lblMozoDia";
            this.lblMozoDia.Size = new System.Drawing.Size(10, 16);
            this.lblMozoDia.TabIndex = 4;
            this.lblMozoDia.Text = ":";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(697, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 45);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 437);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcConsultas);
            this.Controls.Add(this.btnValidarDatos);
            this.Controls.Add(this.dgvImportes);
            this.Name = "Menu";
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
        private System.Windows.Forms.Button lblMozoDelDia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox mrcConsultas;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.Label lblMozoDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna4;
        private System.Windows.Forms.Button btnSalir;
    }
}

