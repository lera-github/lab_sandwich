using program_ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    /// <summary>
    /// Вычисляет итоговое количество бутербродов
    /// </summary>
    public class AmountCalculator
    {
        #region
        /// <summary>
        /// Макс количество хлеба в гр
        /// </summary>
        public const double MaxHlebAmount = 5000;
        /// <summary>
        /// Мин количество хлеба в гр
        /// </summary>
        public const double MinHlebAmount = 25;
        /// <summary>
        /// Макс количество колбасы в гр
        /// </summary>
        public const double MaxColbasaAmount = 5000;
        /// <summary>
        /// Мин количество колбасы в гр
        /// </summary>
        public const double MinColbasaAmount = 15;
        #endregion

        /// <summary>
        /// Вычисляет итоговое количество
        /// </summary>
        /// <param name="Colbasa"></param>
        /// <param name="Hleb"></param>
        /// <returns>индекс bmi</returns>
        public static double GetAmount(double Colbasa, double Hleb)
        {
            double amount;

            ValidationHelper.CheckRangeValue(Hleb, MinHlebAmount, MaxHlebAmount, "Хлеб должен быть от {0} до {1}");
            ValidationHelper.CheckRangeValue(Colbasa, MinColbasaAmount, MaxColbasaAmount, "Колбаса должна быть от {0} до {1}");

            amount = Math.Min(Hleb / 25, Colbasa / 15);

            string description = ValueAmount.GetAmountDescription(amount);
            Console.WriteLine($"Количество бутербродов {description}");

            return amount;
        }
    }
}
