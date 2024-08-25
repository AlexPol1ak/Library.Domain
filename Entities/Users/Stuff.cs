using Library.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities.Users
{
    /// <summary>
    /// Класс сотрудника.
    /// </summary>
    public class Stuff: UserBase
    {      
        public bool IsAdmin {  get; set; } = true;

        private string hashPassword;
        /// <summary>
        /// Содержит хеш пароля. При установке пароля хеш вычисляется и записывается автоматически.
        /// </summary>
        public string Password 
        {
            get => hashPassword;
            set
            {
                hashPassword = PasswordHasher.HashPassword(value);
            }
        }
        public Stuff(string email, string Password, string firstName, string lastName,
            string? patronymic = null, bool isAdmin = true): base(email, firstName, lastName, patronymic)
        {
            this.Password = Password;
            IsAdmin = isAdmin;
        }

        public override string ToString()
        {
            string info = base.ToString() + ". Администратор: ";
            if (IsAdmin) info += "Да";
            else info += "Нет";
            return info;
        }

        /// <summary>
        /// Проверяет валидность пароля
        /// </summary>
        public bool VerifyPassword(string password)
        {
            return PasswordHasher.VerifyPassword(password, this.Password);
        }

        /// <summary>
        /// Проверяет валидность пароля.
        /// </summary>
        /// <param name="stuff"></param>
        public static bool VerifyPassword(Stuff stuff, string password)
        {
            return stuff.VerifyPassword(password);
        }

    }
}
