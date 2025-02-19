using CapaEntida;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;





namespace CapaDat
{
    public class Provedor : Entidades


    {
        
        public Provedor(string nombre, string apellido, string edad, string telefono) : base(nombre, apellido, edad, telefono)
        {

        }
        public Provedor():base("", "", "", "" )
        {

        }


        public bool RegistrarProveedor(string nombre, string apellido, string edad, string telefono)
        {
            
            
                Console.WriteLine("Ingrese el nombre del provedor");
                nombre = Console.ReadLine()!;

                if (string.IsNullOrEmpty(nombre))
                {
                    Console.WriteLine("La cadena esta basia ");
                
                }
                else
                {
                    Console.WriteLine("Nombre guardado ");
                }



                ////////////////////////////////////////////
                ///
                Console.WriteLine("ingrese el apellido ");
                apellido = Console.ReadLine()!;

                if (string.IsNullOrEmpty(apellido))
                {
                    Console.WriteLine(" la cadena esta basia ");
                }
                else
                {
                    Console.WriteLine("Apellido guardado ");
                }
                ///////////////////////////////////////////////
                ///

                Console.WriteLine("ingrese la edad de la empresa ");
                edad = Console.ReadLine()!;

                if (string.IsNullOrEmpty(edad))
                {
                    Console.WriteLine("la cadena esta basia ");
                }
                else
                {
                    Console.WriteLine("Edad guardada ");
                }



                /////////////////////////////////////////
                ///
                Console.WriteLine("ingrese numero de telefono ");
                telefono = Console.ReadLine()!;

                if (string.IsNullOrEmpty(telefono))
                {
                    Console.WriteLine("la cadena esta basia ");
                }
                else
                {
                    Console.WriteLine("Telefono guardado ");
                }

                string query = $"INSERT INTO PROVEDOR (nombre , apellido , edad , telefono ) VALUES ('{nombre}' ,'{apellido}', '{edad}', '{telefono}')";

                using (SqlConnection connection = Connecion.getconnection())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(query,connection);

                    var resulado = cmd.ExecuteNonQuery();

                    if(resulado > 0)
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
            Console.WriteLine("soy un provedor ");
        }

        
    }
}


