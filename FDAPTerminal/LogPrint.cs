using FDAP;

namespace FDAPTerminal
{
    public class LogPrint
    {
        public static void PrintLogs(Logs logs)
        {
            foreach (var log in logs.Log)
            {
                if (log.Key == DateTime.MinValue)
                {
                    Console.WriteLine($"[No Timestamp] {log.Value}");
                }
                else
                {
                    Console.WriteLine($"[{log.Key}] {log.Value}");
                }
            }
        }
    }
}
