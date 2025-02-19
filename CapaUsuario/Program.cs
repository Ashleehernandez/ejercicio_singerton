using CapaDat;
using CapaSingth;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaUsuario
{
    internal class Program
    {
        private static string nombre;
        private static string apellido;
        private static string edad;
        private static string telefono;

        static void Main(string[] args)
        {
            int opcion;

            Provedor provedor = new Provedor();
            Empleado empleado = new Empleado();
            Cliente cliente = new Cliente();
            Administrador admin = new Administrador();

            do
            {
                Console.WriteLine("Elija lo que desea realizar  ");
                Console.WriteLine("\n1 Crear provedor ");
                Console.WriteLine("\n2 Crear  empleados");
                Console.WriteLine("\n3 Crear cliente ");
                Console.WriteLine("\n4 Crear Administrador");
                Console.WriteLine("\n5 Ver usuarios ");

                opcion = int.Parse(Console.ReadLine()!);


                switch (opcion)
                {
                    case 1:

                        provedor.RegistrarProveedor(nombre, apellido, edad, telefono);

                        break;

                        case 2:
                        empleado.AgregarEmpleados(nombre,apellido, edad, telefono);

                        break;

                        case 3:
                        cliente.Agregarclientes(nombre, apellido, edad, telefono);

                        break;

                        case 4: 
                           admin.RegistrarAdmin(nombre , apellido, edad, telefono);

                        break;

                        case 5:
                          

                        break;

                       default:
                        Console.WriteLine("Deve de elejir una opcion del 1 al 5 ");
                        break;

                }

            }while (true);

        }
    }
}
