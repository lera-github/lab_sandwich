using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace program_ing
{
    internal class ValueAmount
    {
        /// <summary>
        /// Описание к сумме за хлеб и колбасу
        /// </summary>
        static Dictionary<double, string> description = new()
        {
            { 5 , "мало бутербродов"},
            { 10 , "немного бутербродов"},
            { 50 , "много бутербродов"},
            { 100 , "очень много бутербродов"},
        };
        /// <summary>
        /// Получение описания
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static string GetAmountDescription(double amount)
        {
            foreach (var entry in description)
            {
                if (amount < entry.Key)
                {
                    return entry.Value;
                }
            }
            return "невозможное значение";
        }
    }
}
