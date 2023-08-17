using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practica1.Model;

namespace practica1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        // обработчик кнопки Добавить автора
        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            using(AuthorsRepository rep = new AuthorsRepository())
            {
                rep.Create(new Author
                {
                    FirstName = textBoxName.Text,
                    LastName = textBoxSurname.Text,
                });
                listBoxShowAll.DataSource = rep.GetAll();
            }
        }

        // обработчик кнопки Показать всех авторов
        private void buttonShowAuthors_Click(object sender, EventArgs e)
        {
            using (AuthorsRepository rep = new AuthorsRepository())
            {
                listBoxShowAll.DataSource = rep.GetAll();
            }
        }

        // обработчик кнопки Поиск автора
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            using (AuthorsRepository rep = new AuthorsRepository())
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:  // поиск по Id
                        listBoxForSearch.DataSource = null;
                        listBoxForSearch.DataSource = (rep.GetById(Convert.ToInt32(textBoxSearch.Text)));
                        break;
                    case 1:  // поиск по фамилии
                        listBoxForSearch.DataSource = null;
                        listBoxForSearch.DataSource = (rep.GetByLastName(textBoxSearch.Text));
                        break;
                }
            }
        }

        // обработчик кнопки Удалить автора
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (AuthorsRepository rep = new AuthorsRepository())
            {
                // берем объект, выделенный пользвателем в списке
                Author obj = listBoxShowAll.SelectedItem as Author;
                // удаляем этот объект
                rep.Delete(obj);
                listBoxShowAll.DataSource = rep.GetAll();
            }
        }

        // обработчик кнопки Обновить автора
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (AuthorsRepository rep = new AuthorsRepository())
            {
                // берем объект, выделенный пользвателем в списке
                Author obj = listBoxShowAll.SelectedItem as Author;
                // обновляем этот объект
                rep.Update(obj, textBox1.Text, textBox2.Text);
                listBoxShowAll.DataSource = rep.GetAll();
            }
        }

        // обработчик кнопки Выбрать (выбрать конкретного автора и показать его книги)
        private void buttonThisAuthorBooks_Click(object sender, EventArgs e)
        {
            using (AuthorsRepository rep = new AuthorsRepository())
            {
                // кнопка переносит пользователь в доп.форму2
                Form3 form = new Form3();
                form.ShowDialog();
            }
        }
        
        // обработчик кнопки Показать (показать авторов и их книги)
        private void buttonAllAuthAllBooks_Click(object sender, EventArgs e)
        {
            using (AuthorsRepository rep = new AuthorsRepository())
            {
                // кнопка переносит пользователь в доп.форму2
                Form2 form = new Form2();
                form.ShowDialog();
            }
        }
    }
}
