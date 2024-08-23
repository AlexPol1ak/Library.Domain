using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities.Books
{
    /// <summary>
    ///  Правила выдачи
    /// </summary>
    public class Term
    {
        public int TermId { get; set; }
        public string ReadLocation {  get; set; }
        public int? MaximumDays { get; set; }

        public ICollection<Book> Books { get; set; }

        public Term() { }

        public Term(string readLocation, int? maximumDays = null)
        {
            ReadLocation = readLocation;
            MaximumDays = maximumDays;
        }

        public override string ToString()
        {
            string info = $"{ReadLocation}. Макс. количество суток: ";
            if (MaximumDays != null && MaximumDays > 0) 
                info += $"{MaximumDays}";
            else { info += "0"; }

            return info ;
        }
    }
}
