namespace WinFormsApp
{
   partial class MainForm
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         ButtonRunConsole = new System.Windows.Forms.Button();
         SuspendLayout();
         // 
         // ButtonRunConsole
         // 
         ButtonRunConsole.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         ButtonRunConsole.Location = new System.Drawing.Point(12, 12);
         ButtonRunConsole.Name = "ButtonRunConsole";
         ButtonRunConsole.Size = new System.Drawing.Size(210, 37);
         ButtonRunConsole.TabIndex = 0;
         ButtonRunConsole.Text = "Запустить Console";
         ButtonRunConsole.UseVisualStyleBackColor = true;
         ButtonRunConsole.Click += ButtonRunConsole_Click;
         // 
         // MainForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(234, 61);
         Controls.Add(ButtonRunConsole);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "MainForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Запуск Console из WinForms";
         ResumeLayout(false);
      }

      #endregion

      private System.Windows.Forms.Button ButtonRunConsole;
   }
}
