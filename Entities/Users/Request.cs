using Library.Domain.Entities.Books;

namespace Library.Domain.Entities.Users
{
    /// <summary>
    /// Класс запросов выдачи книги.
    /// </summary>
    public class Request
    {
        public int RequestId { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? IssueDate { get; set; }

        // Читатель
        public int UserId;
        public User User { get; set; }
        // Книга.
        public int BookId { get; set; }
        public Book Book { get; set; }

        public Request(User user, Book book, DateTime dateCreated, DateTime? issueDate = null) : this()
        {
            DateCreated = dateCreated;
            IssueDate = issueDate;
            User = user;
            Book = book;
            UserId = user.UserId;
            BookId = book.BookId;
        }

        public Request() { }

        public override string ToString()
        {
            return $"Request ID: {RequestId}, User:{User.FullName} Book: {Book}";
        }
    }
}
