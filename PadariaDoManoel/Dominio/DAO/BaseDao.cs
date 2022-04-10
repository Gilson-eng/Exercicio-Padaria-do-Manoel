using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO
{
    class BaseDao
    {
        protected ApplicationContext _db;

        public BaseDao()
        {
            _db = ApplicationContext.GetInstance();
        }


    }
}
