using System;
using System.Collections.Generic;
using System.Text;

namespace PeruNet.Demo.Dominio
{
  public interface IUnitOfWork: IDisposable
  {
    TEntidad Get<TEntidad>(int id) where TEntidad : class;
    void Complete();
  }
}
