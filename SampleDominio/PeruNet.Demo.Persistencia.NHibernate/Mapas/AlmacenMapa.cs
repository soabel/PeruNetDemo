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
  public class AlmacenMapa: ClassMapping<Almacen>
  {
    public AlmacenMapa()
    {
      Id(c => c.Id, a => a.Generator(Generators.Identity));
      Property(c => c.Descripcion, a => a.Length(250));
      Bag(c => c.Movimientos, m =>
      {
        m.Key(k => k.Column("IdAlmacen"));
        m.Cascade(Cascade.All);
      }, a => a.OneToMany());
    }
  }
}
