using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea3.Capitulo10.UI;
using Tarea3.Capitulo9.UI;

namespace Tarea3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void EjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos rp = new rProductos();
            rp.Show();
        }

        private void Ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rMascotas rm = new rMascotas();
            rm.Show();
        }

        private void Ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiante re = new rEstudiante();
            re.Show();
        }

        private void Ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rInventarioT ri = new rInventarioT();
            ri.Show();
        }
    }
}
