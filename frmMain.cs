using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPozzo_SP4
{
    public partial class Menu : Form
    {
        int i = 0;
        int f = 0;
        int c = 0;
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

            for (int i = 0; i <= 4; i++)
            {
                dgvImportes.Rows.Add(i.ToString());
            }
            dgvImportes.Rows[0].Cells[0].Value = "Julio";
            dgvImportes.Rows[1].Cells[0].Value = "Esteban";
            dgvImportes.Rows[2].Cells[0].Value = "Javier";
            dgvImportes.Rows[3].Cells[0].Value = "Gonzalo";
            dgvImportes.Rows[4].Cells[0].Value = "Alberto";
            dgvImportes.Columns[0].ReadOnly = true;
        }

        private void btnValidarDatos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 5; i++)
            {
                if (dgvImportes.Rows[i].Cells[1].Value == null || dgvImportes.Rows[i].Cells[2].Value == null || dgvImportes.Rows[i].Cells[3].Value == null ||
                    dgvImportes.Rows[i].Cells[4].Value == null || dgvImportes.Rows[i].Cells[5].Value == null)
                {
                    MessageBox.Show("Ingrese datos en todos los campos", "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            
        }

        private void lblMozoDelDia_Click(object sender, EventArgs e)
        {
            int VarTotal = 0;
            int VarTotal1 = 0;
            int VarTotal2 = 0;
            int VarTotal3 = 0;
            int VarTotal4 = 0;
            int Acumulador = 0;
            int[,] matB = new int[4, 4];
            matB[0, 0] = dgvImportes[f, c].Value;
            for (int f = 0; f <= 4; f++)
            {
                c = 0;
                for (int c = 0; c <= 4; c++)
                {
                    
                    Acumulador = Acumulador + c;
                    if (f == 0 && c == 4)
                    {
                        VarTotal = Acumulador;
                        Acumulador = 0;
                    }
                    if (f == 1 && c == 4)
                    {
                        VarTotal1 = Acumulador;
                        Acumulador = 0;
                    }
                    if (f == 2 && c == 4)
                    {
                        VarTotal2 = Acumulador;
                        Acumulador = 0;
                    }
                    if (f == 3 && c == 4)
                    {
                        VarTotal3 = Acumulador;
                        Acumulador = 0;
                    }
                    if (f == 4 && c == 4)
                    {
                        VarTotal4 = Acumulador;
                        Acumulador = 0;
                    }
                }
            }
        }
    }
}
