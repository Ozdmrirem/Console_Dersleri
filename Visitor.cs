using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dersleri
{
    class Visitor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public void mesaj(string p)
        { 
            Console.WriteLine(p);
        }
    }
}
