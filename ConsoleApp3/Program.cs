using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(usd: 38.50, eur: 39.20, pln: 8.20);

            double uahAmount = 1000.0;
            Console.WriteLine($"{uahAmount} грн = {converter.ConvertToUSD(uahAmount):0.00} USD");
            Console.WriteLine($"{uahAmount} грн = {converter.ConvertToEUR(uahAmount):0.00} EUR");
            Console.WriteLine($"{uahAmount} грн = {converter.ConvertToPLN(uahAmount):0.00} PLN");

            double usdAmount = 50.0;
            double eurAmount = 40.0;
            double plnAmount = 200.0;

            Console.WriteLine($"{usdAmount} USD = {converter.ConvertFromUSD(usdAmount):0.00} грн");
            Console.WriteLine($"{eurAmount} EUR = {converter.ConvertFromEUR(eurAmount):0.00} грн");
            Console.WriteLine($"{plnAmount} PLN = {converter.ConvertFromPLN(plnAmount):0.00} грн");
        }
    }
}
