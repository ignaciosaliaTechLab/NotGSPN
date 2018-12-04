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
    public partial class BorrarUsuario : Form
    {
        public BorrarUsuario()
        {
            InitializeComponent();
            Acciones consulta = new Acciones();
            DataSet datos = consulta.consultarUsuarios("Engineer");
            dataGridView1.DataSource = datos;
            dataGridView1.DataMember = "Engineer";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //accion que borra usuaio
            Acciones borrarUser = new Acciones();
            borrarUser.borrarUsuario(textBox1.Text.ToString());
            //this.Close();
            //accion que hace refresh con la info de la base de datos actualizada
            Acciones consulta = new Acciones();
            DataSet datos = consulta.consultarUsuarios("Engineer");
            dataGridView1.DataSource = datos;
            dataGridView1.DataMember = "Engineer";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
