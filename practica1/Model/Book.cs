using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1.Model
{
    internal class Book
    {
        // класс Книга
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearPress { get; set; }
        public int id_Author { get; set; }

        public override string ToString()
        {
            return $"(Id: {Id}) {Name} {YearPress} {id_Author}";
        }
    }
}
