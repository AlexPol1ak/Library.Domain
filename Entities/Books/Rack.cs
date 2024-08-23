using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities.Books
{
    public class Rack
    {
        public int RackId { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
        
        public Rack() { }

        public Rack(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;
        
    }
}
