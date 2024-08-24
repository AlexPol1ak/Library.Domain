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
        public string HashPassword { get; set; }
        public Stuff(string email, string hashPassword, string firstName, string lastName,
            string? patronymic = null, bool isAdmin = true): base(email, firstName, lastName, patronymic)
        {
            HashPassword = hashPassword;
            IsAdmin = isAdmin;
        }

        public override string ToString()
        {
            string info = base.ToString() + ". Администратор: ";
            if (IsAdmin) info += "Да";
            else info += "Нет";
            return info;
        }

    }
}
