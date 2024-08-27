using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities.Books
{
    /// <summary>
    /// Класс книги
    /// </summary>
    public class Book
    {       
        public int BookId { get; set; }
        public string Name { get; set; }
        public int NumberPages {  get; set; }
        public int PublicationDate {  get; set; }
        public string? Description { get; set; }

        // Жанр
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
        //Стелаж
        public int? RackId { get; set; }
        public Rack? Rack { get; set; }

        // Правила выдачи
        public int TermId {  get; set; }
        public Term Term { get; set; }

        // Истории выдач
        public ICollection<BookHistory> BookHistory { get; set; }=new List<BookHistory>();

        // Авторы
        public ICollection<Author> Authors { get; set; } = new List<Author>();

        public Book() { }

        public Book(string name, int numberPages, string? description = null):this()
        {
            Name = name;
            NumberPages = numberPages;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name}. Страниц {NumberPages}";
        }

    }
}
