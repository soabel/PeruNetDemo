using System;
using System.Collections.Generic;
using System.Text;

namespace PeruNet.Demo.Dominio
{
  public class Producto
  {
    public virtual int Id { get; set; }
    public virtual string Descripcion { get; set; }
    public virtual decimal Stock { get; set; }

    public virtual void AumentarStock(decimal cantidad)
    {
      Stock += cantidad;
    }
  }
}
