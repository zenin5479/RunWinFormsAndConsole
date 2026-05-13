using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }

      // Кнопка для запуска Console
      private void ButtonRunConsole_Click(object sender, EventArgs e)
      {
         StartConsoleApp();
      }

      private void StartConsoleApp()
      {
         string folder = AppDomain.CurrentDomain.BaseDirectory;
         if (folder != null)
         {
            string consoleAppPath = Path.Combine(folder, "ConsoleApp.exe");

            // Проверка на наличие ConsoleApp.exe
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