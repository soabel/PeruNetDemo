using System;
using System.Collections.Generic;

namespace PeruNet.Demo.Dominio
{
  public class Almacen
  {
    public Almacen()
    {
      Movimientos = new List<Movimiento>();
    }

    public virtual int Id { get; set; }
    public virtual string Descripcion { get; set; }
    public virtual IList<Movimiento> Movimientos { get; set; }

    public virtual void RegistrarIngreso(Movimiento movimiento)
    {
      movimiento.Almacen = this;
      Movimientos.Add(movimiento);
      foreach (var item in movimiento.Detalles)
      {
        item.Producto.AumentarStock(item.Cantidad);
      }
    }
  }
}
