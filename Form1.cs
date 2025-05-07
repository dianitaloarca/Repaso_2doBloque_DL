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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumAleatorio repaso1 = new NumAleatorio();
            repaso1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlumnoAleatorio repaso2 = new AlumnoAleatorio();
            repaso2.Show();
        }
    }
}
