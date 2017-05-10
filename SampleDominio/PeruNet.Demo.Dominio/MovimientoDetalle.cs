using System;
using System.Collections.Generic;
using System.Text;

namespace PeruNet.Demo.Dominio
{
  public class MovimientoDetalle
  {
    public virtual int Id { get; set; }
    public virtual Producto Producto { get; set; }
    public virtual decimal Cantidad { get; set; }
    public virtual decimal Precio { get; set; }
    public virtual Movimiento Cabecera { get; set; }
  }
}
