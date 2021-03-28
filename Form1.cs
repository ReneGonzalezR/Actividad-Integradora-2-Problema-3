using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Integradora_2_Problema_3
{
    public partial class Form1 : Form
    {
        string[] nombre = new string[] { "Estufa", "Licuadora", "Refrigerador", "Plancha", "Horno Microondas", "Braum", 
            "Cafetera", "Cuchillos", "Set de Cocina", "Vasos" };
        double[] precio = new double[] { 5500.50, 1200.00, 12500.99, 250.90, 2500.00, 120.00, 450.50, 50.99, 3000.00, 20.00};
        public Form1()
        {
            InitializeComponent();
            dgvDatos.Rows.Clear();
            for (int i = 0; i < nombre.Length; i++)
            {
                dgvDatos.Rows.Add(1);
                dgvDatos.Rows[i].Cells[0].Value = nombre[i];
                dgvDatos.Rows[i].Cells[1].Value = precio[i].ToString(); ;
            }
        }

        private void btnAlfabetico_Click(object sender, EventArgs e)
        {
            int length = nombre.Length;
            dgvDatos.Rows.Clear();

            for (int i = 0; i < length -1; i++)
            {
                for (int x = 0; x < length - i -1; x++)
                {
                    if (nombre[x].CompareTo(nombre[x+1])>0)
                    {
                        string auxNombre;
                        auxNombre = nombre[x];
                        nombre[x] = nombre[x + 1];
                        nombre[x + 1] = auxNombre;
                        double auxPrecio;
                        auxPrecio = precio[x];
                        precio[x] = precio[x + 1];
                        precio[x + 1] = auxPrecio; 
                    }
                }
            }

            for (int i = 0; i < nombre.Length; i++)
            {
                dgvDatos.Rows.Add(1);
                dgvDatos.Rows[i].Cells[0].Value = nombre[i].ToString();
                dgvDatos.Rows[i].Cells[1].Value = precio[i].ToString();
            }
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            int length = precio.Length;
            dgvDatos.Rows.Clear();

            for (int i = 0; i < length - 1; i++)
            {
                for (int x = 0; x < length - i - 1; x++)
                {
                    if (precio[x] > precio[x + 1])
                    {
                        double auxPrecio;
                        auxPrecio = precio[x];
                        precio[x] = precio[x + 1];
                        precio[x + 1] = auxPrecio;

                        string auxNombre;
                        auxNombre = nombre[x];
                        nombre[x] = nombre[x + 1];
                        nombre[x + 1] = auxNombre;
                    }
                }
            }

            for (int i = 0; i < nombre.Length; i++)
            {
                dgvDatos.Rows.Add(1);
                dgvDatos.Rows[i].Cells[0].Value = nombre[i].ToString();
                dgvDatos.Rows[i].Cells[1].Value = precio[i].ToString();
            }
        }
    }
}
