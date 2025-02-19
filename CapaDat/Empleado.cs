using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntida;

namespace CapaDat
{
    public class Empleado : Entidades 
    {
        public Empleado(string nombre, string apellido, string edad, string telefono) : base(nombre, apellido, edad, telefono)
        {

        }

        public Empleado():base("","","","")
        {
            
        }

        public bool AgregarEmpleados(string nombre, string apellido, string edad, string telefono)
        {
            Console.WriteLine("ingrese el nombre del empleado ");
            nombre = Console.ReadLine()!;

            if (string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("el campo de nombre esta basio");
            }
            else
            {
                Console.WriteLine("nombre guardado ");

            }

            ////////////////////////////////////////////////
            ///
            Console.WriteLine("ingrese el apellido del empleado ");
            apellido = Console.ReadLine()!;

            if (!string.IsNullOrEmpty(apellido))
            {
                Console.WriteLine("El campo de apellido esta basio ");

            }
            else
            {
                Console.WriteLine("apellido guardado ");
            }
            /////////////////////////////////////////////////

            Console.WriteLine("ingrese la edad del empleado ");
            edad = Console.ReadLine()!;

            if (string.IsNullOrEmpty(edad))
            {
                Console.WriteLine("el campo de edad esta basio ");
            }
            else
            {
                Console.WriteLine("edad guardada ");
            }

            /////////////////////////////////////////////////////////
            ///
            Console.WriteLine("ingrese el numero de telefono ");
            telefono = Console.ReadLine()!;

            if(string.IsNullOrEmpty(telefono)){
                Console.WriteLine("el campo de telefono esta basio ");

            }
            else
            {
                Console.WriteLine("telefono guardado ");
            }


            string query = $"INSERT INTO EMPLEADOS (nombre , apellido , edad , telefono ) VALUES ('{nombre}' , '{apellido}','{edad}','{telefono}')";


            using (SqlConnection connection = Connecion.getconnection())
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query,connection);

                var resul = cmd.ExecuteNonQuery();

                if (resul > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


         
            }
           

            



        }
        public override void TipodeUsuario()
        {
            Console.WriteLine("soy un empleado ");
        }

        
    }
}
