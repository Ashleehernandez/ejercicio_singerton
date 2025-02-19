
namespace CapaEntida


{
    public class Entidades
    {
       public string Nombre;
       public  string Apellido;
       public string Edad;
       public  string Telefono;

        public Entidades(string nombre , string apellido , string edad, string telefono)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Telefono = telefono;

            
        }

        public virtual void TipodeUsuario()
        {


        }


    }
}
