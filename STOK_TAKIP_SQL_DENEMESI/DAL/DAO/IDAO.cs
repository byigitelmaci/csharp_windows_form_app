using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOK_TAKIP_SQL_DENEMESI.DAL.DAO
{
    internal interface IDAO<T,K> where T : class where K : class
    {
        List<K> select();
        bool Insert (T entity);
        bool Update (T entity);
        bool Delete (T entity);
        bool GetBack (int ID);
    }
}
