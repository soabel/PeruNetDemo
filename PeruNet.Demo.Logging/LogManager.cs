using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.Logging
{
    public class LogManager: ILogManager
    {
        public void Error(Exception exception)
        {
            Debug.Write("Se ha producido un error. ERROR: {0}", exception.Message + " - " + exception.StackTrace);
        }

        public void Log(string mensaje)
        {
            Debug.Write(mensaje);
        }
        
    }
}
