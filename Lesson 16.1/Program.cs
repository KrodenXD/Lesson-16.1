using System;

namespace Lesson_16._1
{
    class Program
    {
        private static void MedTax(ref double a)
        {

            a = a - a * 0.1;
        }
        private static void EdTax(ref double a)
        {
            a = a - a * 0.03;
        }
        private static void ArmyTax(ref double a)
        {
            a = a - a * 0.02;
        }
        private static void InfraTax(ref double a)
        {
            a = a - a * 0.05;
        }
        private static void Total(ref double a)
        {
            Console.WriteLine(a);
        }
        public delegate void Del(ref double a);
        static void Main(string[] args)
        {
            double i = Convert.ToDouble(Console.ReadLine());
            Del Med = MedTax;
            Del Ed = EdTax;
            Del Army = ArmyTax;
            Del Infra = InfraTax;
            Del PureMoney = Med + Ed + Army + Infra + Total;
            PureMoney(ref i);
        }
    }
}
