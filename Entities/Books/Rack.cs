﻿namespace Library.Domain.Entities.Books
{
    /// <summary>
    /// Класс жанра
    /// </summary>
    public class Rack
    {
        public int RackId { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();

        public Rack() { }

        public Rack(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;

    }
}
