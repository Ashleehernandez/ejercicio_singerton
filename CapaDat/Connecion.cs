using Microsoft.Data.SqlClient;

namespace CapaDat
{
    public class Connecion
    {
         static string Connexion = "Data Source=DESKTOP-VVPHGA7\\SQLEXPRESS;Initial Catalog=TipoUsuario;User ID=DESKTOP-VVPHGA7\\ashle;Password=; Trusted_Connection = True; TrustServerCertificate = True;";

        public static SqlConnection getconnection()
        {
            return new SqlConnection(Connexion);
        }
    }
}
