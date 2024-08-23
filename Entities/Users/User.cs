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


        /// <summary>
        /// Добавляет заявку на книгу пользователю
        /// </summary>
        /// <param name="request"></param>
        /// <returns>True- если заявка добавлена, иначе False</returns>
        public bool addRequest(Request request)
        {
            if (!this.Requests.Contains(request))
            {
                this.Requests.Add(request);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Добавляет заявки на книги пользователю
        /// </summary>
        /// <param name="requests">Заявки на книги</param>
        /// <returns>Количество добавленых заявок пользователю</returns>
        public int addRequests(params Request[] requests)
        {
            int counter = 0;
            if (requests.Count() > 0)
            {
                foreach (Request request in requests)
                {
                    if(addRequest(request)) counter++;
                }
            }

            return counter;             
        }

        /// <summary>
        /// Добавляет заявки на книги пользователю
        /// </summary>
        /// <param name="requests"> Коллекция заявок на книги</param>
        /// <returns>Количество добавленых заявок пользователю</returns>
        public int addRequests(ICollection<Request> requests)
        {
            int counter = 0;
            if (requests.Count() > 0)
            {
                foreach (Request request in requests)
                {
                    if (addRequest(request)) counter++;
                }
            }

            return counter;
        }
    }


}
