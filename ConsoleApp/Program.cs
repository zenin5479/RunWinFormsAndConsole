using System;
using System.IO;
using System.Threading;

namespace ConsoleApp
{
   class Program
   {
      static void Main(string[] args)
      {
         string logPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "console_debug.log");

         // Пишем всё, что происходит, в файл на рабочем столе
         File.AppendAllText(logPath, $"[{DateTime.Now}] Запуск консоли...\n");

         try
         {
            // Гарантированно держим окно открытым несколько секунд
            Console.Title = "ДИАГНОСТИКА – НЕ ЗАКРЫВАТЬ";
            Console.WriteLine("Консоль запущена и будет ждать 5 секунд.");
            File.AppendAllText(logPath, "Консоль запущена успешно.\n");

            // Даже если дальше будет исключение, окно останется открытым из-за задержки
            Thread.Sleep(5000); // 5 секунд

            // Только после этого ждём нажатия клавиши
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
            File.AppendAllText(logPath, "Программа завершена нормально.\n");
         }
         catch (Exception ex)
         {
            File.AppendAllText(logPath, $"ОШИБКА: {ex}\n");
            Console.WriteLine("Произошла ошибка! Подробности в файле на рабочем столе.");
            Console.ReadKey(); // окно не закроется
         }
      }
   }
}