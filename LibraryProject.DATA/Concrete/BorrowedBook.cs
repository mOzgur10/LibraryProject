using LibraryProject.DATA.Abstract;
using LibraryProject.DATA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DATA.Concrete
{
    public class BorrowedBook : BaseEntity
    {
        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int BookId { get; set; }
        public BaseBook Book { get; set; }

        public DateTime BorrowDate { get; set; } = DateTime.Now;
        public DateTime? ReturnDate { get; set; }
    }
}
