namespace WindowsFormsApp_EF_HW_2
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЧеловекаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтрануToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЧеловекаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтрануToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЧеловекаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСтрануToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводВсехДаныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(231, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 419);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеToolStripMenuItem,
            this.выводВсехДаныхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1047, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЧеловекаToolStripMenuItem,
            this.добавитьСтрануToolStripMenuItem,
            this.удалитьЧеловекаToolStripMenuItem,
            this.удалитьСтрануToolStripMenuItem,
            this.изменитьЧеловекаToolStripMenuItem,
            this.изменитьСтрануToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(140, 25);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // добавитьЧеловекаToolStripMenuItem
            // 
            this.добавитьЧеловекаToolStripMenuItem.Name = "добавитьЧеловекаToolStripMenuItem";
            this.добавитьЧеловекаToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.добавитьЧеловекаToolStripMenuItem.Text = "Добавить человека";
            this.добавитьЧеловекаToolStripMenuItem.Click += new System.EventHandler(this.добавитьЧеловекаToolStripMenuItem_Click);
            // 
            // добавитьСтрануToolStripMenuItem
            // 
            this.добавитьСтрануToolStripMenuItem.Name = "добавитьСтрануToolStripMenuItem";
            this.добавитьСтрануToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.добавитьСтрануToolStripMenuItem.Text = "Добавить страну";
            this.добавитьСтрануToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтрануToolStripMenuItem_Click);
            // 
            // удалитьЧеловекаToolStripMenuItem
            // 
            this.удалитьЧеловекаToolStripMenuItem.Name = "удалитьЧеловекаToolStripMenuItem";
            this.удалитьЧеловекаToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.удалитьЧеловекаToolStripMenuItem.Text = "Удалить человека";
            this.удалитьЧеловекаToolStripMenuItem.Click += new System.EventHandler(this.удалитьЧеловекаToolStripMenuItem_Click);
            // 
            // удалитьСтрануToolStripMenuItem
            // 
            this.удалитьСтрануToolStripMenuItem.Name = "удалитьСтрануToolStripMenuItem";
            this.удалитьСтрануToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.удалитьСтрануToolStripMenuItem.Text = "Удалить страну";
            this.удалитьСтрануToolStripMenuItem.Click += new System.EventHandler(this.удалитьСтрануToolStripMenuItem_Click);
            // 
            // изменитьЧеловекаToolStripMenuItem
            // 
            this.изменитьЧеловекаToolStripMenuItem.Name = "изменитьЧеловекаToolStripMenuItem";
            this.изменитьЧеловекаToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.изменитьЧеловекаToolStripMenuItem.Text = "Изменить человека";
            this.изменитьЧеловекаToolStripMenuItem.ToolTipText = "Для редактирования человека выделите строку в таблице и нажмите кнопку \"Изменить " +
    "человека\"";
            this.изменитьЧеловекаToolStripMenuItem.Click += new System.EventHandler(this.изменитьЧеловекаToolStripMenuItem_Click);
            // 
            // изменитьСтрануToolStripMenuItem
            // 
            this.изменитьСтрануToolStripMenuItem.Name = "изменитьСтрануToolStripMenuItem";
            this.изменитьСтрануToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.изменитьСтрануToolStripMenuItem.Text = "Изменить страну";
            this.изменитьСтрануToolStripMenuItem.ToolTipText = "Для редактирования страны нажмите на клетку со страной в таблице, затем - кнопку " +
    "\"Изменить страну\"";
            this.изменитьСтрануToolStripMenuItem.Click += new System.EventHandler(this.изменитьСтрануToolStripMenuItem_Click);
            // 
            // выводВсехДаныхToolStripMenuItem
            // 
            this.выводВсехДаныхToolStripMenuItem.Name = "выводВсехДаныхToolStripMenuItem";
            this.выводВсехДаныхToolStripMenuItem.Size = new System.Drawing.Size(150, 25);
            this.выводВсехДаныхToolStripMenuItem.Text = "Вывод всех даных";
            this.выводВсехДаныхToolStripMenuItem.Click += new System.EventHandler(this.выводВсехДаныхToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 429);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 120);
            this.panel3.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(24, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 22);
            this.textBox3.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Укажите страну";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(6, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 137);
            this.panel2.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Укажите дату рождения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 126);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите фамилию";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записная книжка";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЧеловекаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтрануToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЧеловекаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтрануToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЧеловекаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьСтрануToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem выводВсехДаныхToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

