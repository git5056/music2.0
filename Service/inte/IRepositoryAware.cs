using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.inte
{
    public interface IRepositoryAware<T>
    {
        Manager.inte.IRepository<T> Repository { set; }
    }
}
