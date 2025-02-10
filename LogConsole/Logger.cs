using LogConsole.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogConsole
{
    internal class Logger
    {
        

        private readonly ILogStorage storage;
        public Logger(ILogStorage storage)
        {
            this.storage = storage;
        }

        public void LogInfo(string message) => Log("INFO", message);
        public void LogWarning(string message) => Log("WARNING", message);
        public void LogError(string message) => Log("ERROR", message);

        private void Log(string level, string message)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";
            storage.WriteLog(logEntry);
        }



    }
}
