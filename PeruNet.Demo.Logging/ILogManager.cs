using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.Logging
{
    public interface ILogManager
    {
        void Log(string mensaje);
        void Error(Exception exception);
    }
}
