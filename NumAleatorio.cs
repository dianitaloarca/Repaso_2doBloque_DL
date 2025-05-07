using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_2doBloque_DL
{
    public partial class NumAleatorio : Form
    {
        int aleatorio = 0;
        Random rand = new Random();

    
        public NumAleatorio()
        {
            InitializeComponent();
        }

        private void NumAleatorio_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumMax.Text, out int numMax))
            {
                if (numMax > 0)
                {
                    aleatorio = rand.Next(1, numMax);
                    MessageBox.Show($"Número Aleatorio: {aleatorio}");

                }
                else
                {
                    MessageBox.Show("Ingrese un número positivo");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido");
            }


        

        }
    }


}
