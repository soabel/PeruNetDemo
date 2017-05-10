using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using PeruNet.Demo.Aplicacion;
using PeruNet.Demo.Dominio;
using PeruNet.Demo.Persistencia.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.Consola
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Inicializando Database");
      var sessionFactory = CreateSessionFactory();
      CrearDatabase(sessionFactory);
      CrearData(sessionFactory);

      Console.WriteLine("Iniciando Registro Ingreso");
      var uowFactory = new UnitOfWorkFactory(sessionFactory);
      var service = new InventarioService(uowFactory);
      service.RegistrarIngreso(1, new IngresoDto
      {
        Ruc = "12345678901",
        Proveedor = "Proveedor",
        Fecha = DateTime.Today,
        Detalles = new List<IngresoDetalleDto>
        {
          new IngresoDetalleDto{ IdProducto = 1, Cantidad = 200, Precio = 24.1m },
          new IngresoDetalleDto{ IdProducto = 2, Cantidad = 700, Precio = 2.41m }
        }
      });
      Console.WriteLine("Terminado...");

      Console.ReadLine();
    }

    static Configuration _configuration;

    static ISessionFactory CreateSessionFactory()
    {
      var cfg = _configuration = new Configuration();
      cfg.DataBaseIntegration(db =>
      {
        db.ConnectionString = "Data Source=nhibernate.db;Version=3";
        db.Dialect<SQLiteDialect>();
        db.Driver<SQLite20Driver>();
      });
      var mapper = new ModelMapper();
      mapper.AddMappings(Assembly.Load("PeruNet.Demo.Persistencia.NHibernate").GetExportedTypes());
      cfg.AddDeserializedMapping(mapper.CompileMappingForAllExplicitlyAddedEntities(), "NHAlmacen");
      return cfg.BuildSessionFactory();
    }

    static void CrearDatabase(ISessionFactory sessionFactory)
    {
      using (var session = sessionFactory.OpenSession())
      {
        var export = new SchemaExport(_configuration);
        export.Execute(true, true, false, session.Connection, null);
      }
    }

    static void CrearData(ISessionFactory sessionFactory)
    {
      using(var session = sessionFactory.OpenSession())
      {
        session.Save(new Almacen
        {
          Descripcion = "Principal"
        });

        session.Save(new Producto
        {
          Descripcion = "Producto 1",
          Stock = 100
        });
        session.Save(new Producto
        {
          Descripcion = "Producto 2",
          Stock = 0
        });

        session.Flush();
      }
    }
  }
}
