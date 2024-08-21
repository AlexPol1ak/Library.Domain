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
        private string hashPassword = string.Empty;
        public bool IsAdmin {  get; set; } = true;
        public string HashPassword 
        {  
            get => hashPassword;
            set => hashPassword = PasswordHasher.HashPassword(value);
        }
    }
}
