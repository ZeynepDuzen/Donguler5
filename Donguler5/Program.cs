using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sayinin faktoriyel degerini hesaplayan kod blogu

            int sayi;
            Console.WriteLine("Lutfen faktoriyelini hesaplamak istediginiz bir sayi giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());

            int i;
            int faktoriyel = 1;

            for (i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }

            Console.WriteLine(faktoriyel);


            Console.Read();
        }
    }
}
