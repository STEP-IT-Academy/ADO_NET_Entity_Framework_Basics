namespace WindowsFormsApp_EF_HW_3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСДаннымиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.собакуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.котаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.собакуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.котаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.собакуToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.котаToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оКотеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оСобакеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оВсехЖивотныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(712, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Коты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Собаки";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(358, 205);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(579, 78);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(307, 235);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(307, 235);
            this.dataGridView1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "База данных",
            "Текстовый файл",
            "Xml-документ",
            "Память"});
            this.comboBox1.Location = new System.Drawing.Point(358, 165);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 32);
            this.comboBox1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСДаннымиToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(918, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСДаннымиToolStripMenuItem
            // 
            this.работаСДаннымиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЭлементToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.работаСДаннымиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.работаСДаннымиToolStripMenuItem.Name = "работаСДаннымиToolStripMenuItem";
            this.работаСДаннымиToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.работаСДаннымиToolStripMenuItem.Text = "Работа с данными";
            // 
            // добавитьЭлементToolStripMenuItem
            // 
            this.добавитьЭлементToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.собакуToolStripMenuItem,
            this.котаToolStripMenuItem});
            this.добавитьЭлементToolStripMenuItem.Name = "добавитьЭлементToolStripMenuItem";
            this.добавитьЭлементToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.добавитьЭлементToolStripMenuItem.Text = "Добавить";
            // 
            // собакуToolStripMenuItem
            // 
            this.собакуToolStripMenuItem.Name = "собакуToolStripMenuItem";
            this.собакуToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.собакуToolStripMenuItem.Text = "Собаку";
            this.собакуToolStripMenuItem.Click += new System.EventHandler(this.собакуToolStripMenuItem_Click);
            // 
            // котаToolStripMenuItem
            // 
            this.котаToolStripMenuItem.Name = "котаToolStripMenuItem";
            this.котаToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.котаToolStripMenuItem.Text = "Кота";
            this.котаToolStripMenuItem.Click += new System.EventHandler(this.котаToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.собакуToolStripMenuItem1,
            this.котаToolStripMenuItem1});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // собакуToolStripMenuItem1
            // 
            this.собакуToolStripMenuItem1.Name = "собакуToolStripMenuItem1";
            this.собакуToolStripMenuItem1.Size = new System.Drawing.Size(127, 24);
            this.собакуToolStripMenuItem1.Text = "Собаку";
            this.собакуToolStripMenuItem1.Click += new System.EventHandler(this.собакуToolStripMenuItem1_Click);
            // 
            // котаToolStripMenuItem1
            // 
            this.котаToolStripMenuItem1.Name = "котаToolStripMenuItem1";
            this.котаToolStripMenuItem1.Size = new System.Drawing.Size(127, 24);
            this.котаToolStripMenuItem1.Text = "Кота";
            this.котаToolStripMenuItem1.Click += new System.EventHandler(this.котаToolStripMenuItem1_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.собакуToolStripMenuItem2,
            this.котаToolStripMenuItem2});
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // собакуToolStripMenuItem2
            // 
            this.собакуToolStripMenuItem2.Name = "собакуToolStripMenuItem2";
            this.собакуToolStripMenuItem2.Size = new System.Drawing.Size(127, 24);
            this.собакуToolStripMenuItem2.Text = "Собаку";
            this.собакуToolStripMenuItem2.ToolTipText = "Выделите строку с данными о собаке, которую хотите изменить, и нажмите эту кнопку" +
    "";
            this.собакуToolStripMenuItem2.Click += new System.EventHandler(this.собакуToolStripMenuItem2_Click);
            // 
            // котаToolStripMenuItem2
            // 
            this.котаToolStripMenuItem2.Name = "котаToolStripMenuItem2";
            this.котаToolStripMenuItem2.Size = new System.Drawing.Size(127, 24);
            this.котаToolStripMenuItem2.Text = "Кота";
            this.котаToolStripMenuItem2.ToolTipText = "Выделите строку с данными о коте, которого хотите изменить, и нажмите эту кнопку";
            this.котаToolStripMenuItem2.Click += new System.EventHandler(this.котаToolStripMenuItem2_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оКотеToolStripMenuItem,
            this.оСобакеToolStripMenuItem,
            this.оВсехЖивотныхToolStripMenuItem});
            this.информацияToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // оКотеToolStripMenuItem
            // 
            this.оКотеToolStripMenuItem.Name = "оКотеToolStripMenuItem";
            this.оКотеToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.оКотеToolStripMenuItem.Text = "О коте";
            this.оКотеToolStripMenuItem.Click += new System.EventHandler(this.оКотеToolStripMenuItem_Click);
            // 
            // оСобакеToolStripMenuItem
            // 
            this.оСобакеToolStripMenuItem.Name = "оСобакеToolStripMenuItem";
            this.оСобакеToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.оСобакеToolStripMenuItem.Text = "О собаке";
            this.оСобакеToolStripMenuItem.Click += new System.EventHandler(this.оСобакеToolStripMenuItem_Click);
            // 
            // оВсехЖивотныхToolStripMenuItem
            // 
            this.оВсехЖивотныхToolStripMenuItem.Name = "оВсехЖивотныхToolStripMenuItem";
            this.оВсехЖивотныхToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.оВсехЖивотныхToolStripMenuItem.Text = "О всех животных";
            this.оВсехЖивотныхToolStripMenuItem.Click += new System.EventHandler(this.оВсехЖивотныхToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Выберите источник данных";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(299, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 200);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ORM технологии";
            this.groupBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 54);
            this.label4.TabIndex = 0;
            this.label4.Text = "Выберите ORM технологию, \r\nс помощью которой будет обеспечно\r\nвзаимодействие с БД" +
    "";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ADO.NET",
            "ADO.NET Entity Framework (Entity Framework 6)",
            "Dapper ORM"});
            this.comboBox2.Location = new System.Drawing.Point(38, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(272, 26);
            this.comboBox2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выбрать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Репозиторий";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСДаннымиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собакуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem котаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собакуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem котаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem собакуToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem котаToolStripMenuItem2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оКотеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оСобакеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оВсехЖивотныхToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
    }
}

