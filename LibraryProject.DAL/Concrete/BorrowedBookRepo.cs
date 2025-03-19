using LibraryProject.DAL.Context;
using LibraryProject.DATA.Abstract;
using LibraryProject.DATA.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DAL.Concrete
{
    public class BorrowedBookRepo : BaseRepo<BorrowedBook>
    {
        public BorrowedBookRepo(LibraryContext context) : base(context)
        {
        }
        public BorrowedBook GetByBookIdAndUserId(int bookId, int userId)
        {
            return _context.BorrowedBooks
                           .FirstOrDefault(bb => bb.BookId == bookId && bb.MemberId == userId);
        }
    }
}
