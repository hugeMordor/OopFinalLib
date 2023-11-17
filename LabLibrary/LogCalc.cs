using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLibrary
{
    /// <summary>
    /// Содержит методы для рассчета натурального 
    /// и десятичного логарифма
    /// </summary>
    public class LogCalc : ILogInterface
    {
        /// <summary>
        /// Возвращает натуральный логарифм от x
        /// </summary>
        /// <param name="x"></param>
        /// <returns>(double)Ln(x)</returns>
        public static double Ln(double x)
        {
            return Math.Log(x);
        }
        /// <summary>
        /// Возвращает десятичный логарифм от x
        /// </summary>
        /// <param name="x"></param>
        /// <returns>(double)Lg(x)</returns>
        public static double Lg(double x)
        {
            return Math.Log10(x);
        }
    }
}
