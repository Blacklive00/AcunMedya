using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.IO;

namespace KafeOtomasyon.BLL.Logging
{
    public static class FileLogger
    {
        // Log dosyası konumu (uygulama çalıştığı dizin)
        private static readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs.txt");

        // Minimum log seviyesi (bu seviyeden altı loglanmaz)
        public static LogLevel MinimumLogLevel { get; set; } = LogLevel.DEBUG;

        // Genel log metodu
        public static void Log(string message, LogLevel level, Exception ex = null)
        {
            if (level < MinimumLogLevel)
                return;

            try
            {
                using StreamWriter sw = new StreamWriter(logFilePath, true);
                sw.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}");
                if (ex != null)
                {
                    sw.WriteLine($"Exception: {ex.Message}");
                    sw.WriteLine(ex.StackTrace);
                }
                sw.WriteLine(new string('-', 50));
            }
            catch
            {
                // Log dosyasına yazarken hata olursa uygulama etkilenmesin diye boş bırakıyoruz
            }
        }

        // Kolay kullanım için seviyeye özel metotlar
        public static void Debug(string message) => Log(message, LogLevel.DEBUG);
        public static void Info(string message) => Log(message, LogLevel.INFO);
        public static void Warn(string message) => Log(message, LogLevel.WARN);
        public static void Error(string message, Exception ex = null) => Log(message, LogLevel.ERROR, ex);
    }
}


namespace KafeOtomasyon.BLL.Logging
{
    public enum LogLevel
    {
        DEBUG,
        INFO,
        WARN,
        ERROR
    }
}
