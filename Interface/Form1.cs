using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //interface;

        //class değillerdir.
        //constorları yoktur.
        //new instancelar alınamaz sadece miras verebilirler.
        //classlar sadece bir classtan miras alabilirlerken.
        //istedikleri kadar interfaceden miras alabilirler.
        //miras alınırken bir classdan alınıyorsa önce classlar sonra interfaceler yazılır.
        //interfaceler classlardan miras alamazlar.
        //ama interfacelerden miras alabilirler.
    }
}
