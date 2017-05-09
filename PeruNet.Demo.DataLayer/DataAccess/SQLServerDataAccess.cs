using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.DataLayer.DataAccess
{
    public class SQLServerDataAccess : IDataAccess
    {
        public void ExecuteNonQuery(string nomnbreSP, dynamic parametros)
        {
            //Ejecutar SP
            //throw new NotImplementedException();
        }

        public List<T> ExecuteReader<T>(string nomnbreSP, dynamic parametros)
        {
            return null;
        }
    }
}
