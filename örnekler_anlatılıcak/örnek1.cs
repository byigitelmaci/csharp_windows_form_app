using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örnekler_anlatılıcak
{
    public class örnek1
    {
        //this
        //public int x;

        //public örnek1 (int x) 
        //{
        //    this.x = x; this.x diyo ki yani bunu burda kullanabilirsin 
        //}

        //------------------------------------------------------------------------

        //return

        //public void Main(int uhf)
        //{
        //    toplamayap(6, 7);   burda sayi1 e 6 değerini atıyo sayi 2 ye 7 değerini atıyo

        //}

        //public  int toplamayap(int sayi1, int sayi2)
        //{
        //    int sonuc = sayi1 + sayi2;

        //    return sonuc;     burda da değeri geri döndürerek sonucu ekrana basıyo
        //}

        //-----------------------------------------------------------------------------

        //fonksiyon

        //static void yigit()
        //{
        //    Console.WriteLine("yigit");
        //}

        //--------------------------------------------------------------------------------
        //construction

        //public örnek1()
        //{
        //    sayi = 1;     
        //}
        //public int sayi { get; set; }   burdaki property ye değer ataması yapmak için kullanılır/class ismiyle aynı isme sahip

        //----------------------------------------------------------------------------------

        //interface defterde var bak

        //public interface sayilar
        //{
        //    void ses
        //}

        //public abstract class baseclass
        //{
        //    public int sayi { get; set; }
        //}

        //public class islem:baseclass,sayilar = bunu implement ediyoruz
        //{
                //public void ses
                //{
                        //throw new Not ImplementedException
                //}     
        //}


        //----------------------------------------------------------------------------------------
        //Dto

        //public class OgrenciDTO
        //{
        //    public string Ad { get; set; }
        //    public string Soyad { get; set; }
        //    public int yas { get; set; }
        //    public DateTime DogumTarihi { get; set; }
        //}

        //-----------------------------------------------------------------------------

        //entity framework
        //DTO ile sql arası bağlantıyı sağlayan şeydir

        //------------------------------------------------------------------------------
        //linq


        //private void txthayvanadi_textchanged (object senter,EventArgs e);
        //{
        //      string aranan=txthayvanadi.text;
        //      var degerler =from item in db.tblhayvan  =tblhayvan tablosundan seç 
        //                    select item;

        //      datagridwiew1.datasource = degerler.tolist  = bütün değerleri datagridwiew e bas
        //}

        //----------------------------------------------------------------------------------
        //solid presipleri

        //Single Responsibility Principle (Tek Sorumluluk Prensibi)==sadece onun görevi olanları 
        // class hayvanlar
        // {
        //      public void köpek (string adı, string uzunluk,string kanat uzunluğu) { } burda kanat gereksiz kullanılmıştır bu hayvan bölümünde olması lazım
        //      public void kuş(string adı, string uzunluk)
        //}


        //----------------------------------------------------------------------------
        //oop nin temel konuları
        //encapsulation(kapsülleme)
        //private=sadece bulunduğu sınıf içerisinde kullanılır
        //public=heryerden erişilebilir
        //protected=bulunduğu projeye kalıtım verilerek kullanılır
        //internal=program içerisinde heryerden kullanlır
        //protected internal=kalıtım vererek diğer projelerde de kullanılır


        //public string ad { get; set; }
        //private string MyProperty { get; set; }
        //protected string MyProperty1 { get; set; }
        //internal string MyProperty2 { get; set; }
        //protected internal string MyProperty3 { get; set; }
        //private protected string MyProperty4 { get; set; }

        //public örnek1()
        //{

        //}
        //-----------------------------------------------------------
        //abstraction    sadece kalıtım vericeğimiz sınıfsa bunu kullanıyoruz
        //public abstract class araba
        //{
        //    public string marka { get; set; }
        //    public int uzunluk { get; set; }
        //    public string renk { get; set; }
        //    public int tekersayisi { get; set; }

        //}


        //--------------------------------------------------------------
        //inharitance= kalıtım miras

        //public class arac
        //{
        //      public string marka { get; set; }
        //      public int tekersayisi { get; set; }

        //} 

        //public class motor:arac
        //{
        //      public int koltuk sayisi { get; set; }
        //      public int depolitresi { get; set; }
        //}


        //public class araba:motor
        //{
        //      public int bagajhacmi { get; set; }
        //}



    }
}
