using System;
using System.Data.SqlClient;
using sqlServer.Datos;
using sqlServer.Models;

try
{
    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
    builder.DataSource = "localhost";
    builder.UserID = "sa";
    builder.Password = "TuPasswordSeguro123!";
    builder.InitialCatalog = "sqlServer";
    builder.Encrypt = false;
    using (Contexto context = new Contexto(builder.ConnectionString))
    {
        context.Database.EnsureCreated();
        Console.WriteLine("Conectado al server");

        // Console.WriteLine("Crear categorías");
        // Categoria categoria=new Categoria{ Nombre="Categoria 3", Slug="categoria-4"};
        // context.Categorias.Add(categoria);
        // context.SaveChanges();

        // Console.WriteLine("Editar categorías");
        // Categoria categoriaUpdate = context.Categorias.Find(3);
        // categoriaUpdate.Nombre = "categoria 3 update";
        // categoriaUpdate.Slug = "categoria-3 update";
        // context.SaveChanges();

        //  Console.WriteLine("Elimar categorías");
        //  Categoria categoriaDelete = context.Categorias.Find(3);
        //  context.Categorias.Attach(categoriaDelete);
        //  context.Categorias.Remove(categoriaDelete);
        //  context.SaveChanges();

        Console.WriteLine("listar categorias");
        var queryl = from c in context.Categorias select c;
        foreach (var c in queryl)
        {
            Console.WriteLine($"id={c.Id} | Nombre: {c.Nombre} | Slug={c.Slug} ");
        }

        //  Console.WriteLine("crear products");
        //  Categoria categoriaInsert = context.Categorias.Find(1);
        //  Producto producto= new Producto{Nombre="bebida de dieta", 
        //                                  Slug = "bebida-de-dieta",
        //                                  Descripcion = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
        //                                  Precio=100,
        //                                  Stock=10,
        //                                  Fecha=DateTime.Now,
        //                                  Categoria=categoriaInsert
        //                                    };
        // context.Productos.Add(producto);
        // context.SaveChanges();

        //  Console.WriteLine("Editar products");
        //  Producto productUpdate = context.Productos.Find(2);
        //  productUpdate.Nombre = "bebida energetica update";
        //  productUpdate.Slug = "bebida-energetica-3 update";
        //  context.SaveChanges();

        //   Console.WriteLine("Elimar products");
        //    Producto productDelete = context.Productos.Find(2);
        //    context.Productos.Attach(productDelete);
        //    context.Productos.Remove(productDelete);
        //    context.SaveChanges();

        Console.WriteLine("listar products");
        var queryP = from p in context.Productos orderby p.Id descending select p;
        foreach (var p in queryP)
        {
            Console.WriteLine($"id={p.Id} | Nombre: {p.Nombre} | Slug={p.Slug} | Descripcion={p.Descripcion}  | Precio: {p.Precio} | Stock={p.Stock} | Fecha={p.Fecha} | Categoria={p.Categoria.Nombre} ");
        }       

        }
}
catch (Exception e)
{

    Console.WriteLine(e.ToString());
}
