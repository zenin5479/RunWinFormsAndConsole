using System;
using System.IO;
using System.Threading;

namespace ConsoleApp
{
   class Program
   {
      static void Main()
      {
         string folder = AppDomain.CurrentDomain.BaseDirectory;
         if (folder != null)
         {
            string logPath = Path.Combine(folder, "console_debug.log");
            // Пишем что происходит в файл
            File.AppendAllText(logPath, string.Format("[{0}] Запуск консоли...\n", DateTime.Now));

            try
            {
               // Гарантированно держим окно открытым несколько секунд
               Console.Title = "ДИАГНОСТИКА – НЕ ЗАКРЫВАТЬ";
               Console.WriteLine("Консоль запущена и будет ждать 5 секунд");
               File.AppendAllText(logPath, "Консоль запущена успешно\n");

               // Даже если дальше будет исключение, окно останется открытым из-за задержки
               Thread.Sleep(5000);

               // Только после этого ждём нажатия клавиши
               Console.WriteLine("Нажмите любую клавишу для выхода...");
               Console.ReadKey();
               File.AppendAllText(logPath, "Программа завершена нормально\n");
            }
            catch (Exception ex)
            {
               File.AppendAllText(logPath, string.Format("ОШИБКА: {0}\n", ex));
               Console.WriteLine("Произошла ошибка! Подробности в файле console_debug.log");
               // Окно не закроется
               Console.ReadKey();
            }
         }
      }
   }
}