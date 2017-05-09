using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.Logging
{
    public class LogManager
    {
        public static void RegistrarLog(Exception ex) {
            Debug.Write("Se ha producido un error. ERROR: {0}", ex.Message + " - " + ex.StackTrace);
        }
    }
}
