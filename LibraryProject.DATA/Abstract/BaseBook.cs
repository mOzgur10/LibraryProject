using LibraryProject.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DATA.Abstract
{
    public abstract class BaseBook : BaseEntity
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public State State { get; set; }

        protected BaseBook(string isbn, string title, string author, int publicationYear, State state)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            State = state;
        }

        public override string ToString()
        {
            return $"{Title} - {Author} ({PublicationYear}) - ISBN: {ISBN}";
        }
    }
}
