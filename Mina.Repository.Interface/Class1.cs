using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mina.Repository.Interface
{
    public interface IBaseRepository<T>
    {
        void Add(T Entity);
        List<T> GetAll();
    }
}
