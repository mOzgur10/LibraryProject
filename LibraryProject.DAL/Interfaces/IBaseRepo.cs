using LibraryProject.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DAL.Interfaces
{
    public interface IBaseRepo<T> where T : BaseEntity
    {
        int Create(T entity);
        int Update(T entity);
        int Delete(T entity);

        T GetById(int id);
    }
}
