using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities.Books
{
    /// <summary>
    /// Класс автора
    /// </summary>
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string? Patronymic { get; set; }
        public string FullName => $"{LastName} {FirstName} {Patronymic ?? ""}";
        public string ShortName =>
                $"{(string.IsNullOrEmpty(LastName) ? "" : LastName)} " +
                $"{(string.IsNullOrEmpty(FirstName) ? "" : FirstName.First() + ". ")}" +
                $"{(string.IsNullOrEmpty(Patronymic) ? "" : Patronymic.First() + ".")}";

        public ICollection<Book> Books { get; set; } = new List<Book>();

        public Author(string firstName, string lastName, string? patronymic): this()
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
        }

        public Author() { }

        public override string ToString() => ShortName;

    }
}
