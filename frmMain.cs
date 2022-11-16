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
        int e = 0;
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
            int[] vecA = new int[4];
            i = 0;
            while (i <= 4)
            {
                vecA[i] = dgvImportes.Rows[i].Cells[1].ColumnIndex + dgvImportes.Rows[i].Cells[2].ColumnIndex + dgvImportes.Rows[i].Cells[3].ColumnIndex + dgvImportes.Rows[i].Cells[4].ColumnIndex;
                if (vecA[i] > vecA[i + 1])
                {
                    lblMozoDia.Text = "Total vendido del mozo:  " + vecA[i];
                }
                i++;
            }
        }
    }
}
