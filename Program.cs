using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Console_Dersleri.Model;

namespace Console_Dersleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //adonet vs entity framework
            //code first vs dbfirst
            //ASP.NET CORE
            //DbFirst

            DbVisitEntities db = new DbVisitEntities();
            void listele()
            { 
                var values = db.TblCountry.ToList();
                foreach (var item in values)
                {
                Console.WriteLine(item.CountryId + "-" + item.CountryName + "-" + item.CountryCapital);
                Console.WriteLine("-------------------------------------------------");
                }
            }
            //--Sınıf--Prop--Value

            //TblPerson t = new TblPerson();
            //t.City = "İzmir";
            //t.Name = "Berat Yıldırım";
            //db.TblPerson.Add(t);
            //db.SaveChanges();


            //TblCountry t= new TblCountry();
            //t.CountryName = "İspanya";
            //t.CountryCapital = "Madrid";
            //db.TblCountry.Add(t);
            //db.SaveChanges();

            //Console.WriteLine("Silinecek değeri girin:");
            //int countryCode = Convert.ToInt32(Console.ReadLine());


            //var value=db.TblCountry.Find(countryCode);
            //db.TblCountry.Remove(value);
            //db.SaveChanges();

            //listele();

            Console.ReadLine();
        }
    }
}

