using DAL1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL1.DAO;

namespace BLL1
{
    public class DepartmanBLL1
    {
        public static void DepartmanEkle(DEPARTMAN dpt)
        {
            DepartmanDAO1.DepartmanEkle(dpt);
        }

        public static List<DEPARTMAN> DepartmanGetir()
        {
            return DepartmanDAO1.DepartmanGetir();
        }
    }
}
