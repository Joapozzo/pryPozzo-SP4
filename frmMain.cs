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
            for (int i = 0; i <= 4; i++)
            {
                if (dgvImportes.Rows[i].Cells[1].Value == null && dgvImportes.Rows[i].Cells[2].Value == null && dgvImportes.Rows[i].Cells[3].Value == null &&
                    dgvImportes.Rows[i].Cells[4].Value == null)
                {
                    MessageBox.Show("Ingrese datos en todos los campos", "Error", MessageBoxButtons.OK);
                    return;
                }
            }

        }

        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
            i = 0;
            int[] vecA = new int[4];
            int Acumuladora = 0;
            int varTotal = 0;
            int varTotal1 = 0;
            int varTotal2 = 0;
            int varTotal3 = 0;
            int varTotal4 = 0;
            int[,] matA = new int[4, 4];
            string valor;
            for (int f = 0; f < 4; f++)
            {
                c = 0;
                for (int c = 0; c < 4; c++)
                {

                    valor = dgvImportes.Rows[f].Cells[c + 1].Value.ToString();
                    matA[f, c] = int.Parse(valor);
                    Acumuladora = Acumuladora + matA[f, c];
                    if (f == 0 && c == 4)
                    {
                        varTotal = Acumuladora;
                        Acumuladora = 0;
                    }
                    if (f == 1 && c == 4)
                    {
                        varTotal1 = Acumuladora;
                        Acumuladora = 0;
                    }
                    if (f == 2 && c == 4)
                    {
                        varTotal2 = Acumuladora;
                        Acumuladora = 0;
                    }
                    if (f == 3 && c == 4)
                    {
                        varTotal3 = Acumuladora;
                        Acumuladora = 0;
                    }
                    if (f == 4 && c == 4)
                    {
                        varTotal4 = Acumuladora;
                        Acumuladora = 0;
                    }
                }
            }
            vecA[0] = varTotal;
            vecA[1] = varTotal1;
            vecA[2] = varTotal2;
            vecA[3] = varTotal3;
            vecA[4] = varTotal4;
            while (i <= 4)
            {
                if (vecA[0] > vecA[1])
                {
                    lblMozoDia.Text = "Julio";
                }
                i = i + 1;
            }


        }
    }
}
