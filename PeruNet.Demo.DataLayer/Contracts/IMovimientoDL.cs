using PeruNet.Demo.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.DataLayer.Contracts
{
    public interface IMovimientoDL
    {
        void RegistrarIngreso(MovimientoBE ingreso);
        void RegistrarSalida(MovimientoBE salida);

    }
}
