using PeruNet.Demo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.Aplicacion
{
  public class InventarioService
  {
    private IUnitOfWorkFactory _uowFactory;

    public InventarioService(IUnitOfWorkFactory uowFactory)
    {
      _uowFactory = uowFactory;
    }

    public void RegistrarIngreso(int idAlmacen, IngresoDto ingreso)
    {
      using (var uow = _uowFactory.Crear())
      {
        var almacen = uow.Get<Almacen>(idAlmacen);

        almacen.RegistrarIngreso(ingreso.CrearMovimiento(uow));

        uow.Complete();
      }
    }
  }
}
