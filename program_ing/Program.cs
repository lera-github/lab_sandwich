using App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ing
{
    internal class Program
    {
        /// <summary>
        /// Запуск
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double Colbasa, Hleb;

            Console.WriteLine("Введите количество колбасы в граммах:");
            Colbasa = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество хлеба в граммах:");
            Hleb = double.Parse(Console.ReadLine());

            double amount = AmountCalculator.GetAmount(Colbasa, Hleb);
            Console.WriteLine(amount);         
        }
    }
}
