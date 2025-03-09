using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dersleri
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HJ161GJ\\SQLEXPRESS;Initial Catalog=DbVisit;Integrated Security=True;Encrypt=False");

            void Listele()
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * from TblPerson", connection);
                //DataTable dt = new DataTable();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " | " + reader[1] + " | " + reader[2]);
                    Console.WriteLine("-------------------------------------------");
                }
                connection.Close();
            }

                //Ekleme İşlemi

                //connection.Open();
                //SqlCommand command2 = new SqlCommand("Insert into TblPerson (Name, City) values (@p1,@p2)", connection);
                //command2.Parameters.AddWithValue("@p1", "Mesut Kaya");
                //command2.Parameters.AddWithValue("@p2", "Elazığ");
                //command2.ExecuteNonQuery();
                //connection.Close();

                //Silme İşlemi

                //connection.Open();
                //SqlCommand command3 = new SqlCommand("Delete from TblPerson where Id=@p1", connection);
                //command3.Parameters.AddWithValue("@p1", 8);
                //command3.ExecuteNonQuery();
                //connection.Close();

                //Güncelleme İşlemi
                //connection.Open();
                //SqlCommand command4 = new SqlCommand("Update TblPerson set Name=@p1, City=@p2 where Id=@p3", connection);
                //command4.Parameters.AddWithValue("@p1", "Veli Bulut");
                //command4.Parameters.AddWithValue("@p2", "Kayseri");
                //command4.Parameters.AddWithValue("@p3", 1);
                //command4.ExecuteNonQuery();
                //connection.Close();

                //string name, city;
                //Console.WriteLine("****************");
                //Console.WriteLine();
                //Console.Write("Kişi Adı:");
                //name = Console.ReadLine();
                //Console.WriteLine();
                //Console.Write("Şehir:");
                //city = Console.ReadLine();
                //Console.WriteLine();
                //Console.WriteLine("Kişi sisteme başarılı bir şekilde eklendi.");
                //Console.WriteLine();
                //Console.WriteLine("****************");

                //connection.Open();
                //SqlCommand command5 = new SqlCommand("Insert into TblPerson (Name, City) values (@p1,@p2)", connection);
                //command5.Parameters.AddWithValue("@p1", name);
                //command5.Parameters.AddWithValue("@p2", city);
                //command5.ExecuteNonQuery();
                //connection.Close();

                //Listele();

                //Arama İşlemi
                //Console.WriteLine("*************************");
                //Console.WriteLine();
                //Console.Write("Aranacak şehri giriniz:");
                //string city = Console.ReadLine();
                //Console.WriteLine();
                //Console.WriteLine("*************************");
                //Console.WriteLine();
                //connection.Open();
                //SqlCommand command6 = new SqlCommand("Select * from TblPerson where City=@p1", connection);
                //command6.Parameters.AddWithValue("@p1", city);
                //SqlDataReader reader2=command6.ExecuteReader();
                //while (reader2.Read())
                //{
                //    Console.WriteLine(reader2[0] + " | " + reader2[1] + " | " + reader2[2]);
                //    Console.WriteLine("-------------------------------------------");
                //}

                //connection.Close();

                //connection.Open();
                //SqlCommand command7 = new SqlCommand("Select count(*) from TblPerson", connection);
                //SqlDataReader reader3 = command7.ExecuteReader();
                //while (reader3.Read())
                //{
                //    Console.WriteLine("Toplam Personel Sayısı: " + reader3[0]);
                //}
                //connection.Close();

                //connection.Open();

                //SqlCommand command8 = new SqlCommand("Select Avg(Price) from TblFlight", connection);
                //SqlDataReader reader4 = command8.ExecuteReader();
                //while (reader4.Read())
                //{
                //    Console.WriteLine("Ortalama Uçuş Fiyatı : " + reader4[0]);
                //}

                //connection.Close();

            //connection.Open();
            //SqlCommand command9 = new SqlCommand("Select City, Count(*) from TblPerson Group By City ", connection);
            //SqlDataReader reader5 = command9.ExecuteReader();
            //while (reader5.Read())
            //{
            //    Console.WriteLine(reader5[0] + " | " + reader5[1]);
            //    Console.WriteLine("-------------------------------------------");
            //}

            //connection.Close();


            Console.ReadLine();
                }
            }
        }

//Data Source=DESKTOP-HJ161GJ\SQLEXPRESS;Initial Catalog=DbVisit;Integrated Security=True;Encrypt=False