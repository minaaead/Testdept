using Mina.Dal;
using Mina.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mina.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class 
    {
        private readonly MinaSbContext dbcontext;
        public BaseRepository(MinaSbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public void Add(T Entity)
        {
            dbcontext.Set<T>().Add(Entity);
            dbcontext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return dbcontext.Set<T>().ToList();
        }
    }
}
