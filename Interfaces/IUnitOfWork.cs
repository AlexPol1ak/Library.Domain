﻿using Library.Domain.Entities.Books;
using Library.Domain.Entities.Users;
using System.Linq.Expressions;

namespace Library.Domain.Interfaces
{
    /// <summary>
    /// Интерфейс единицы работы.
    /// </summary>
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
