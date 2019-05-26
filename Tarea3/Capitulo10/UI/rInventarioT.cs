using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea3.Capitulo10.Entidades;



namespace Tarea3.Capitulo10.UI
{
    public partial class rInventarioT : Form
    {
        public rInventarioT()
        {
            InitializeComponent();
        }

        ArrayList arrayList = new ArrayList();

        public InventarioT[] productos = new InventarioT[30];


        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "Este campo no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }
            if (PrecioNumericUpDown.Text == string.Empty)
            {
                MyErrorProvider.SetError(PrecioNumericUpDown, "Este campo no puede estar vacio");
                PrecioNumericUpDown.Focus();
                paso = false;
            }
            if (CantidadNumericUpDown.Text == string.Empty)
            {
                MyErrorProvider.SetError(CantidadNumericUpDown, "Este campo no puede estar vacio");
                CantidadNumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }


        public void Limpiar()
        {
            CodigoNumericUpDown.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            PrecioNumericUpDown.Text = string.Empty;
            CantidadNumericUpDown.Text = string.Empty;
        }

        public void Agregar()
        {
            InventarioT inventario = new InventarioT();
   
            inventario.Nombre = DescripcionTextBox.Text;
            inventario.Precio = PrecioNumericUpDown.Text;
            inventario.Cantidad = CantidadNumericUpDown.Text;
            inventario.ProductoId = CodigoNumericUpDown.Text;

            arrayList.Add(productos);
            MessageBox.Show("!!Producto Guardado!!");
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
                Agregar();
            Limpiar();
        }
    }
}
