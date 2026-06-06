using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class FixedWidthRecord
    {
        // 5 Characters
        public string Code { get; set; } = null!;

        // 40 Characters
        public string Description { get; set; } = null!;

        // 12 Characters
        public decimal Price { get; set; }

        override public string ToString()
        {
            return $"{Code.PadRight(5)}{Description.PadRight(40)}{Price.ToString("F2").PadLeft(12)}";
        }

        public static FixedWidthRecord Parse(string line)
        {
            return new FixedWidthRecord
            {
                Code = line.Substring(0, 5).Trim(),
                Description = line.Substring(5, 40).Trim(),
                Price = decimal.Parse(line.Substring(45, 12).Trim())
            };
        }
    }
}
