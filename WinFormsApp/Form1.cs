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

      // Кнопка для запуска Console
      private void button1_Click(object sender, EventArgs e)
      {
         // Запуск только по кнопке
         StartConsoleApp();   
      }

      private void StartConsoleApp()
      {
         string folder = AppDomain.CurrentDomain.BaseDirectory;
         if (folder != null)
         {
            string consoleAppPath = Path.Combine(folder, "ConsoleApp.exe");

            // Проверка на всякий случай (можно оставить без MessageBox)
            if (!File.Exists(consoleAppPath))
            {
               MessageBox.Show(string.Format(@"Файл не найден:{0}", consoleAppPath), @"Ошибка");
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
               MessageBox.Show(string.Format(@"Ошибка при запуске:{0}", ex.Message), @"Ошибка");
            }
         }
      }
   }
}