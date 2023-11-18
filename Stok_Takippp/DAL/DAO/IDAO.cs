using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takippp.DAL.DAO
{
    public interface IDAO<T,K> where T : class where K : class
    {
        List<T> select();
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool GetBack(int ID);


    }
}
