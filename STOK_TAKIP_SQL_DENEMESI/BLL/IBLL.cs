using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOK_TAKIP_SQL_DENEMESI.BLL
{
    internal interface IBLL<T,K> where T : class where K : class
    {
        bool insert (T entity);
        bool update (T entity);

        K Select();
        bool Delete(T entity);
        bool GetBack(int TableID,T entity);

    }
}
