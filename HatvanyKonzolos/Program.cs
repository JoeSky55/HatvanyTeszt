using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HatvanyKonzolos
{
    public class PowerCalculator
    {
        public double CalculatePower(double basee, double exponent)
        {
            double eredmeny = 1;
            if (exponent > 0)
            {
                for (double i = 0; i < exponent; i++)
                {
                    eredmeny *= basee;
                }
                return eredmeny;
            }
            else
            {
                for (double i = 0; i > exponent; i--)
                {
                    eredmeny /= basee;
                }
                return eredmeny;
            }
        }
            static void Main(string[] args)
            {
                Console.WriteLine("Add meg az első számot: ");
                double elso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Add meg az második számot: ");
                double masodik = Convert.ToDouble(Console.ReadLine());


                var PowerCalculator = new PowerCalculator();







                Console.WriteLine($"Az eredmény: {PowerCalculator.CalculatePower(elso, masodik)}");

                Console.ReadKey();
            }
         }
}
