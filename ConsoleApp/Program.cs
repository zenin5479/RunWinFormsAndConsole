using System;
using System.IO;
using System.Threading;

namespace ConsoleApp
{
   class Program
   {
      static void Main()
      {
         //string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "console_debug.log");

         //// Пишем всё, что происходит, в файл на рабочем столе
         //File.AppendAllText(logPath, string.Format("[{0}] Запуск консоли...\n", DateTime.Now));

         try
         {
            // Гарантированно держим окно открытым несколько секунд
            Console.Title = "ДИАГНОСТИКА – НЕ ЗАКРЫВАТЬ";
            Console.WriteLine("Консоль запущена и будет ждать 5 секунд.");
            //File.AppendAllText(logPath, "Консоль запущена успешно.\n");

            // Даже если дальше будет исключение, окно останется открытым из-за задержки
            Thread.Sleep(5000); // 5 секунд

            // Только после этого ждём нажатия клавиши
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
            //File.AppendAllText(logPath, "Программа завершена нормально.\n");
         }
         catch
         {
            //File.AppendAllText(logPath, string.Format("ОШИБКА: {0}\n", ex));
            Console.WriteLine("Произошла ошибка! Подробности в файле на рабочем столе.");
            Console.ReadKey(); // окно не закроется
         }
      }
   }
}