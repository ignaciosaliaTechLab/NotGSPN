using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        //string nombre, password;
        int i = 0;

        public Form1()
        {
            InitializeComponent();

            MessageBox.Show("Notice___ This system is strictly restricted to employees or business parterner of Samsung Electrinics CO.LTD Any illegal access will be punished according to related laws. Dear Users, We never send you any e - mail asking your account and password. Therefore it is requested that you do not access or respond to any suspicious site(which may look like G - SPN) or e-mail. Thank you.");

            textBox1.PasswordChar = '*';
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Acciones accion = new Acciones();
            accion.AgregarUsuario();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            //Logica para verficación de usuario

            Acciones accion = new Acciones();

            int res = accion.validacionUsuario(textBox2.Text.ToString(), textBox1.Text.ToString());
            

            if(res == 0)
            {
                
               
                MessageBox.Show("GSPN ID or password is not matched.");
                MessageBox.Show("Notice___ This system is strictly restricted to employees or business parterner of Samsung Electrinics CO.LTD Any illegal access will be punished according to related laws. Dear Users, We never send you any e - mail asking your account and password. Therefore it is requested that you do not access or respond to any suspicious site(which may look like G - SPN) or e-mail. Thank you.");
                i++;

            }
            else
            {
                //Se obtiene nomre y apellido de quien ingresa 
                string nombre = accion.consultaNombre(textBox2.Text.ToString(), textBox1.Text.ToString());
                //MessageBox.Show("Bienvenido ");
                MessageBox.Show("♣Bienvenido al sistema de GSPN de Samsung Electronics. ♣  ◈ Noticia ◈ __________ " + '\n' + "- Este sistema está estrictamente restringido a empleados o socios comerciales de Samsung Electronics CO.LTD Cualquier acceso ilegal será castigado con la ley correspondiente !! " + '\n' + "Estimados Usuarios, Nunca le enviaremos ningún correo electrónico solicitando su cuenta y / o  contraseña." + '\n' + " Por lo tanto, se le pide que no tenga acceso o responda a cualquier sitio sospechoso(parecido a G - SPN) o correo electrónico a partir de ahora. Si tiene alguna experiencia para acceder al sitio anterior comentado, haga clic en el botón de Cancelar, a continuación." + '\n' + " - Casos de sitios de suplantación de identidad de: www.samsungcsportal.com o gspn3.samsungscportal.com"+'\n'+" - Casos de un e - mail: gspn@samsungcsportal.com Gracias. "+'\n'+"◈ Registro de acceso más reciente de: " + nombre + " ◈ " + '\n' + DateTime.Now.ToString()+'\n'+"SISTEMA SÓLO CON PROPOSITO DE ENTRENAMIENTO A PERSONAL DE TECHLAB");
                if(textBox2.Text.ToString() == "ENTRENADOR" || textBox2.Text.ToString() == "ENTRENADOR1")
                {
                    new FormAdministradores().Show();
                    this.Hide();
                }
                else
                {
                    new Form2().Show();
                    this.Hide();
                }
                
            }

            if (i == 3)
            {
                MessageBox.Show("Error haz fallado en tres intentos cuenta BLOQUEADA");
                this.Close();

            }
            

        }

    
        }
}
