using Castle.MicroKernel.Registration;
using Castle.Windsor;
using NHibernate;
using PeruNet.Demo.Aplicacion;
using PeruNet.Demo.Dominio;
using PeruNet.Demo.Persistencia.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.Config
{
  public static class Dependencias
  {
    public static IWindsorContainer ConfigApp(this IWindsorContainer container, ISessionFactory sessionFactory)
    {
      container.Register(Component.For<ISessionFactory>().Instance(sessionFactory));
      container.Register(Component.For<IUnitOfWork>().ImplementedBy<UnitOfWork>().LifestyleTransient());
      container.Register(Component.For<IUnitOfWorkFactory>().ImplementedBy<UnitOfWorkFactory>().LifestyleTransient());
      container.Register(Component.For<IInventarioService>().ImplementedBy<InventarioService>().LifestyleTransient());

      return container;
    }
  }
}
