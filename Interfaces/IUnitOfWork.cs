using Library.Domain.Entities.Books;
using Library.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<User> UsersRepository { get; }
        IRepository<Stuff> StuffRepository { get; }
        IRepository<Request> RequestsRepository { get; }
        IRepository<Author> AuthorsRepository { get; }
        IRepository<Book> BooksRepository { get; }
        IRepository<BookHistory> BookHistoriesRepository { get; }
        IRepository<Genre> GenresRepository { get; }
        IRepository<Rack> RacksRepository { get; }
        IRepository<Term> TermsRepository { get; }

        void SaveChanges();

        void LoadRelatedEntities<T, TProperty>(T entity, Expression<Func<T, IEnumerable<TProperty>>> navigationProperty)
          where T : class
          where TProperty : class;
    }
}
