using PeruNet.Demo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.Aplicacion
{
  public static class IngresoMapper
  {
    public static Movimiento CrearMovimiento(this IngresoDto ingreso, IUnitOfWork uow)
    {
      var movimiento = new Movimiento
      {
        Ruc = ingreso.Ruc,
        Proveedor = ingreso.Proveedor,
        Fecha = ingreso.Fecha,
      };
      foreach (var item in ingreso.Detalles)
      {
        movimiento.AgregarDetalle(uow.Get<Producto>(item.IdProducto), item.Cantidad, item.Precio);
      }
      return movimiento;
    }
  }
}
