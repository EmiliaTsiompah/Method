using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarasi variabel
            int hasil;

            //membuat objek dari class Calculator
            Calculator calculator = new Calculator();

            hasil = calculator.Penjumlahan(10, 2);
            CetakHasil("Hasil penjumlahan: " + hasil);

            hasil = calculator.Penjumlahan(10, 2, 3);
            CetakHasil("Hasil penjumlahan overload: " + hasil);

            hasil = calculator.Pengurangan(7, 2);
            CetakHasil("Hasil pengurangan: " + hasil);

            hasil = Calculator.Perkalian(5, 2);
            CetakHasil("Hasil perkalian: " + hasil);


            void CetakHasil(string nilai)
            {
                Console.WriteLine(hasil);
            }
            Console.ReadKey();
            
        }
    }
}
