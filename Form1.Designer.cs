namespace InformationSecurityProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.beginButIn = new System.Windows.Forms.Button();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openIn = new System.Windows.Forms.Button();
            this.pathBoxIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.beginOut = new System.Windows.Forms.Button();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openOut = new System.Windows.Forms.Button();
            this.pathBoxOut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Button();
            this.Dev = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данный программый комплекс предназначен для сокрытия\r\nтекста с использованием фор" +
    "мата данных PNG\r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 68);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 398);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.beginButIn);
            this.tabPage1.Controls.Add(this.textBoxIn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(593, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Записать в картинку";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(285, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "0 / 0";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(316, 11);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 28);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Количество используемых бит:";
            // 
            // beginButIn
            // 
            this.beginButIn.Enabled = false;
            this.beginButIn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginButIn.Location = new System.Drawing.Point(425, 293);
            this.beginButIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.beginButIn.Name = "beginButIn";
            this.beginButIn.Size = new System.Drawing.Size(147, 55);
            this.beginButIn.TabIndex = 11;
            this.beginButIn.Text = "Записать";
            this.beginButIn.UseVisualStyleBackColor = true;
            this.beginButIn.Click += new System.EventHandler(this.beginButIn_Click);
            // 
            // textBoxIn
            // 
            this.textBoxIn.Enabled = false;
            this.textBoxIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIn.Location = new System.Drawing.Point(29, 143);
            this.textBoxIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIn.MaxLength = 300;
            this.textBoxIn.Multiline = true;
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(543, 124);
            this.textBoxIn.TabIndex = 10;
            this.textBoxIn.TextChanged += new System.EventHandler(this.textBoxIn_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите текст, который будет помещён в код картинки:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // openIn
            // 
            this.openIn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openIn.Location = new System.Drawing.Point(400, 26);
            this.openIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openIn.Name = "openIn";
            this.openIn.Size = new System.Drawing.Size(131, 39);
            this.openIn.TabIndex = 8;
            this.openIn.Text = "Обзор";
            this.openIn.UseVisualStyleBackColor = true;
            this.openIn.Click += new System.EventHandler(this.openIn_Click);
            // 
            // pathBoxIn
            // 
            this.pathBoxIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathBoxIn.Location = new System.Drawing.Point(9, 43);
            this.pathBoxIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pathBoxIn.Name = "pathBoxIn";
            this.pathBoxIn.ReadOnly = true;
            this.pathBoxIn.Size = new System.Drawing.Size(382, 26);
            this.pathBoxIn.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите путь к картинке:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.beginOut);
            this.tabPage2.Controls.Add(this.textBoxOut);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.openOut);
            this.tabPage2.Controls.Add(this.pathBoxOut);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(593, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вытащить текст из картинки";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(315, 12);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(84, 28);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(24, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Количество используемых бит:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // beginOut
            // 
            this.beginOut.Enabled = false;
            this.beginOut.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginOut.Location = new System.Drawing.Point(424, 295);
            this.beginOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.beginOut.Name = "beginOut";
            this.beginOut.Size = new System.Drawing.Size(147, 55);
            this.beginOut.TabIndex = 17;
            this.beginOut.Text = "Вытащить";
            this.beginOut.UseVisualStyleBackColor = true;
            this.beginOut.Click += new System.EventHandler(this.beginOut_Click);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOut.Location = new System.Drawing.Point(27, 141);
            this.textBoxOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(543, 138);
            this.textBoxOut.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Полученный текст:";
            // 
            // openOut
            // 
            this.openOut.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openOut.Location = new System.Drawing.Point(440, 68);
            this.openOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openOut.Name = "openOut";
            this.openOut.Size = new System.Drawing.Size(131, 39);
            this.openOut.TabIndex = 14;
            this.openOut.Text = "Обзор";
            this.openOut.UseVisualStyleBackColor = true;
            this.openOut.Click += new System.EventHandler(this.openOut_Click);
            // 
            // pathBoxOut
            // 
            this.pathBoxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathBoxOut.Location = new System.Drawing.Point(30, 74);
            this.pathBoxOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pathBoxOut.Name = "pathBoxOut";
            this.pathBoxOut.ReadOnly = true;
            this.pathBoxOut.Size = new System.Drawing.Size(391, 26);
            this.pathBoxOut.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Выберите путь к картинке:";
            // 
            // Help
            // 
            this.Help.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Help.Location = new System.Drawing.Point(44, 390);
            this.Help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(147, 55);
            this.Help.TabIndex = 17;
            this.Help.Text = "Помощь";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click_1);
            // 
            // Dev
            // 
            this.Dev.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dev.Location = new System.Drawing.Point(196, 390);
            this.Dev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dev.Name = "Dev";
            this.Dev.Size = new System.Drawing.Size(147, 55);
            this.Dev.TabIndex = 16;
            this.Dev.Text = "Разработчик";
            this.Dev.UseVisualStyleBackColor = true;
            this.Dev.Click += new System.EventHandler(this.Dev_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openIn);
            this.groupBox1.Controls.Add(this.pathBoxIn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(28, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 78);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 473);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Dev);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запись исходного текста в код PNG-картинки";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button beginButIn;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openIn;
        private System.Windows.Forms.TextBox pathBoxIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button beginOut;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button openOut;
        private System.Windows.Forms.TextBox pathBoxOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Dev;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

