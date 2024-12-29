using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mencoba_Csharp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ini array
            //string[] kata = { "aku", "makan", "minum", "tidur" };
            //foreach (string s in kata)
            //{
            //    Console.Write($"{s} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"panjang dari array : {kata.Length}");

            //// ini list
            //List<string> kata3 = new List<string>();
            //kata3.Add("ahmad");                                                                                                                                  
            //kata3.Add("jaja");
            //Console.WriteLine(kata3.Contains("jaja"));
            //Console.WriteLine(kata3.Count());          
            ////foreach (string s in kata3)
            //{ 
            //    //Console.WriteLine(s);
            //}
            menu();
        }
        static void enter()
        {
            Console.Write("tekan enter untuk melanjutkan >> ");
            Console.ReadLine();

        }
        static void menu()
        {
            do
            {
                Console.WriteLine("\t\t\tPROGARAM SEDERHANA\n\n");
                Console.WriteLine("MENU : \n\n1. Cek Data\n2. Tambah data\n3. Hapus data\n4. Keluar\n".ToUpper());
                Console.Write("masukkan opsi yang ingin dipilih >> ");
                int opsiPilihan = Convert.ToInt32(Console.ReadLine());
                if (opsiPilihan == 1)
                {
                    enter();
                    Console.Clear();
                    cekData();
                    break;
                }
                else if (opsiPilihan == 2)
                {
                    enter();
                    Console.Clear();
                    tambahData();
                    break;

                }
                else if (opsiPilihan == 3)
                {
                    enter();
                    Console.Clear();
                    HapusData();
                    break;

                }
                else if (opsiPilihan == 4)
                {
                    enter();
                    Console.Clear();
                    Console.WriteLine("terima kasih telah menggunakan program ini");
                    enter();
                    break;

                }
                else
                {
                    Console.WriteLine("opsi yang anda pilih tidak tersedia");
                    enter();
                    Console.Clear();
                    continue;
                }
            }while (true);
        }
        static List<string> data()
        {
            List<string> dataUser = new List<string> { "ahmad", "boy", "charli", "doni" };
            return dataUser;
        }
        static void cekData()
        {
            
            List<string> dataUser = data();
            Console.WriteLine("\t\t\tCEK DATA\n\n");
            Console.WriteLine("Daftar User : ");
            for (int i = 0; i < dataUser.Count();i++) 
            {
                Console.WriteLine($"{i+1}. {dataUser[i]}");
            }
            enter();
            Console.Clear ();
            menu();
        }
        static void tambahData()
        {
            List<string> dataUser = data();
            Console.Write("masukkan nama user baru >> ");
            string userBaru = Console.ReadLine();
            dataUser.Add(userBaru);
            Console.WriteLine("user baru berhasil ditambahkan");
            enter ();
            Console.Clear ();
            menu ();

        }
        static void HapusData()
        {

        }


    }
}
