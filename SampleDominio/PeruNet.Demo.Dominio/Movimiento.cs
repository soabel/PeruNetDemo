using System;
using System.Collections.Generic;
using System.Text;

namespace PeruNet.Demo.Dominio
{
  public class Movimiento
  {
    public Movimiento()
    {
      Detalles = new List<MovimientoDetalle>();
    }

    public virtual int Id { get; set; }
    public virtual string Ruc { get; set; }
    public virtual string Proveedor { get; set; }
    public virtual DateTime Fecha { get; set; }
    public virtual Almacen Almacen { get; set; }
    public virtual IList<MovimientoDetalle> Detalles { get; protected set; }

    public virtual void AgregarDetalle(Producto producto, decimal cantidad, decimal precio)
    {
      Detalles.Add(new MovimientoDetalle
      {
        Producto = producto,
        Cantidad = cantidad,
        Precio = precio,
        Cabecera = this
      });
    }
  }
}
