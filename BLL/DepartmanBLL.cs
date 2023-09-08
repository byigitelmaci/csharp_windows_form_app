using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_;
using DAL_.DAO;

namespace BLL
{
    public class DepartmanBLL
    {
        public static void DepartmanEkle(Departman dpt)
        {
            
            DepartmanDAO.DepartmanEkle(dpt);
            

        }

        public static List<Departman> DepartmanGetir()
        {
            return DepartmanDAO.DepartmanGetir();
        }
    }
}
