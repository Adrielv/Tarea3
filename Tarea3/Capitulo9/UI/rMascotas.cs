using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea3.Capitulo9.Entidades;
using System.Collections;

namespace Tarea3.Capitulo9.UI
{
    public partial class rMascotas : Form
    {
        public rMascotas()
        {
            InitializeComponent();
        }

        ArrayList arrayList = new ArrayList();

        public Owner DueñoMascota = new Owner();

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (NombreOTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreOTextBox, "Este campo no puede estar vacio");
                NombreOTextBox.Focus();
                paso = false;
            }
            if (EdadONumericUpDown.Text == string.Empty)
            {
                MyErrorProvider.SetError(EdadONumericUpDown, "Este campo no puede estar vacio");
                EdadONumericUpDown.Focus();
                paso = false;
            }
            if (GeneroOTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(GeneroOTextBox, "Este campo no puede estar vacio");
                GeneroOTextBox.Focus();
                paso = false;
            }

            if (NombreMTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreMTextBox, "No puede dejar este campo vacio");
                NombreMTextBox.Focus();
                paso = false;
            }
            if (EdadMNumericUpDown.Text == string.Empty)
            {
                MyErrorProvider.SetError(EdadMNumericUpDown, "No puede dejar este campo vacio");
                EdadMNumericUpDown.Focus();
                paso = false;
            }
            if (GeneroTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(GeneroTextBox, "No puede dejar este campo vacio");
                GeneroTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        public void Limpiar()
        {
            NombreOTextBox.Text = string.Empty;
            EdadONumericUpDown.Text = string.Empty;
            GeneroOTextBox.Text = string.Empty;
            NombreMTextBox.Text = string.Empty;
            EdadMNumericUpDown.Text = string.Empty;
            GeneroTextBox.Text = string.Empty;
        }

        public void Agregar()
        {
            Owner owner = new Owner();
            owner.NombreD = NombreOTextBox.Text;
            owner.edadD = EdadONumericUpDown.Text;
            owner.sexoD = GeneroOTextBox.Text;
            owner.NombreMascota = NombreMTextBox.Text;
            owner.DueñoMascot = EdadMNumericUpDown.Text;
            owner.sexoMascota = GeneroTextBox.Text;

            arrayList.Add(Owner);
            MessageBox.Show("!!Informacion Guardadas!!");
        }

      

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (Validar())

                Agregar();
            Limpiar();
        }

       
    }
}
