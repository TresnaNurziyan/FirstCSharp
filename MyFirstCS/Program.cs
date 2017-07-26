using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCS
{
    class Program
    {
        static void Main(string[] args)
        {
            String nama;
            String alamat;
            int umur;
            String goldar;

            Console.Write("Masukan nama             : ");
            nama = Console.ReadLine();
            Console.Write("Masukan alamat           : ");
            alamat = Console.ReadLine();
            Console.Write("Masukan umur             : ");
            umur = int.Parse(Console.ReadLine());
            Console.Write("Masukan golongan darah   : ");
            goldar = Console.ReadLine();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Nama anda            : " + nama);
            Console.WriteLine("Alamat anda          : " + alamat);
            Console.WriteLine("Umur anda            : " + umur);
            Console.WriteLine("Golongan darah anda  : " + goldar);
            Console.WriteLine("--------------------------------------------------");

            Console.ReadLine();
        }
    }
}
