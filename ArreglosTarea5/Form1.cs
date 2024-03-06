using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArreglosTarea5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Arreglo unidimensional
            int[] arregloUnidimensional = new int[5] { 1, 2, 3, 4, 5 };
            string resultado = "Arreglo unidimensional:\n";

            foreach (int num in arregloUnidimensional)
            {
                resultado += num + " ";
            }

            MessageBox.Show(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Arreglo bidimensional
            int[,] arregloBidimensional = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            string resultado = "Arreglo bidimensional:\n";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultado += arregloBidimensional[i, j] + " ";
                }
                resultado += "\n";
            }

            MessageBox.Show(resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Arreglo tridimensional
            int[,,] arregloTridimensional = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
            string resultado = "Arreglo tridimensional:\n";

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        resultado += arregloTridimensional[i, j, k] + " ";
                    }
                    resultado += "\n";
                }
                resultado += "\n";
            }

            MessageBox.Show(resultado);
        }
    }
}


