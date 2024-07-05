using System;
using System.Data.SqlClient;
using sqlServer.Datos;
namespace sqlServer;

class Program{
    static void Main()
    {
        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource="localhost";
            builder.UserID="sa";
            builder.Password="TuPasswordSeguro123!";
            builder.InitialCatalog="sqlServer";
            builder.Encrypt=false;
            using(Contexto context = new Contexto(builder.ConnectionString)){
                context.Database.EnsureCreated();            
                Console.WriteLine("Conectado al server");

                Console.WriteLine("listar categorias");
            }
            
        }
        catch (Exception e)
        {
            
           Console.WriteLine(e.ToString()) ;
        }
    }
}
