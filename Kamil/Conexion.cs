using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Coppel
{
    public class Conexion
    {
        //Cadena de Conexion
        string cadena = "data source = DESKTOP-T56F8FG; initial catalog = Kamil; Integrated Security= True";

        public SqlConnection Conectarbd = new SqlConnection();

        //Constructor
        public Conexion()
        {
            Conectarbd.ConnectionString = cadena;
        }

        //Metodo para abrir la conexion
        public void open()
        {
            try
            {
                Conectarbd.Open();
                Console.WriteLine("conectado ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void close()
        {
            Conectarbd.Close();
        }
    }
}
