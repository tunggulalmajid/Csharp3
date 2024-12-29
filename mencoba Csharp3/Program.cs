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
        private List <string> dataUser = new List<string> { "ahmad", "boy", "charli", "doni" };
        static void Main(string[] args)
        {
            Program program = new Program();
            program.menu();
        }
        static void enter()
        {
            Console.Write("tekan enter untuk melanjutkan >> ");
            Console.ReadLine();

        }
        void menu()
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
        void cekData()
        {
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
        void tambahData()
        {
            Console.WriteLine("\t\t\tTAMBAH DATA\n\n");
            Console.Write("masukkan nama user baru >> ");
            string userBaru = Console.ReadLine();
            dataUser.Add(userBaru);
            Console.WriteLine("user baru berhasil ditambahkan");
            enter ();
            Console.Clear ();
            menu ();
        }
        void HapusData()
        {
            do
            {
                Console.WriteLine("\t\t\tHAPUS DATA\n\n");
                Console.WriteLine("Daftar User : ");
                for (int i = 0; i < dataUser.Count(); i++)
                {
                    Console.WriteLine($"{i + 1}. {dataUser[i]}");
                }
                Console.WriteLine("");
                Console.Write("Pilih data yang ingin dihapus >> ");
                int pilihanHapus = Convert.ToInt32(Console.ReadLine());
                if (pilihanHapus > 0 && pilihanHapus <= dataUser.Count())
                {
                    dataUser.RemoveAt(pilihanHapus - 1);
                    Console.WriteLine("user telah berhasil dihapus");
                    enter();
                    Console.Clear();
                    menu();
                    break;
                }
                else
                {
                    Console.WriteLine("inputan yang anda berikan tidak valid");
                    enter();
                    continue;
                }
            }while (true);
        }


    }
}
