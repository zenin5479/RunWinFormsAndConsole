using System;
using System.Threading;

namespace ConsoleApp
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Консольное приложение запущено. PID: " + Environment.ProcessId);
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