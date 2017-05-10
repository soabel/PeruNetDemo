using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using PeruNet.Demo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.Persistencia.NHibernate.Mapas
{
  public class MovimientoMapa : ClassMapping<Movimiento>
  {
    public MovimientoMapa()
    {
      Id(c => c.Id, a => a.Generator(Generators.Identity));
      Property(c => c.Ruc, a => a.Length(11));
      Property(c => c.Proveedor, a => a.Length(150));
      Property(c => c.Fecha);
      ManyToOne(c => c.Almacen, a => a.Column("IdAlmacen"));
      Bag(c => c.Detalles, m =>
      {
        m.Key(k => k.Column("IdMovimiento"));
        m.Cascade(Cascade.All);
      }, a => a.OneToMany());
    }
  }
}
