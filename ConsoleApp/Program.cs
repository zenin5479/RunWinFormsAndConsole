using System;
using System.Diagnostics;      // обязательно добавить
using System.Threading;

namespace ConsoleApp
{
   class Program
   {
      static void Main(string[] args)
      {
         // Используем Process.GetCurrentProcess().Id вместо Environment.ProcessId
         int pid = Process.GetCurrentProcess().Id;
         Console.WriteLine($"Консольное приложение запущено. PID: {pid}");

         for (int i = 1; i <= 10; i++)
         {
            Console.WriteLine($"Сообщение из консоли: {i}");
            Thread.Sleep(1000);
         }

         Console.WriteLine("Консоль завершает работу. Нажмите любую клавишу...");
         Console.ReadKey();
      }
   }
}