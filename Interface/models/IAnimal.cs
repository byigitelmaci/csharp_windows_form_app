using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.models
{
    internal interface IAnimal
    {

        // visual studio 2017 ve altı için
        // interfacelerde oluşturulan metotların yaşam alanları olamaz.

        // visual studio 2019 ve üstü için
        // default değer atanabilir.


        void Ses();

    }
}
