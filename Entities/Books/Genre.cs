using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities.Books
{
    /// <summary>
    /// Класс жанра.
    /// </summary>
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();

        public Genre() { }

        public Genre(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;

    }
}
