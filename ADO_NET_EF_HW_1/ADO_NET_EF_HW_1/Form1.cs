using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp_ADO_NET_HW_5
{
    public partial class Form1 : Form
    {
        private PetsContex db;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) => ShowDbInfo();

        // Вывод всей информации
        private void ShowDbInfo()
        {
            try
            {
                using (db = new PetsContex())
                {
                    dataGridView1.DataSource = db.CatSet.Select(c => new { c.Nickname, c.Age, c.Owner.Surname }).ToList();
                    dataGridView1.Columns[0].HeaderText = "Кличка";
                    dataGridView1.Columns[1].HeaderText = "Возраст";
                    dataGridView1.Columns[2].HeaderText = "Хозяин";
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void поКличкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox1.Visible = true;
        }

        // Поиск по кличке
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (db = new PetsContex())
                {
                    dataGridView1.DataSource = db.CatSet.Where(c => c.Nickname == textBox1.Text).Select(c => new { c.Nickname, c.Age, c.Owner.Surname }).ToList();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void поВозрастуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = true;
        }

        // Поиск по возрасту
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (db = new PetsContex())
                {
                    int userAge = int.Parse(textBox2.Text);
                    dataGridView1.DataSource = db.CatSet.Where(c => c.Age == userAge).Select(c => new { c.Nickname, c.Age, c.Owner.Surname }).ToList();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void поФамилииВладельцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        // Поиск по фамилии владельца
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (db = new PetsContex())
                {
                    dataGridView1.DataSource = db.CatSet.Where(c => c.Owner.Surname == textBox3.Text).Select(c => new { c.Nickname, c.Age, c.Owner.Surname }).ToList();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Вывод списка различных кличек котов в алфавитном порядке
        private void выводToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (db = new PetsContex())
                {
                    dataGridView1.DataSource = db.CatSet.Select(c => new { c.Nickname, c.Age, c.Owner.Surname }).OrderBy(c => c.Nickname).ToList();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Вывод всей информации
        private void выводВсейИнформацииToolStripMenuItem_Click(object sender, EventArgs e) => ShowDbInfo();

        // Добавление кота
        private void добавлениеКотаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox6.Visible = false;

            try
            {
                using (db = new PetsContex())
                {
                    comboBox1.DataSource = db.OwnerSet.Select(o => o.Surname).Distinct().ToList();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Добавление хозяина
        private void добавлениеВладельцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
        }

        // Удаление кота
        private void удалениеКотаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = true;
        }

        // Определение количества котов у каждого владельца (с построением диаграммы)
        private void количествоКотовУВладельцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FillTheChartWithData();
                chart1.Visible = true;
                button7.Visible = true;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Заполнение диаграммы данными из БД
        private void FillTheChartWithData()
        {
            try
            {
                using (db = new PetsContex())
                {
                    var query = db.CatSet.GroupBy(c => c.Owner.Surname).Select(cc => new { Surname = cc.Key, Cats = cc.Select(c => c.Id).Count() }).ToList();

                    chart1.DataSource = query;
                    chart1.Series[0].XValueMember = "Surname";
                    chart1.Series[0].YValueMembers = "Cats";
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Определение среднего возраста котов
        private void среднийВозрастВсехКотовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (db = new PetsContex())
                {
                    MessageBox.Show($"Средний возраст всех котов = {db.CatSet.Average(c => c.Age):f1} лет.");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Определение количества владельцев, у которых больше двух котов
        private void количествоВладельцевИмеющихБолее2хКотовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (db = new PetsContex())
            {
                IQueryable<int> countOfOnwers = from cats in db.CatSet
                                                group cats.Owner.Surname by cats.Owner.Id into grouped
                                                where grouped.Count() > 2
                                                select grouped.Count();

                MessageBox.Show($"Количество владельцев, у которых больше двух котов = {countOfOnwers.Count()}");
            }
        }

        // Добавить владельца
        private void button4_Click(object sender, EventArgs e)
        {
            using (db = new PetsContex())
            {
                if(textBox4.Text != null)
                {
                    db.OwnerSet.Add(new Owner { Surname = textBox4.Text });
                    db.SaveChanges();
                    MessageBox.Show("Добавление хозяина успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox4.Visible = false;
                }
                else
                {
                    MessageBox.Show("Необходимо указать фамилию хозяина!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Добавить кота
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (db = new PetsContex())
                {
                    Owner owner = db.OwnerSet.Where(o => o.Surname == comboBox1.SelectedItem.ToString()).Select(o => o).First();
                    db.CatSet.Add(new Cat { Nickname = textBox5.Text, Age = Convert.ToInt32(textBox6.Text), Owner = owner });
                    db.SaveChanges();
                    MessageBox.Show("Добавление завершено успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox5.Visible = false;
                    ShowDbInfo();
                }
            }
            catch
            {
                MessageBox.Show("Необходимо заполнить все поля формы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Удалить кота
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (db = new PetsContex())
                {
                    Cat cat = db.CatSet.Where(c => c.Nickname == textBox7.Text).Select(c => c).FirstOrDefault();

                    if (cat != null)
                    {
                        db.CatSet.Remove(cat);
                        db.SaveChanges();
                        MessageBox.Show("Удаление завершено успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox6.Visible = false;
                        ShowDbInfo();
                    }
                    else
                    {
                        MessageBox.Show("Кота с указанной кличкой нет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Убрать диаграмму
        private void button7_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            button7.Visible = false;
        }
    }
}