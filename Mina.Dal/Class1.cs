using Mina.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mina.Dal
{
    public class MinaSbContext:DbContext
    {
        public MinaSbContext():base("DefaultConnection")
        {
        }

        public DbSet<Dept> Depts { get; set; }
    }
}
