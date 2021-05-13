using System;
using System.Collections.Generic;
using System.Linq;

namespace CurrencyConvertor.Logic
{
    public class CvsParser
    {
        public List<string[]> Parse(string text)
        {
            var lines = text.Replace("/r", string.Empty)
                .Split('\n');
            var result = new List<string[]>();
            foreach (var line in lines)
            {
                result.Add(line.Split(',').ToArray());
            }
            return result;
        }
    }
}
