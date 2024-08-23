using Library.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities.Users
{
    /// <summary>
    /// Базовый класс пользователя
    /// </summary>
    public class UserBase : IBaseUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Patronymic { get; set; }
        public string Email { get; set; }
        public string FullName => $"{LastName} {FirstName} {Patronymic ?? ""}";

        public UserBase(string email, string firstName, string lastName, string? patronymic=null): this()
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Email = email;
        }

        public UserBase() { }

        public override string ToString() => FullName;

    }
}
