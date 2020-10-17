namespace WindowsFormsApp_ADO_NET_HW_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКличкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФамилииВладельцаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводВсейИнформацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеКотаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеВладельцаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеКотаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоКотовУВладельцаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднийВозрастВсехКотовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоВладельцевИмеющихБолее2хКотовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.статистикаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поКличкеToolStripMenuItem,
            this.поВозрастуToolStripMenuItem,
            this.поФамилииВладельцаToolStripMenuItem,
            this.выводToolStripMenuItem,
            this.выводВсейИнформацииToolStripMenuItem});
            this.поискToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поКличкеToolStripMenuItem
            // 
            this.поКличкеToolStripMenuItem.Name = "поКличкеToolStripMenuItem";
            this.поКличкеToolStripMenuItem.Size = new System.Drawing.Size(447, 24);
            this.поКличкеToolStripMenuItem.Text = "По кличке";
            this.поКличкеToolStripMenuItem.Click += new System.EventHandler(this.поКличкеToolStripMenuItem_Click);
            // 
            // поВозрастуToolStripMenuItem
            // 
            this.поВозрастуToolStripMenuItem.Name = "поВозрастуToolStripMenuItem";
            this.поВозрастуToolStripMenuItem.Size = new System.Drawing.Size(447, 24);
            this.поВозрастуToolStripMenuItem.Text = "По возрасту";
            this.поВозрастуToolStripMenuItem.Click += new System.EventHandler(this.поВозрастуToolStripMenuItem_Click);
            // 
            // поФамилииВладельцаToolStripMenuItem
            // 
            this.поФамилииВладельцаToolStripMenuItem.Name = "поФамилииВладельцаToolStripMenuItem";
            this.поФамилииВладельцаToolStripMenuItem.Size = new System.Drawing.Size(447, 24);
            this.поФамилииВладельцаToolStripMenuItem.Text = "По фамилии владельца";
            this.поФамилииВладельцаToolStripMenuItem.Click += new System.EventHandler(this.поФамилииВладельцаToolStripMenuItem_Click);
            // 
            // выводToolStripMenuItem
            // 
            this.выводToolStripMenuItem.Name = "выводToolStripMenuItem";
            this.выводToolStripMenuItem.Size = new System.Drawing.Size(447, 24);
            this.выводToolStripMenuItem.Text = "Вывод различных кличек котов в алфавитном порядке";
            this.выводToolStripMenuItem.Click += new System.EventHandler(this.выводToolStripMenuItem_Click);
            // 
            // выводВсейИнформацииToolStripMenuItem
            // 
            this.выводВсейИнформацииToolStripMenuItem.Name = "выводВсейИнформацииToolStripMenuItem";
            this.выводВсейИнформацииToolStripMenuItem.Size = new System.Drawing.Size(447, 24);
            this.выводВсейИнформацииToolStripMenuItem.Text = "Вывод всей информации";
            this.выводВсейИнформацииToolStripMenuItem.Click += new System.EventHandler(this.выводВсейИнформацииToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеКотаToolStripMenuItem,
            this.добавлениеВладельцаToolStripMenuItem,
            this.удалениеКотаToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(131, 23);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // добавлениеКотаToolStripMenuItem
            // 
            this.добавлениеКотаToolStripMenuItem.Name = "добавлениеКотаToolStripMenuItem";
            this.добавлениеКотаToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.добавлениеКотаToolStripMenuItem.Text = "Добавление кота";
            this.добавлениеКотаToolStripMenuItem.Click += new System.EventHandler(this.добавлениеКотаToolStripMenuItem_Click);
            // 
            // добавлениеВладельцаToolStripMenuItem
            // 
            this.добавлениеВладельцаToolStripMenuItem.Name = "добавлениеВладельцаToolStripMenuItem";
            this.добавлениеВладельцаToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.добавлениеВладельцаToolStripMenuItem.Text = "Добавление владельца";
            this.добавлениеВладельцаToolStripMenuItem.Click += new System.EventHandler(this.добавлениеВладельцаToolStripMenuItem_Click);
            // 
            // удалениеКотаToolStripMenuItem
            // 
            this.удалениеКотаToolStripMenuItem.Name = "удалениеКотаToolStripMenuItem";
            this.удалениеКотаToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.удалениеКотаToolStripMenuItem.Text = "Удаление кота";
            this.удалениеКотаToolStripMenuItem.Click += new System.EventHandler(this.удалениеКотаToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествоКотовУВладельцаToolStripMenuItem,
            this.среднийВозрастВсехКотовToolStripMenuItem,
            this.количествоВладельцевИмеющихБолее2хКотовToolStripMenuItem});
            this.статистикаToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // количествоКотовУВладельцаToolStripMenuItem
            // 
            this.количествоКотовУВладельцаToolStripMenuItem.Name = "количествоКотовУВладельцаToolStripMenuItem";
            this.количествоКотовУВладельцаToolStripMenuItem.Size = new System.Drawing.Size(420, 24);
            this.количествоКотовУВладельцаToolStripMenuItem.Text = "Количество котов у владельца";
            this.количествоКотовУВладельцаToolStripMenuItem.Click += new System.EventHandler(this.количествоКотовУВладельцаToolStripMenuItem_Click);
            // 
            // среднийВозрастВсехКотовToolStripMenuItem
            // 
            this.среднийВозрастВсехКотовToolStripMenuItem.Name = "среднийВозрастВсехКотовToolStripMenuItem";
            this.среднийВозрастВсехКотовToolStripMenuItem.Size = new System.Drawing.Size(420, 24);
            this.среднийВозрастВсехКотовToolStripMenuItem.Text = "Средний возраст всех котов";
            this.среднийВозрастВсехКотовToolStripMenuItem.Click += new System.EventHandler(this.среднийВозрастВсехКотовToolStripMenuItem_Click);
            // 
            // количествоВладельцевИмеющихБолее2хКотовToolStripMenuItem
            // 
            this.количествоВладельцевИмеющихБолее2хКотовToolStripMenuItem.Name = "количествоВладельцевИмеющихБолее2хКотовToolStripMenuItem";
            this.количествоВладельцевИмеющихБолее2хКотовToolStripMenuItem.Size = new System.Drawing.Size(420, 24);
            this.количествоВладельцевИмеющихБолее2хКотовToolStripMenuItem.Text = "Количество владельцев, имеющих более 2-х котов";
            this.количествоВладельцевИмеющихБолее2хКотовToolStripMenuItem.Click += new System.EventHandler(this.количествоВладельцевИмеющихБолее2хКотовToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(301, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 265);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(59, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(32, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите кличку кота";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(58, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 178);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(40, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Укажите возраст кота";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(34, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 163);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(49, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Укажите фамилию владельца";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(21, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 209);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(77, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 42);
            this.button4.TabIndex = 2;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(38, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 20);
            this.textBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(34, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Укажите фамилию владельца";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(12, 38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(283, 270);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(67, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Укажите владельца";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(45, 106);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(204, 20);
            this.textBox6.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(65, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Укажите возраст кота";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(79, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 42);
            this.button5.TabIndex = 2;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(47, 41);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(204, 20);
            this.textBox5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(67, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Укажите кличку кота";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox7);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(53, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(222, 193);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(39, 76);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(145, 20);
            this.textBox7.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(39, 118);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 42);
            this.button6.TabIndex = 3;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(40, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Укажите кличку кота";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(301, 43);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(521, 269);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(453, 318);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(197, 33);
            this.button7.TabIndex = 10;
            this.button7.Text = "Убрать диаграмму";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 363);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cats";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem поКличкеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВозрастуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФамилииВладельцаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеКотаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеВладельцаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеКотаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоКотовУВладельцаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднийВозрастВсехКотовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоВладельцевИмеющихБолее2хКотовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выводВсейИнформацииToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button7;
    }
}

