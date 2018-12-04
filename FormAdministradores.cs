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
    public partial class FormAdministradores : Form
    {
        public FormAdministradores()
        {
            InitializeComponent();
            Acciones consulta = new Acciones();
            DataSet datos = consulta.consultarUsuarios("Engineer");
            dataGridView1.DataSource = datos;
            dataGridView1.DataMember = "Engineer";
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarUsuario().Show();
        }
            
        private void consultarUsariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acciones consulta = new Acciones();            
            DataSet datos = consulta.consultarUsuarios("Engineer");
            dataGridView1.DataSource = datos;
            dataGridView1.DataMember = "Engineer";
        }

        private void cerrarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regresarASimuladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void actualizarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarUsuario().Show();
            /*this is just a comment*/
        }

        private void borrarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new BorrarUsuario().Show();
        }

        private void consultarCSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acciones consulta = new Acciones();
            DataSet datos = consulta.consultarUsuarios("CSA");
            dataGridView1.DataSource = datos;
            dataGridView1.DataMember = "CSA";
        }

        private void agregarCSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarCSA().Show();
        }
    }
}
