using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntida;

namespace CapaDat
{
    public class Cliente : Entidades 
    {
        public Cliente(string nombre, string apellido, string edad, string telefono) : base(nombre, apellido, edad, telefono)
        {

        }

        public Cliente():base("","","","")
        {
            
        }


        public bool Agregarclientes(string nombre, string apellido, string edad, string telefono)
        {
            Console.WriteLine("ingrese el nombre del cliente ");
            nombre = Console.ReadLine()!;

            if (string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("El campo de ingresar nombre del cliente lo dejo basio ");

            }
            else
            {
                Console.WriteLine("nombre del cliente guardado ");
            }

            /// /////////////////////////////////////////////////////////////////////
            Console.WriteLine("ingrese el apellido del cliente ");
            apellido = Console.ReadLine()!;


            if (string.IsNullOrEmpty(apellido))
            {
                Console.WriteLine("el campo de ingresar apellido del cliente lo dejo basio ");

            }
            else
            {
                Console.WriteLine("apellido del cliente guardado");
            }

            /// /////////////////////////////////////////////////////////////////////

            Console.WriteLine("ingrese  la edad del cliente ");
            edad = Console.ReadLine()!;

            if (string.IsNullOrEmpty(edad))
            {
                Console.WriteLine("el campo del nombre lo dejo basio ");
            }
            else
            {
                Console.WriteLine("edad del cliente guardado ");
            }

            /// /////////////////////////////////////////////////////////////////////

            Console.WriteLine("ingresa el telefono del cliente ");
            telefono = Console.ReadLine()!;

            if (string.IsNullOrEmpty(telefono))
            {
                Console.WriteLine("el campo de telefono esta basio ");
            }
            else
            {
                Console.WriteLine("el telefono del cliente se guardo ");
            }

            string query = $"INSERT INTO CLIENTE (nombre , apellido , edad , telefono )VALUES('{nombre}','{apellido}','{edad}','{telefono}')";

            using (SqlConnection connection = Connecion.getconnection())
            {
               connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                var relaul= cmd.ExecuteNonQuery();

                if(relaul > 0)
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
            Console.WriteLine("soy un cliente ");
        }


    }
}