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
            // Берём путь к папке, где лежит наш WinForms.exe
            string folder = AppDomain.CurrentDomain.BaseDirectory;
            if (folder != null)
            {
               string consoleAppPath = Path.Combine(folder, "ConsoleApp.exe");

               Process process = new Process();
               process.StartInfo.FileName = consoleAppPath;
               process.StartInfo.UseShellExecute = true;
               process.StartInfo.CreateNoWindow = false;
               process.Start();
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Не удалось запустить консоль: " + ex.Message);
         }
      }
   }
}
