using System;
using System.Diagnostics;
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
         StartConsoleApp();
      }

      // Пример: кнопка для повторного запуска (на форме есть Button button1)
      private void button1_Click(object sender, EventArgs e)
      {
         StartConsoleApp();
      }

      private void StartConsoleApp()
      {
         try
         {
            // Укажите правильный путь к скомпилированному .exe консольного приложения
            string consoleAppPath = @"..\..\..\..\ConsoleApp\bin\Debug\netcoreapp3.1\ConsoleApp.exe";

            Process process = new Process();
            process.StartInfo.FileName = consoleAppPath;
            process.StartInfo.UseShellExecute = true;   // открыть в отдельном окне
            process.StartInfo.CreateNoWindow = false;   // показывать окно консоли
            process.Start();
         }
         catch (Exception ex)
         {
            MessageBox.Show("Не удалось запустить консоль: " + ex.Message);
         }
      }
   }
}
