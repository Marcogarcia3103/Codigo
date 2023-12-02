using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Coppel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleado form = new FormEmpleado();
            form.ShowDialog();  
        }

        private void BtnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleado form = new FormEmpleado();
            form.ShowDialog();
        }

        private void BtnAgregarDirectivos_Click(object sender, EventArgs e)
        {
            FormDirectivo form = new FormDirectivo();   
            form.ShowDialog();
        }

        private void BtnBuscarDirectivo_Click(object sender, EventArgs e)
        {
            FormDirectivo form = new FormDirectivo();
            form.ShowDialog();
        }

        private void BtnAgregarCentro_Click(object sender, EventArgs e)
        {
            FormCentro form = new FormCentro();
            form.ShowDialog();
        }

        private void BtnBuscarCentro_Click(object sender, EventArgs e)
        {
            FormCentro form = new FormCentro();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
