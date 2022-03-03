using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T t)
        {
            using var _context = new AppDbContext();
            _context.Add(t);
        }

        public void Delete(T t)
        {
            using var _context = new AppDbContext();
            _context.Remove(t);
            _context.SaveChanges();
        }

        public List<T> GetList()
        {
            using var _context = new AppDbContext();
            return _context.Set<T>().ToList();
        }

        public void Update(T t)
        {
            using var _context = new AppDbContext();
            _context.Update(t);
        }
    }
}
