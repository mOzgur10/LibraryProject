using LibraryProject.DAL.Context;
using LibraryProject.DATA.Abstract;
using LibraryProject.DATA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DAL.Concrete
{
    public class BookRepo : BaseRepo<BaseBook>
    {
        public BookRepo(LibraryContext context) : base(context)
        {
        }


    }
}
