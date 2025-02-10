using LogConsole.Storage;

namespace LogConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"..", @"Logs");
            ILogStorage fileStorage = new FileLogStorage(logPath);
            Logger logger = new Logger(fileStorage);

            logger.LogInfo("El sistema inició correctamente.");
            logger.LogWarning("Se detectó una posible inconsistencia.");
            logger.LogError("Error al conectarse a la base de datos.");

            Console.WriteLine("Logs generados en: " + logPath);
            Console.ReadKey();

            Console.WriteLine("\nPresiona cualquier tecla...");
            Console.ReadKey();

        }
    }
}
