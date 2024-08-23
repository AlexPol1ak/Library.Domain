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
        private string hashPassword;
       
        public bool IsAdmin {  get; set; } = true;
        public string Password 
        {  
            get => hashPassword;
            set => hashPassword = PasswordHasher.HashPassword(value);
        }

        public Stuff(string email, string password, string firstName, string lastName,
            string? patronymic = null, bool isAdmin = true): base(email, firstName, lastName, patronymic)
        {
            Password = password;
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
        /// Проверяет пароль.
        /// </summary>
        /// <param name="password">Не зашифрованый пароль</param>
        /// <returns></returns>
        public bool VerifyPassword(string password)
        {
            return PasswordHasher.VerifyPassword(password, Password);
        }
    }
}
