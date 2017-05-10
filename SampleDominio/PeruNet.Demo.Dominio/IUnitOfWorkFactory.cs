using System;
using System.Collections.Generic;
using System.Text;

namespace PeruNet.Demo.Dominio
{
  public interface IUnitOfWorkFactory
  {
    IUnitOfWork Crear();
  }
}
