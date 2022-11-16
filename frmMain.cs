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
        float[,] matA = new float[5, 5];
        int e = 0;
        int i = 0;
        int f = 0;
        int c = 0;
        public void CompletarMatriz()
        {
            for (int f = 0; f < matA.GetLength(0) ; f++)
            {
                for (int c = 0; c < matA.GetLength(1) -1 ; c++)
                {
                    matA[f, c] = Convert.ToSingle(dgvImportes.Rows[f].Cells[c + 1].Value);
                }
            }
        }



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
            bool validado = true;
            for (int c = 1; c < dgvImportes.ColumnCount; c++)
            {
                for (int f = 0; f < dgvImportes.RowCount; f++)
                {
                    if (dgvImportes.Rows[f].Cells[c].Value == null)
                    {
                        validado = false;
                        MessageBox.Show("Ingresa bien las cosas pelotudo");
                    }
                }
            }
            if (validado == true)
            {
                CompletarMatriz();
                MessageBox.Show("Los datos fueron ingresados");
                for (int f = 0; f < matA.GetLength(0); f++)
                {
                    for (int c = 0; c < matA.GetLength(1) - 1; c++)
                    {
                        matA[f, 4] = matA[f, c] + matA[f, 4];
                    }
                }
            }

        }


        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
            float varTotal = matA[f, c];
            int indice = 0;
            for (int f = 0; f < matA.GetLength(0); f++)
            {
                if (varTotal < matA[f, 4])
                {
                    varTotal = matA[f, 4];
                    indice = f;
                }
            }
            if (indice == 0)
            {
                txtMozodelDia.Text = "Julio";
            }
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            lisTotales.Items.Clear();
            lisTotales.Items.Add("Julio " + matA[0, 4].ToString());
            lisTotales.Items.Add("Esteban " + matA[1, 4].ToString());
            lisTotales.Items.Add("Javier " + matA[2, 4].ToString());
            lisTotales.Items.Add("Gonzalo " + matA[3, 4].ToString());
            lisTotales.Items.Add("Alberto " + matA[4, 4].ToString());
        }
    }
}

