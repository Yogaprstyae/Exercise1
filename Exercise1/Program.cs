using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        // deklarasi array int dengan ukuran 92
        private int[] yoga = new int[92];
        // deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;
        //// fungsi method untuk menerima masukan
        public void read()
        {
            // menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                // Input berapa banyak elemen array 
                Console.Write("Masukkan banyaknya elemen pada array : ");
                string s = Console.ReadLine();
                n = int.Parse(s);
                if (n <= 92)
                    break;
                else
                    Console.WriteLine("\n Array dapat mempunyai maksimal 92 elemen. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Masukkan elemen Array");
            Console.WriteLine("---------------------");

            // pengguna masukkan elemen pada Array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                yoga[i] = int.Parse(s1);
            }

        }
        public void display()
        {
            // menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Elemen Array yang Tersususn");
            Console.WriteLine("---------------------------");
            for (int my = 0; my < n; my++)
            {
                Console.WriteLine(yoga[my]);
            }
            Console.WriteLine("");
        }
        public void Insertion()
        { 
            for (int i = 0; i < n - 1; i++)
            {
                int temp, z;
                z = i;

                for (int my = i + 1; my < n; my++)
                {
                    if (yoga[my] <= yoga[z])
                    {
                        z = my;
                    }
                }
                //swap
                temp = yoga[z];
                yoga[z] = yoga[i];
                yoga[i] = temp;
            }
        }


        static void Main(string[] args)
        {
            Program P = new Program();
            P.read();
            P.Insertion();
            P.display();
            Console.WriteLine("\n\n Tekan tombol apa saja untuk keluar. ");
            Console.Read();
        }
    }
}
