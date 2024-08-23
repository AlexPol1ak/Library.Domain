using Library.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities.Books
{
    /// <summary>
    /// Класс истории книги.
    /// </summary>
    public class BookHistory
    {
        private int bookHistoryId;
        private DateTime issueDate;
        private DateTime? returnDate;
      
        public int BookHistoryId 
        { 
            get => bookHistoryId;
            set => bookHistoryId = value; 
        }
        public DateTime IssueDate
        {
            get => issueDate; 
            set => issueDate = value;
        }
        public DateTime? ReturnDate 
        { 
            get => returnDate; 
            set => returnDate = value; 
        }
        public int? NumberDays      
        {
            get
            {
                if (returnDate == null) return null ;
                var d = ReturnDate - IssueDate;
                return Convert.ToInt32(d);
            } 

        }
        public string? Remarks { get; set; }

        public int BookId;
        public Book Book { get; set; }

        public int UserId;
        public User User { get; set; }  

        public BookHistory() { }

        public BookHistory(DateTime issueDate, DateTime? returnDate = null, string? remarks = null):this()
        {
            IssueDate = issueDate;
            ReturnDate = returnDate;
            Remarks = remarks;
        }
    }
}
