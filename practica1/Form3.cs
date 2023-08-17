using practica1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // обработчик кнопки Закрыть (текущую форму2)
        private void buttonCloseForm3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // обработчик кнопки Показать
        private void button1_Click(object sender, EventArgs e)
        {
            // вызываем метод Показать конкретного автора и его книги, передаем Id  автора
            using (AuthorsRepository rep = new AuthorsRepository())
            {
                listBoxOneAuthallBooks.DataSource = 
                    (rep.ThisAuthorBooks(Convert.ToInt32(textBoxOneAuthForAllBooks.Text))).ToList();
            }
        }
    }
}
