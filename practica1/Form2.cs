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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // форма инициализируется вызовом метода Показать всех авторов и их книги
            using (AuthorsRepository rep = new AuthorsRepository())
            {
                listBoxAllAuthAllBooks.DataSource = (rep.AllAuthorBooks().ToList());
            }
        }

        // обработчик кнопки Закрыть (текущую форму2)
        private void buttonCloseForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
