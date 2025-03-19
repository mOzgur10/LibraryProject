using LibraryProject.DAL.Context;
using LibraryProject.DATA.Abstract;
using LibraryProject.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DAL.Concrete
{
    public class MemberRepo : BaseRepo<Member>
    {
        public MemberRepo(LibraryContext context) : base(context)
        {
        }
    }
}
