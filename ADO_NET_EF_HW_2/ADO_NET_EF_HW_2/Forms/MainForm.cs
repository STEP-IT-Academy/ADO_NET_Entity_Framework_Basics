using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp_EF_HW_2.EF;
using WindowsFormsApp_EF_HW_2.Forms;
using WindowsFormsApp_EF_HW_2.Forms.Editing;
using WindowsFormsApp_EF_HW_2.Forms.Removing;
using WindowsFormsApp_EF_HW_2.Models;

namespace WindowsFormsApp_EF_HW_2
{
    public partial class MainForm : Form
    {
        private NotebookContext db;
        private AddCountryForm aCf;
        private RemCountryForm rCf;
        private EdCountryForm eCf;
        private AddPersonForm aPf;
        private RemPersonForm rPf;
        private EdPersonForm ePf;
        private string connectionString;
        private Dictionary<DateTime, int> birthdays = new Dictionary<DateTime, int>();
        private const string checkDateOfBirthPattern = @"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$
                                                       |^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))
                                                       $|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$";

        public MainForm() => InitializeComponent();

        // Загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"(localdb)\mssqllocaldb";
                builder.InitialCatalog = "NotebookContex";
                builder.AttachDBFilename = Application.StartupPath + @"\Db\Notebook.mdf";
                builder.IntegratedSecurity = true;
                connectionString = builder.ConnectionString;

                using (NotebookContext db = new NotebookContext(connectionString))
                {
                    birthdays = db.People.ToDictionary(p => new DateTime(int.Parse(p.Birthday.Split('.')[2]), int.Parse(p.Birthday.Split('.')[1]), 
                        int.Parse(p.Birthday.Split('.')[0])), p => p.Id);
                    CheckBirthdayNotification(db);
                }

                ShowAllData();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Вывод все данных
        private void ShowAllData()
        {
            using (db = new NotebookContext(connectionString))
            {
                dataGridView1.DataSource = db.People.Select(p => new { p.Id, p.Name, p.LastName, p.Birthday, p.Phone, Country = p.Country.Name }).ToList();
                dataGridView1.Columns[0].Visible = false;
            }
        }

        // Добавление человека
        private void добавитьЧеловекаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (db = new NotebookContext(connectionString))
                {
                    aPf = new AddPersonForm(db.Countries.Select(c => c.Name).ToList());

                    if (!(aPf.ShowDialog() == DialogResult.OK))
                    {
                        return;
                    }
                    else
                    {
                        if(isCorrectPesonData(aPf.textBox1.Text, aPf.textBox2.Text, aPf.textBox3.Text, aPf.textBox4.Text, aPf.comboBox1.SelectedItem.ToString()))
                        {
                            Country country = db.Countries.Where(c => c.Name == aPf.comboBox1.SelectedItem.ToString()).First();

                            if(country != null)
                            {
                                Person person = new Person { Name = aPf.textBox1.Text, LastName = aPf.textBox2.Text, Birthday = aPf.textBox3.Text, Phone = aPf.textBox4.Text, CountryId = country.Id };
                                db.People.Add(person);
                                db.SaveChanges();

                                country.People.Add(person);
                                db.SaveChanges();
                                ShowAllData();
                                MessageBox.Show("Человек был добавлен успешно.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Указанная вами страна отсутствует в списке выбора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неверно введены данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Возникли проблемы при добавлении человека.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Добавление страны
        private void добавитьСтрануToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                aCf = new AddCountryForm();

                if(!(aCf.ShowDialog() == DialogResult.OK))
                {
                    return;
                }
                else
                {
                    using (db = new NotebookContext(connectionString))
                    {
                        if (!isUniqCountryName(aCf.textBox1.Text, db))
                        {
                            db.Countries.Add(new Country { Name = aCf.textBox1.Text });
                            db.SaveChanges();
                            ShowAllData();
                            MessageBox.Show("Страна была добавлена успешно.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Указанная страна уже есть. Выберите другую.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Возникли проблемы при добавлении страны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Проверка уникальнисти названия страны
        private bool isUniqCountryName(string countryName, NotebookContext db) => db.Countries.Where(c => c.Name == countryName).Any();

        // Удаление человека
        private void удалитьЧеловекаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rPf = new RemPersonForm();

                if (!(rPf.ShowDialog() == DialogResult.OK))
                {
                    return;
                }
                else
                {
                    using (db = new NotebookContext(connectionString))
                    {
                        Person person = isPersonExists(rPf.textBox1.Text, rPf.textBox2.Text, rPf.textBox3.Text, db);
                        if (person != null)
                        {
                            db.People.Remove(person);
                            db.SaveChanges();
                            ShowAllData();
                            MessageBox.Show("Удаление человека завершено успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("По указанным данным не удалось найти человека", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при удалении человека. Повторите операцию ещё раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Проверка на наличие в БД человека
        private Person isPersonExists(string name, string surname, string phone, NotebookContext db) => db.People.FirstOrDefault(p => p.Name == name && p.LastName == surname && p.Phone == phone);

        // Удаление страны
        private void удалитьСтрануToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rCf = new RemCountryForm();

                if (!(rCf.ShowDialog() == DialogResult.OK))
                {
                    return;
                }
                else
                {
                    using (db = new NotebookContext(connectionString))
                    {
                        Country country = isCountryExists(rCf.textBox1.Text.ToString(), db);
                        if (country != null)
                        {
                            db.Countries.Remove(country);
                            db.SaveChanges();
                            ShowAllData();
                            MessageBox.Show("Удаление страны завершено успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("По указанным данным не удалось найти страну", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при удалении страны. Повторите операцию ещё раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Проверка на наличие в БД страны
        private Country isCountryExists(string countryName, NotebookContext db) => db.Countries.FirstOrDefault(c => c.Name == countryName);

        // Изменение человека
        private void изменитьЧеловекаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedRows.Count == 1)
                {
                    using (db = new NotebookContext(connectionString))
                    {
                        int selectedPersonId = (int)dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value; 
                        Person person = db.People.Where(p => p.Id == selectedPersonId).FirstOrDefault();
                        ePf = new EdPersonForm(person.Name, person.LastName, person.Birthday, person.Phone, db.Countries.Select(c => c.Name).ToList());

                        if(!(ePf.ShowDialog() == DialogResult.OK))
                        {
                            return;
                        }
                        else
                        {
                            if (isCorrectPesonData(ePf.textBox1.Text, ePf.textBox2.Text, ePf.textBox3.Text, ePf.textBox4.Text, ePf.comboBox1.SelectedItem.ToString()))
                            {
                                Country country = db.Countries.Where(c => c.Name == ePf.comboBox1.SelectedItem.ToString()).First();

                                if(country != null)
                                {
                                    person.Name = ePf.textBox1.Text;
                                    person.LastName = ePf.textBox2.Text;
                                    person.Birthday = ePf.textBox3.Text;
                                    person.Phone = ePf.textBox4.Text;
                                    person.CountryId = country.Id;
                                    db.SaveChanges();
                                    ShowAllData();
                                    MessageBox.Show("Редактирование человека завершено успешно.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Указанная вами страна отсутствует в списке выбора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Неверно введены данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выделите всю строку, необходимую для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Изменение страны
        private void изменитьСтрануToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedCells.Count == 1) {
                    using (db = new NotebookContext(connectionString))
                    {
                        string selectedCountryName = dataGridView1.SelectedCells[0].Value.ToString();
                        if(isCountryExists(selectedCountryName, db) != null)
                        {
                            eCf = new EdCountryForm(selectedCountryName);
                            if(!(eCf.ShowDialog() == DialogResult.OK))
                            {
                                return;
                            }
                            else
                            {
                                Country country = db.Countries.Where(c => c.Name == selectedCountryName).FirstOrDefault();
                                country.Name = eCf.textBox1.Text.ToString();
                                db.SaveChanges();
                                ShowAllData();
                                MessageBox.Show("Редактирование страны завершено успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Выбрана неверная клетка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите только клетку с именем страны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Элемент меню "Вывод всех данных"
        private void выводВсехДаныхToolStripMenuItem_Click(object sender, EventArgs e) => ShowAllData();

        // Поиск по фамилии
        private void button2_Click_1(object sender, EventArgs e)
        {
            using (db = new NotebookContext(connectionString))
            {
                if (db.People.Where(p => p.LastName == textBox1.Text).Count() != 0)
                {
                    dataGridView1.DataSource = db.People.Where(p => p.LastName == textBox1.Text).Select(p => new { p.Id, p.Name, p.LastName, p.Birthday, p.Phone, Country = p.Country.Name }).ToList();
                    dataGridView1.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("Совпадений не найдено", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                textBox1.Text = "";
            }
        }

        // Поиск по дате рождения
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (db = new NotebookContext(connectionString))
            {
                if (db.People.Where(p => p.Birthday == textBox2.Text).Count() != 0)
                {
                    dataGridView1.DataSource = db.People.Where(p => p.Birthday == textBox2.Text).Select(p => new { p.Id, p.Name, p.LastName, p.Birthday, p.Phone, Country = p.Country.Name }).ToList();
                    dataGridView1.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("Совпадений не найдено", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                textBox2.Text = "";
            }
        }

        // Поиск по стране
        private void button3_Click_1(object sender, EventArgs e)
        {
            using (db = new NotebookContext(connectionString))
            {
                if (db.People.Where(p => p.Country.Name == textBox3.Text).Count() != 0)
                {
                    dataGridView1.DataSource = db.People.Where(p => p.Country.Name == textBox3.Text).Select(p => new { p.Id, p.Name, p.LastName, p.Birthday, p.Phone, Country = p.Country.Name }).ToList();
                    dataGridView1.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("Совпадений не найдено", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                textBox3.Text = "";
            }
        }

        // Напоминание о ДР
        private void CheckBirthdayNotification(NotebookContext db)
        {
            DateTime today = DateTime.Now;
            var needToNotify = birthdays.Where(b => today.Month == b.Key.Month && today.Day - b.Key.Day == 2).Select(b => b).ToList();
            if (needToNotify != null)
            {
                string notificationText = null;
                int id = -1;
                Person pers = null;

                notifyIcon1.Icon = new System.Drawing.Icon(Application.StartupPath + @"\IcoForToolTip\44.ico");
                notifyIcon1.Text = "Наопминание о ДР";
                notifyIcon1.BalloonTipTitle = "Напоминание о приближающемся дне рождения";
                notifyIcon1.BalloonTipText = notificationText;

                for (int i = 0; i < needToNotify.Count; i++)
                {
                    id = needToNotify[i].Value;
                    pers = db.People.Where(p => p.Id == id).Select(p => p).First();
                    notificationText = $"{pers.Name} {pers.LastName} {pers.Birthday}. ";
                    notifyIcon1.BalloonTipText = notificationText;
                    notifyIcon1.ShowBalloonTip(100);
                }
            }
        }

        // Валидация введенных данных при добавлении пользователя
        private bool isCorrectPesonData(string name, string surname, string birthday, string phone, string country) => name.Length > 0 && surname.Length > 0 && Regex.IsMatch(birthday, checkDateOfBirthPattern, RegexOptions.IgnoreCase) && phone.Length > 0 && country.Length > 0;
    }
}