
using Microsoft.Data.SqlClient;
using CapaEntida;
using CapaDat;

namespace CapaSingth
{
    public sealed class Administrador : Entidades
    {
        private string Name;
        private string Post ;
        private string Career;

        private Administrador(string name , string post , string carrer, string nombre, string apellido, string edad, string telfono):base(nombre,apellido,edad,telfono)
        {
            this.Name = name;
            this.Post = post;
            this.Career = carrer;
 
        }

        public Administrador():base("","","","")
        {
            
        }


        public bool RegistrarAdmin(string nombre , string apellido , string edad , string telfono )
        {

            Console.WriteLine("Ingrese el nombre del admin");
            nombre = Console.ReadLine()!;

            if (string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("El campo de nombre esta basio ");

            }
            else
            {
                Console.WriteLine("el nombre Del admin Se guardo correctamente ");
            }


            /////////////////////////////////////////////////////////////
            //

            Console.WriteLine("Ingrese el apellido del admin");
            apellido = Console.ReadLine()!;

            if (string.IsNullOrEmpty(apellido))
            {
                Console.WriteLine("El campo de apellido esta basio");
            }
            else
            {
                Console.WriteLine("El apellido se guardo correctamente ");
            }

            //////////////////////////////////////////////////////////////////
            ///

            Console.WriteLine("Ingrese la edad del admin");
            edad =Console.ReadLine()!;

            if (string.IsNullOrEmpty(edad))
            {
                Console.WriteLine("El campo de edad esta basio ");
            }
            else
            {
                Console.WriteLine("La edad del admin se guardo ");
            }


            //////////////////////////////////////////////////////////////////
            ///

            Console.WriteLine("Ingresame el telefono del admin ");
            telfono = Console.ReadLine()!;

            if (string.IsNullOrEmpty(telfono))
            {
                Console.WriteLine("El campo de telefono esta basio ");
            }
            else
            {
                Console.WriteLine("El telefono se guardo ");
            }


            string query = $"INSERT INT ADMINISTRADOR (nombre , apellido , edad , telefono )VALUES ('{nombre}', '{apellido}' , '{edad}', '{telfono}')";

            using (SqlConnection connection = Connecion.getconnection())
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);


                var resul = cmd.ExecuteNonQuery();

                if(resul > 0)
                {
                    return true;
                }
                else
                {
                  return false;
                }




            }



        }




    }
}
