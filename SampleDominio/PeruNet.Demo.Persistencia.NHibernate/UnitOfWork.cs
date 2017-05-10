using NHibernate;
using PeruNet.Demo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.Persistencia.NHibernate
{
  public class UnitOfWork: IUnitOfWork
  {
    private ISession _session;

    public UnitOfWork(ISessionFactory sessionFactory)
    {
      _session = sessionFactory.OpenSession();
    }

    public void Complete()
    {
      _session.Flush();
    }

    public TEntidad Get<TEntidad>(int id) where TEntidad : class
    {
      return _session.Get<TEntidad>(id);
    }

    public void Dispose()
    {
      _session.Dispose();
    }
  }
}
