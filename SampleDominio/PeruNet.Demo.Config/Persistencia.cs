using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.Config
{
  public static class Persistencia
  {
    public static ISessionFactory CrearBDEnMemoria(this Configuration cfg)
    {
      cfg.DataBaseIntegration(db =>
      {
        db.ConnectionString = "Data Source=nhibernate.db;Version=3";
        db.Dialect<SQLiteDialect>();
        db.Driver<SQLite20Driver>();
        db.LogSqlInConsole = true;
      });
      var mapper = new ModelMapper();
      mapper.AddMappings(Assembly.Load("PeruNet.Demo.Persistencia.NHibernate").GetExportedTypes());
      cfg.AddDeserializedMapping(mapper.CompileMappingForAllExplicitlyAddedEntities(), "NHAlmacen");
      var sessionFactory = cfg.BuildSessionFactory();

      using (var session = sessionFactory.OpenSession())
      {
        var export = new SchemaExport(cfg);
        export.Execute(true, true, false, session.Connection, null);
      }

      return sessionFactory;
    }
  }
}
