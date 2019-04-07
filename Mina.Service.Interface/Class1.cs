using Mina.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mina.Service.Interface
{
    public interface IDeptservice 
    {
        void Add(Dept dept);
        List<Dept> GetAll();
    }
}
