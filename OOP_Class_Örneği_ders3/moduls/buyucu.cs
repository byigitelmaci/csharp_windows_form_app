using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Örneği_ders3.moduls
{
    internal class buyucu
    {
        public string oyuncuismi { get; set; }
        public string brans { get; set; }
        public string ırk { get; set; }
        public string silah { get; set; }
        public int saldırıgucu { get; set; }


        //buyucum ne yapabilir???
        
        public void Saldir()
        {
            switch(brans)
            {
                case "karabuyu":
                    saldırıgucu = 50;
                    break;
                case "defansif":
                    saldırıgucu = 10;
                    break;
                case "ayyıldız":
                    saldırıgucu = 300;
                    break;
                case "dolunay":
                    saldırıgucu = 100;
                    break;
                case "yıldıray":
                    saldırıgucu = 60;
                    break;
                case "diriliş":
                    saldırıgucu = 70;
                    break;
                default:
                    saldırıgucu = 30;
                    break;
            }
        }


    }
}
