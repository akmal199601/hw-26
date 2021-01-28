using System;

namespace PRoj
{
    class Converter
    {
        public double usd { get; set; }
        public double eur { get; set; }
        public double rub { get; set; }
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public double UsdToTjs(double usd)
        {
            return usd * this.usd;
        }
        public double EurToTjs(double eur)
        {
            return eur * this.eur;
        }
        public double RubToTjs(double rub)
        {
            return rub * this.rub;
        }
        public double TjsToUsd(double somoni)
        {
            return somoni /this.usd;
        }
        public double TjsToEur(double somoni)
        {
            return somoni /this.eur;
        }
        public double TjsToRub(double somoni)
        {
            return somoni / this.rub;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            var converter = new Converter(11.3,13.30,0.15);
            Console.WriteLine("Введите сумму =  ");
            double amount = Convert.ToDouble(Console.ReadLine());
            double usdTOtjs = converter.UsdToTjs(amount);
            Console.WriteLine(usdTOtjs);
            double eurTOtjs = converter.EurToTjs(amount);
            Console.WriteLine(eurTOtjs);
            double rubTotjs = converter.RubToTjs(amount);
            Console.WriteLine(rubTotjs);
        }
    }
}
