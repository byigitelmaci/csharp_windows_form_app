using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Property_ve_Field_Kavramları.models
{

    public class product
    {
        //local veriable
        //field
        int b; //field
               //property

        int _c; //property
        //propertyler içlerimde hiçbir zaman veri tutmazlar!!!!!!!!!!!!!
        //ramdeki bir değeri getiriyolar...........



        public int c //property
        {
            get     //getirmek
            {
                return _c;
            }
            set    //set etmek atamak güncellemek
            {
                _c = value;
            }
        }
        public int d { get; set; }


        public product()
        {
            int a = 25;//local variable
            
            c = 12;
        }



    }
}
