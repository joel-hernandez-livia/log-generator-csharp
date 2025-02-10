using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogConsole.Storage
{
    internal interface ILogStorage
    {
        void WriteLog(string message);
    }
}
