using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp_EF_HW_3.Forms.Common;
using WindowsFormsApp_EF_HW_3.Forms.ForCats;
using WindowsFormsApp_EF_HW_3.Forms.ForDogs;
using WindowsFormsApp_EF_HW_3.Interfaces;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3
{
    public partial class MainForm : Form
    {
        private IRepository<Dog> dogRep;
        private IRepository<Cat> catRep;
        private readonly static CreateDogForm createDogForm = new CreateDogForm();
        private readonly static CreateCatForm createCatForm = new CreateCatForm();
        private readonly static DeleteDogForm deleteDogForm = new DeleteDogForm();
        private readonly static DeleteCatForm deleteCatForm = new DeleteCatForm();
        private readonly static GetAnimalForm getAnimalForm = new GetAnimalForm();
        private static UpdateDogForm updateDogForm;
        private static UpdateCatForm updateCatForm;

        public MainForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void ShowCats()
        {
            try
            {
                dataGridView2.DataSource = catRep.GetAll().ToList();
                dataGridView2.Columns[0].Visible = false;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowDogs()
        {
            try
            {
                dataGridView1.DataSource = dogRep.GetAll().ToList();
                dataGridView1.Columns[0].Visible = false;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAllAnimals()
        {
            try
            {
                dataGridView1.DataSource = dogRep.GetAll();
                dataGridView1.Columns[0].Visible = false;
                dataGridView2.DataSource = catRep.GetAll();
                dataGridView2.Columns[0].Visible = false;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Выбрать источник данных
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            groupBox1.Visible = true;
                            break;
                        }
                    case 1:
                        {
                            dogRep = new DataRepositories.FileRepositories.CSV.DogRepository();
                            catRep = new DataRepositories.FileRepositories.CSV.CatRepository();
                            MessageBox.Show($"{comboBox1.SelectedItem} выбран в качестве источника данных", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ShowAllAnimals();
                            break;
                        }
                    case 2:
                        {
                            dogRep = new DataRepositories.XMLRepositories.DogRepository();
                            catRep = new DataRepositories.XMLRepositories.CatRepository();
                            MessageBox.Show($"{comboBox1.SelectedItem} выбран в качестве источника данных", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ShowAllAnimals();
                            break;
                        }
                    case 3: 
                        {
                            dogRep = new DataRepositories.MemoryRepositories.DogRepository();
                            catRep = new DataRepositories.MemoryRepositories.CatRepository();
                            MessageBox.Show($"{comboBox1.SelectedItem} выбрана в качестве источника данных", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ShowAllAnimals();
                            break;
                        }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Добавить собаку
        private void собакуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(!(createDogForm.ShowDialog() == DialogResult.OK))
                {
                    return;
                }
                else if(createDogForm.GetDog() == null)
                {
                    throw new Exception("Необходимо заполнить все поля ввода");
                }
                else
                {
                    dogRep.Create(createDogForm.GetDog());
                    ShowDogs();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                createDogForm.ClearTextboxes();
            }
        }

        // Добвить кота
        private void котаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(createCatForm.ShowDialog() == DialogResult.OK))
                {
                    return;
                }
                else if (createCatForm.GetCat() == null)
                {
                    throw new Exception("Необходимо заполнить все поля ввода");
                }
                else
                {
                    catRep.Create(createCatForm.GetCat());
                    ShowCats();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                createCatForm.ClearTextboxes();
            }
        }

        // Удалить собаку
        private void собакуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if(!(deleteDogForm.ShowDialog() == DialogResult.OK))
                {
                    return;
                }
                else if(deleteDogForm.GetDog() == null)
                {
                    throw new Exception("Необходимо заполнить поле для ввода");
                }
                else
                {
                    dogRep.Delete(deleteDogForm.GetDog());
                    ShowDogs();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                deleteDogForm.ClearTextbox();
            }
        }

        // Удалить кота
        private void котаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(deleteCatForm.ShowDialog() == DialogResult.OK))
                {
                    return;
                }
                else if (deleteCatForm.GetCat() == null)
                {
                    throw new Exception("Необходимо заполнить поле для ввода");
                }
                else
                {
                    catRep.Delete(deleteCatForm.GetCat());
                    ShowCats();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                deleteCatForm.ClearTextbox();
            }
        }

        // Изменить собаку
        private void собакуToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedRows.Count != 1)
                {
                    throw new Exception("Необходимо выделить все ячейки, где содержится информация о собаке");
                }
                else if(dataGridView1.SelectedRows.Count == 1)
                {
                    Dog dog = dogRep.Get(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
                    updateDogForm = new UpdateDogForm(dog);
                    if(!(updateDogForm.ShowDialog() == DialogResult.OK))
                    {
                        return;
                    }
                    else if(updateDogForm.GetDog() == null)
                    {
                        throw new Exception("Необходимо заполнить все поля ввода");
                    }
                    else
                    {
                        dogRep.Update(updateDogForm.GetDog());
                        updateDogForm.ClearTextboxes();
                        ShowDogs();
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                updateDogForm.ClearTextboxes();
            }
        }

        // Изменить кота
        private void котаToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows.Count != 1)
                {
                    throw new Exception("Необходимо выделить все ячейки, где содержится информация о коте");
                }
                else if (dataGridView2.SelectedRows.Count == 1)
                {
                    Cat cat = catRep.Get(Convert.ToInt32(dataGridView2.SelectedCells[0].Value));
                    updateCatForm = new UpdateCatForm(cat);
                    if (!(updateCatForm.ShowDialog() == DialogResult.OK))
                    {
                        return;
                    }
                    else if (updateCatForm.GetCat() == null)
                    {
                        throw new Exception("Необходимо заполнить все поля ввода");
                    }
                    else
                    {
                        catRep.Update(updateCatForm.GetCat());
                        updateCatForm.ClearTextboxes();
                        ShowCats();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                updateCatForm.ClearTextboxes();
            }
        }

        // Информация о коте
        private void оКотеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(!(getAnimalForm.ShowDialog() == DialogResult.OK))
                {
                    return;
                }
                else
                {
                    if(getAnimalForm.GetId() == -1)
                    {
                        throw new Exception("Необходимо заполнить поле для ввода");
                    }
                    else
                    {
                        Cat cat = catRep.Get(getAnimalForm.GetId());
                        MessageBox.Show($"Кот по кличке {cat.Name}, вес: {cat.Weight}.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                getAnimalForm.ClearTextbox();
            }
        }

        // Информация о собаке
        private void оСобакеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(getAnimalForm.ShowDialog() == DialogResult.OK))
                {
                    return;
                }
                else
                {
                    if (getAnimalForm.GetId() == -1)
                    {
                        throw new Exception("Необходимо заполнить поле для ввода");
                    }
                    else
                    {
                        Dog dog = dogRep.Get(getAnimalForm.GetId());
                        MessageBox.Show($"Собака по кличке {dog.Name}, возраст: {dog.Age}.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                getAnimalForm.ClearTextbox();
            }
        }

        //Вывод всех животных
        private void оВсехЖивотныхToolStripMenuItem_Click(object sender, EventArgs e) => ShowAllAnimals();

        // Выбор ORM технологии
        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        catRep = new DataRepositories.DBRepositories.ADO.CatRepository();
                        dogRep = new DataRepositories.DBRepositories.ADO.DogRepository();
                        MessageBox.Show($"Для взаимодействия с базой данных выбран {comboBox2.SelectedItem}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 1:
                    {
                        dogRep = new DataRepositories.DBRepositories.EF.Repositories.DogRepository();
                        catRep = new DataRepositories.DBRepositories.EF.Repositories.CatRepository();
                        MessageBox.Show($"Для взаимодействия с базой данных выбран {comboBox2.SelectedItem}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        catRep = new DataRepositories.DBRepositories.Dapper.CatRepository();
                        dogRep = new DataRepositories.DBRepositories.Dapper.DogRepository();
                        MessageBox.Show($"Для взаимодействия с базой данных выбран {comboBox2.SelectedItem}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
            }
            groupBox1.Visible = false;
        }
    }
}