using LibraryProject.DAL.Interfaces;
using LibraryProject.DAL.Context;
using LibraryProject.DATA.Abstract;
using LibraryProject.DATA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.DAL.Concrete
{
    public class BaseRepo<T> : IBaseRepo<T> where T : BaseEntity
    {
        protected readonly LibraryContext _context;
        public BaseRepo(LibraryContext context)
        {
            _context = context;
        }


        public int Create(T entity)
        {
            if (entity is not null)
                _context.Add(entity);
            return _context.SaveChanges();

            throw new Exception("object is null");
        }

        public int Delete(T entity)
        {
            if (entity is not null)
                entity.isActive = false;
            return _context.SaveChanges();

            throw new Exception("object is null");
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChanges();

            throw new Exception("object is null");
        }
    }
}
