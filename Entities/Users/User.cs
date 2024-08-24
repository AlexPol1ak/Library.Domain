using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities.Users
{
    /// <summary>
    /// Класс пользователя-читателя.
    /// </summary>
    public class User : UserBase
    {
        public ICollection<Request> Requests { get; set; } = new List<Request>();
    }

}
