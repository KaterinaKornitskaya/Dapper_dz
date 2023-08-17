using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1.Model
{
    // класс AuthorsRepository - класс-посредник с БД, реализует
    // написанный интерфейс IRepository<T>, и стандартный IDisposable
    internal class AuthorsRepository : IRepository<Author>, IDisposable
    {
        // создаем ссылку для строки подключения
        SqlConnection conn = null;

        // в конструкторе выделяем место и инициализируем строку подключения
        public AuthorsRepository()
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;
        }

        // метод Создание автора
        public int Create(Author obj)
        {
            // создаем строку запрос
            string sql_command = "INSERT INTO Authors(FirstName, LastName) VALUES (@FirstName, @LastName)";
            // выполняем подключение и запрос
            return conn.Execute(sql_command, obj);
        }

        // метод Удаление автора
        public int Delete(Author obj)  
        {
            // создаем строку-запрос
            string sql = "DELETE FROM Authors WHERE ID = @Id";
            // выполняем подключение и запрос
            return conn.Execute(sql, obj);
        }

        // реализация стандартного метода Dispose()
        public void Dispose()
        {
            conn?.Dispose();
        }

        // метод для получения всего списка авторов
        public IList<Author> GetAll() 
        {
            // создаем строку-запрос
            string sql_command = "SELECT * FROM Authors";
            // метод Query возвращает IEnumerable<Author>, затем преобразуем к Листу
            var authors = conn.Query<Author>(sql_command).ToList();
            // возвращаем список авторов
            return authors;
        }

        // метод для поиска автора по id
        public IList<Author> GetById(int id)
        {
            // создаем список и выделяем место для него
            IList<Author> list = new List<Author>();
            // создаем строку-запрос
            string sql = "SELECT * FROM Authors WHERE Id = @Id";

            // метод QueryFirstOrDefault() возвращает первое совпадение
            // из таблицы Автор, где Id равен переданному id
            var res = conn.QueryFirstOrDefault<Author>(sql, new { Id = id });
            // здесь можно было вернуть просто объект, или строку выше преобразовать
            // к ToString(), но у меня в листБокс должен выводится или результат
            // поиска по Id, или результат поиска по фамилии. И два этих метода
            // должны вернуть одинаковый тип, чтобы нормально вывести в листБоксе.
            // Поиск по фамилиям однозначно должен вернуть список, поэтому и результат
            // поиска по Id я тоже привожу к списку

            // добавляем найденного автора в список
            list.Add(res);
            // возвращаем список
            return list;
        }

        // поиск по фамилии
        public IList<Author> GetByLastName(string name)
        {
            // создаем строку-запрос
            string sql = "SELECT * FROM Authors WHERE LastName = @LastName";

            // метод Query<Author>() вернет коллекцию авторов, где 
            // LastName равен введенному name, коллекцию преобразуем к списку
            var res = conn.Query<Author>(sql, new { LastName = name }).ToList();
            // возвращаем список
            return res;
        }

        // метод для изменения данных автора
        public int Update(Author obj, string fName, string lName)
        {
            // создаем строку-запрос
            string sql = $"UPDATE Authors SET FirstName = '{fName}', LastName = '{lName}' WHERE Id = @Id";
            // выполняем подключение и запрос
            return conn.Execute(sql, obj);
        }

        // метод для вывода всех книг конкретного автора
        public List<string> ThisAuthorBooks(int id)
        {
            // создаем список и выделяем для него место
            List<string> list = new List<string>();
            // создаем строку-запрос, состоящую из двух запросов
            string sql = $"select * from Authors where Id = '{id}'"
                + $"select Id, Name, YearPress, Id_Author from Books where id_Author = '{id}'";

            // метод QueryMultiple() для выполнения нескольких запросов
            var res = conn.QueryMultiple(sql, new { Id = id });

            // получаем объект - конкретного автора
            var author = res.ReadSingle<Author>();
            // получаем коллекцию книг этого автора, преоьразуем к Листу
            author.Books = res.Read<Book>().ToList();

            list.Add("Автор: ");
            // добавляем в список Автора, преобразованного к строке
            list.Add(author.ToString());
            list.Add("Книги: ");
            // цикл по коллекции книг данного автора
            foreach(var item in  author.Books)
            {
                // добавляем в список книги, преобразованные к строке
                list.Add(item.ToString());
            }
            // возвращаем список (один автор и его книги)
            return list;
        }

        // метод для показа всех авторов (у которых есть книги), и книг для каждого автора
        public List<string> AllAuthorBooks()
        {
            // создаем список и выделяем для него место
            List<string> list = new List<string>();
            // создаем строку-запрос
            var sql = "SELECT * FROM Authors JOIN Books ON Authors.Id = Books.Id_Author";

            // создаем Словарь
            var authors = new Dictionary<int, Author>();

            var result = conn.Query<Author, Book, Author>(sql,(author, book) => 
            {
                // объект автора для выходящего параметра
                Author authorEntry;

                if (!authors.TryGetValue(author.Id, out authorEntry))
                {
                    authors.Add(author.Id, author);
                    author.Books = new List<Book>();
                    authorEntry = author;
                }
                authorEntry.Books.Add(book);
                return authorEntry;
            },
            splitOn: "Id"
            );

            // цикл по парам словаря
            foreach (var pair in authors)
            {
                var author = pair.Value;
                list.Add("Автор: ");
                // добавляем в список автора (преобразованного к строке)
                list.Add(author.ToString());
                list.Add("Книги: ");
                // цикл по книгам этого автора)
                foreach (var book in author.Books)
                {
                    // добавляем в список книги этого автора (преобразованные к строке)
                    list.Add(book.ToString());
                }
            }
            // возвращаем список
            return list;
        }
    }
}
