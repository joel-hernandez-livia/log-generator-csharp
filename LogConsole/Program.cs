namespace LogConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Un programa\n");
            //Log log = new Log(@"C:\Users\JOEL\source\repos\LogConsoleSol\LogConsole\Log");
            //string relativePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
            string relativePath = @".\Log";
            Log log = new Log(relativePath);
            log.Add("Prueba 2");

            Console.WriteLine("\nPresiona cualquier tecla...");
            Console.ReadKey();
        }
    }
}
