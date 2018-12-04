using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApp1
{
    class Acciones
    {
        String nombre, password;
        int ver;

        public int validacionUsuario(String user, String pass)
        {
            conexcion_base_de_datos conexcion = new conexcion_base_de_datos();
            DataTable dataRow = conexcion.conexionBase("SELECT * FROM Engineer  where Usuario = '" + user + "';");
            //Presentación de la tabla
            foreach (DataRow dtRow in dataRow.Rows)
            {
                nombre = dtRow["Usuario"].ToString();
                password = dtRow["Password"].ToString();
                //this is only a comment
            }
            if (nombre == user && password == pass)
            {
                return 1;

            }
            return 0;

        }

        public string consultaNombre(String user, String pass)
        {
            conexcion_base_de_datos conexcion = new conexcion_base_de_datos();
            DataTable dataRow = conexcion.conexionBase("SELECT Nombre, Apellido FROM Engineer  where Usuario = '" + user + "' AND Password ='" + pass + "';");
            //Presentación de la tabla
            foreach (DataRow dtRow in dataRow.Rows)
            {
                nombre = dtRow["Nombre"].ToString() + " " + dtRow["Apellido"].ToString();
            }

            return nombre;

        }

        public void AgregarUsuario()
        {
            conexcion_base_de_datos conexion = new conexcion_base_de_datos();
            conexion.conexionBaseInsert("INSERT INTO Engineer VALUES (4, 'Benjamin', 'TechLab', 'CAPACITACION', 2, 'ENTRENADOR1')");

        }

        public void AgregarUsuarioInteractivo(string id, string nombre, string apellido, string password, string idCSA, string usuario)
        {

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(idCSA) || string.IsNullOrEmpty(usuario))
            {
                System.Windows.Forms.MessageBox.Show("No haz llenado los campos completos vuelve a intentarlo");
            }
            else
            {
                conexcion_base_de_datos conexion = new conexcion_base_de_datos();
                //validacion que no existe ya el registro
                DataTable dataSet = conexion.conexionBase("SELECT Usuario, Id FROM Engineer WHERE Usuario = '" + usuario + "' OR Id =" + id + ";");


                foreach (DataRow datRow in dataSet.Rows)
                {
                    nombre = datRow["Usuario"].ToString();
                    ver = Int32.Parse(datRow["Id"].ToString());
                    // System.Windows.Forms.MessageBox.Show(datRow["Usuario"].ToString()+ver);
                }

                if (usuario == nombre || Int32.Parse(id) == ver)
                {
                    System.Windows.Forms.MessageBox.Show("El registro ya existe, Id o Usuario no validos intentalo otra vez");

                }
                else
                {
                    //INSTER DE NUEVO REGISTRO
                    conexion.conexionBaseInsert("INSERT INTO Engineer VALUES (" + id + ", '" + nombre + "', '" + apellido + "', '" + password + "'," + idCSA + " , '" + usuario + "')");

                }
            }
        }

        public DataSet consultarUsuarios(string tabla)
        {
            conexcion_base_de_datos conexcion = new conexcion_base_de_datos();
            DataSet dataSet = conexcion.consultaGeneral("SELECT * FROM " + tabla + "", tabla);
            //Presentación de la tabla

            return dataSet;
        } 

        public void AgregarCSAInteractivo(string id, string nombreCSA, string tipoCSA)
        {

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nombreCSA) || string.IsNullOrEmpty(tipoCSA))
            {
                System.Windows.Forms.MessageBox.Show("No haz llenado los campos completos vuelve a intentarlo");
            }
            else
            {
                conexcion_base_de_datos conexion = new conexcion_base_de_datos();
                //validacion que no existe ya el registro
                DataTable dataSet = conexion.conexionBase("SELECT NombreCSA, Id FROM CSA WHERE NombreCSA = '" + nombreCSA + "' OR Id =" + id + ";");


                foreach (DataRow datRow in dataSet.Rows)
                {
                    nombre = datRow["Nombre CSA"].ToString();
                    ver = Int32.Parse(datRow["Id"].ToString());
                    // System.Windows.Forms.MessageBox.Show(datRow["Usuario"].ToString()+ver);
                }

                if (nombreCSA == nombre || Int32.Parse(id) == ver)
                {
                    System.Windows.Forms.MessageBox.Show("El registro ya existe, Id o Usuario no validos intentalo otra vez");

                }
                else
                {
                    //INSTER DE NUEVO REGISTRO
                    conexion.conexionBaseInsert("INSERT INTO CSA VALUES (" + id + ", '" + nombreCSA + "','" + tipoCSA + "')");

                }
            }
        }

        public void borrarUsuario(string idBorrar)
        {
            conexcion_base_de_datos conexion = new conexcion_base_de_datos();
            conexion.conexionBaseInsert("DELETE FROM Engineer WHERE Id = (" + idBorrar + ")");

        }
    }
}
