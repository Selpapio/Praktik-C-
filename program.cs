using System;

namespace LingkaranCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Kalkulator Lingkaran");

            // Input jari-jari lingkaran dari pengguna
            Console.Write("Masukkan jari-jari lingkaran: ");
            double jariJari = Convert.ToDouble(Console.ReadLine());

            // Menghitung luas lingkaran
            double luas = Math.PI * jariJari * jariJari;

            // Menghitung keliling lingkaran
            double keliling = 2 * Math.PI * jariJari;

            Console.WriteLine($"Luas lingkaran dengan jari-jari {jariJari} adalah {luas}");
            Console.WriteLine($"Keliling lingkaran dengan jari-jari {jariJari} adalah {keliling}");
        }
    }
}