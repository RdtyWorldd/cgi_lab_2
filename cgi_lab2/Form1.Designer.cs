﻿namespace cgi_lab2
{
     partial class Form1
     {
          /// <summary>
          /// Обязательная переменная конструктора.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Освободить все используемые ресурсы.
          /// </summary>
          /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Код, автоматически созданный конструктором форм Windows

          /// <summary>
          /// Требуемый метод для поддержки конструктора — не изменяйте 
          /// содержимое этого метода с помощью редактора кода.
          /// </summary>
          private void InitializeComponent()
          {
               this.glControl1 = new OpenTK.GLControl();
               this.SuspendLayout();
               // 
               // glControl1
               // 
               this.glControl1.BackColor = System.Drawing.Color.Black;
               this.glControl1.Location = new System.Drawing.Point(43, 31);
               this.glControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.glControl1.Name = "glControl1";
               this.glControl1.Size = new System.Drawing.Size(620, 349);
               this.glControl1.TabIndex = 0;
               this.glControl1.VSync = false;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.glControl1);
               this.Name = "Form1";
               this.Text = "Form1";
               this.ResumeLayout(false);

          }

          #endregion

          private OpenTK.GLControl glControl1;
     }
}

