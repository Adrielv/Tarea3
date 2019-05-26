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
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        ArrayList arrayList = new ArrayList();

        public Productos[] productos = new Productos[30];

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (NombreTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreTextBox, "Este campo no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }
            if (CodigoNumericUpDown.Text == string.Empty)
            {
                MyErrorProvider.SetError(CodigoNumericUpDown, "Este campo no puede estar vacio");
                CodigoNumericUpDown.Focus();
                paso = false;
            }
            if (PrecionumericUpDown.Text == string.Empty)
            {
                MyErrorProvider.SetError(PrecionumericUpDown, "Este campo no puede estar vacio");
                PrecionumericUpDown.Focus();
                paso = false;
            }

            if (CantidadnumericUpDown3.Text == string.Empty)
            {
                MyErrorProvider.SetError(CantidadnumericUpDown3, "No puede dejar este campo vacio");
                CantidadnumericUpDown3.Focus();
                paso = false;
            }
            return paso;
        }


        public void Limpiar()
        {
            NombreTextBox.Text = string.Empty;
           CodigoNumericUpDown.Text = string.Empty;
            PrecionumericUpDown.Text = string.Empty;
            CantidadnumericUpDown3.Text = string.Empty;
        }

        public void Agregar()
        {
            Productos productos = new Productos();

            productos.Nombre = NombreTextBox.Text;
            productos.Codigo = CodigoNumericUpDown.Text;
            productos.Cantidad = CantidadnumericUpDown3.Text;
            productos.Precio = PrecionumericUpDown.Text;


            arrayList.Add(productos);
            MessageBox.Show("!!Producto Guardado!!");
        }


        private void NuevoButton_Click(object sender, EventArgs e)
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
