﻿using Library.Domain.Entities.Books;
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
        IRepository<User> UserRepository { get; }
        IRepository<Stuff> StuffRepository { get; }
        IRepository<Request> PhotosRepository { get; }
        IRepository<Author> AuthorRepository { get; }
        IRepository<Book> BookRepository { get; }
        IRepository<BookHistory> BookHistoryRepository { get; }
        IRepository<Genre> GenreRepository { get; }
        IRepository<Rack> RackRepository { get; }
        IRepository<Term> TermRepository { get; }

        void SaveChanges();

        void LoadRelatedEntities<T, TProperty>(T entity, Expression<Func<T, IEnumerable<TProperty>>> navigationProperty)
          where T : class
          where TProperty : class;
    }
}