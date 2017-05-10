using NHibernate;
using PeruNet.Demo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.Persistencia.NHibernate
{
  public class UnitOfWorkFactory : IUnitOfWorkFactory
  {
    private ISessionFactory _sessionFactory;

    public UnitOfWorkFactory(ISessionFactory sessionFactory)
    {
      _sessionFactory = sessionFactory;
    }

    public IUnitOfWork Crear()
    {
      return new UnitOfWork(_sessionFactory);
    }
  }
}
