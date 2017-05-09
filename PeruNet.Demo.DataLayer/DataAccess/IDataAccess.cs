using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.DataLayer.DataAccess
{
    public interface IDataAccess
    {
        void ExecuteNonQuery(string nomnbreSP, dynamic parametros);

        List<T> ExecuteReader<T>(string nomnbreSP, dynamic parametros);

    }
}
