using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         // При загрузке формы сразу запускаем консольное приложение
         //StartConsoleApp();
      }

      // Пример: кнопка для повторного запуска (на форме есть Button button1)
      private void button1_Click(object sender, EventArgs e)
      {
         StartConsoleApp();   // запуск только по кнопке
      }

      private void StartConsoleApp()
      {
         string folder = AppDomain.CurrentDomain.BaseDirectory;
         string consoleAppPath = Path.Combine(folder, "ConsoleApp.exe");

         // Проверка на всякий случай (можно оставить без MessageBox)
         if (!File.Exists(consoleAppPath))
         {
            MessageBox.Show($"Файл не найден:\n{consoleAppPath}", "Ошибка");
            return;
         }

         try
         {
            Process process = new Process();
            process.StartInfo.FileName = consoleAppPath;
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Ошибка при запуске:\n{ex.Message}", "Ошибка");
         }
      }
   }
}
