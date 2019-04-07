using Mina.Entity;
using Mina.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mina.Dal;
using Mina.Repository.Interface;

namespace Mina.Repository
{
    public class DeptRepository : BaseRepository<Dept>, IDeptRepository
    {
        public DeptRepository(MinaSbContext dbcontext) : base(dbcontext)
        {
        }
    }
}
