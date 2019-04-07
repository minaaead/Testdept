using Mina.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mina.Entity;
using Mina.Repository.Interface;

namespace Mina.Service
{
    public class Deptservice : IDeptservice
    {
        private readonly IDeptRepository deptrepo;
        public Deptservice(IDeptRepository deptrepo)
        {
            this.deptrepo = deptrepo;
        }
        public void Add(Dept dept)
        {
            deptrepo.Add(dept);
        }

        public List<Dept> GetAll()
        {
            return deptrepo.GetAll();
        }
    }
}
