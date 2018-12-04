using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AgregarCSA : Form
    {
        public AgregarCSA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Acciones accion = new Acciones();
            accion.AgregarCSAInteractivo(textBox1.Text.ToString(), textBox2.Text.ToString(), listBox1.Items[listBox1.SelectedIndex].ToString());
        }
    }
}
