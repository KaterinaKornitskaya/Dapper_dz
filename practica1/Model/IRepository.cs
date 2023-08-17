using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1.Model
{
    // интерфейс для класса AuthorsRepository
    internal interface IRepository<T>
    {
        int Create(T obj);                       // создание автора, принимает объект
        int Delete(T obj);                       // удаление автора, принимает объект
        int Update(T obj, string a, string b);   // обновление автра, принимает объект
                                                 // и строки с именем и фамилией                                               
        IList<T> GetAll();                       // вывод всей коллекции, возвращает список
        IList<T> GetById(int id);                 // поиск по Id, возвращает список
        IList<T> GetByLastName(string lastName);  // поиск по фамилии, возвращает список
    }
}
