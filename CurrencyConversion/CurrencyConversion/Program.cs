using CurrencyConvertor.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CurrencyConversion
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            var rates = await File.ReadAllTextAsync("ExchangeRate.csv");

            Dictionary<string, decimal> dictionary;

            var prices = await File.ReadAllTextAsync("Prices.csv"); Dictionary<string, decimal> dictionary;

            List<Product> productPrice;
        }
    }
}
