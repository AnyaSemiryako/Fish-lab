﻿namespace WinAsynchMethod
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
            this.components = new System.ComponentModel.Container();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnhelp = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(8, 24);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(98, 20);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Значение А";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(216, 24);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(98, 20);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Значение В";
            // 
            // txbA
            // 
            this.helpProvider1.SetHelpString(this.txbA, "For input integer A");
            this.txbA.Location = new System.Drawing.Point(88, 24);
            this.txbA.Name = "txbA";
            this.helpProvider1.SetShowHelp(this.txbA, true);
            this.txbA.Size = new System.Drawing.Size(100, 26);
            this.txbA.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txbA, "For input integer A");
            // 
            // txbB
            // 
            this.helpProvider1.SetHelpKeyword(this.txbB, "For input integer B");
            this.txbB.Location = new System.Drawing.Point(296, 24);
            this.txbB.Name = "txbB";
            this.helpProvider1.SetShowHelp(this.txbB, true);
            this.txbB.Size = new System.Drawing.Size(100, 26);
            this.txbB.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txbB, "For input integer B");
            // 
            // btnRun
            // 
            this.helpProvider1.SetHelpString(this.btnRun, "Sum");
            this.btnRun.Location = new System.Drawing.Point(16, 64);
            this.btnRun.Name = "btnRun";
            this.helpProvider1.SetShowHelp(this.btnRun, true);
            this.btnRun.Size = new System.Drawing.Size(75, 29);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Сумма";
            this.toolTip1.SetToolTip(this.btnRun, "Sum");
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnWork
            // 
            this.helpProvider1.SetHelpString(this.btnWork, "Start work");
            this.btnWork.Location = new System.Drawing.Point(118, 109);
            this.btnWork.Name = "btnWork";
            this.helpProvider1.SetShowHelp(this.btnWork, true);
            this.btnWork.Size = new System.Drawing.Size(75, 30);
            this.btnWork.TabIndex = 6;
            this.btnWork.Text = "Работа";
            this.toolTip1.SetToolTip(this.btnWork, "Start work");
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Asus\\Documents\\Колледж\\3 курс\\repos\\WinAsynchMethod";
            this.helpProvider1.Tag = "btnhelp";
            // 
            // btnhelp
            // 
            this.btnhelp.Location = new System.Drawing.Point(247, 85);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(75, 33);
            this.btnhelp.TabIndex = 7;
            this.btnhelp.Text = "help";
            this.btnhelp.UseVisualStyleBackColor = true;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 144);
            this.Controls.Add(this.btnhelp);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Ассинхронный запуск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

