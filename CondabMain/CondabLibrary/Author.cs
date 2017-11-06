using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondabLibrary
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public double AuthorAddress { get; set; }
        public class Item
        {

        }
        public double AuthorBalance { get; set; }
        public List<Item> Items { get; set; }
        public string PublicKey { get; set; }
        public bool ValidatedAuthor;

    }
}
