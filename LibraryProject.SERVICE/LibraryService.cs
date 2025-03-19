using LibraryProject.DAL.Concrete;
using LibraryProject.DATA.Concrete;
using LibraryProject.DATA.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.SERVICE
{
    public class LibraryService
    {
        private readonly BookRepo _bookRepo;
        private readonly MemberRepo _memberRepo;
        private readonly BorrowedBookRepo _borrowedBookRepo;

        public LibraryService(BookRepo bookRepo, MemberRepo memberRepo, BorrowedBookRepo borrowedBookRepo)
        {
            _bookRepo = bookRepo;
            _memberRepo = memberRepo;
            _borrowedBookRepo = borrowedBookRepo;
        }

        public void BorrowBook(int userId, int bookId)
        {
            var book = _bookRepo.GetById(bookId);

            

            if (book == null)
            {
                throw new Exception("Kitap bulunamadı!");
            }

            if (book.State == State.Borrowed)
            {
                throw new Exception("Bu kitap zaten ödünç alınmış!");
            }
            else
            {
                book.State = State.Borrowed;
            }
            BorrowedBook borrowedBook = new BorrowedBook
            {
                MemberId = userId,
                BookId = bookId,
                BorrowDate = DateTime.Now,
            };

            _borrowedBookRepo.Create(borrowedBook);

        }

        public void ReturnBook(int userId, int bookId)
        {
            var borrowedBook = _borrowedBookRepo.GetByBookIdAndUserId(bookId, userId);

            if (borrowedBook == null)
            {
                throw new Exception("Bu kitap ödünç alınmamış!");
            }

            var book = _bookRepo.GetById(bookId);
            if (book == null)
            {
                throw new Exception("Kitap bulunamadı!");
            }
            
            book.State = State.Available;
            _borrowedBookRepo.Delete(borrowedBook); 
        }
    }
}
