using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {

                Console.WriteLine("Lütfen kilonuzu girin:");
                double kilo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Lütfen boyunuzu metre cinsinden giriniz:");
                double boy = Convert.ToDouble(Console.ReadLine());

                double bmi = kilo / (boy * boy);

                Console.WriteLine($"Vücut kitle indeksiniz {bmi} dir.");


                if (bmi > 0 && bmi <= 18.4)
                {
                    Console.WriteLine("Zayıf");
                }
                else if (bmi > 18.4 && bmi <= 24.9)
                {
                    Console.WriteLine("Normal");
                }
                else if (bmi > 24.9 && bmi <= 29.9)
                {
                    Console.WriteLine("Kilolu");
                }
                else if (bmi > 29.9 && bmi <= 34.9)
                {
                    Console.WriteLine("1. derece obez");
                }
                else if (bmi > 34.9 && bmi <= 44.9)
                {
                    Console.WriteLine("2. derece obez");
                }
                else if (bmi > 44.9 && bmi<=49.9)
                {
                    Console.WriteLine("3. derece obez");
                }
                else
                {
                    Console.WriteLine("Hata oluştu.");
                }

            }
            catch (FormatException)
            {

                Console.WriteLine("Lütfen sayısal değer giriniz");
            }
            Console.ReadLine();
        }
    }
}
