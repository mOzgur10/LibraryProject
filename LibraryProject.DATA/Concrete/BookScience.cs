using LibraryProject.DATA.Abstract;
using LibraryProject.DATA.Enums;
using LibraryProject.DATA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DATA.Concrete
{
    public class BookScience : BaseBook, IBook
    {
        public BookScience(string isbn, string title, string author, int publicationYear, State state) : base(isbn, title, author, publicationYear, state)
        {
            State = State.Available;
        }

        public State State { get ; set ; }
    }
}
