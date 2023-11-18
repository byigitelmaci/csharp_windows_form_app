using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takippp.BLL
{
    public interface IBLL<T,K> where T:class where K : class
    {
        bool insert (T entity);
        bool update (T entity);
        K select();
        bool delete (T entity);
        bool GetBack(int TableID,T  entity);


    }
}
