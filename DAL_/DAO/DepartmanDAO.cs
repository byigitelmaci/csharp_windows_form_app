using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_.DAO
{
    public class DepartmanDAO : PersonelDataContext
    {
        public static void DepartmanEkle(Departman dpt)
        {
            try
            {
                db.Departmans.InsertOnSubmit(dpt);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }

        public static List<Departman> DepartmanGetir()
        {
            try
            {
                return db.Departmans.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
