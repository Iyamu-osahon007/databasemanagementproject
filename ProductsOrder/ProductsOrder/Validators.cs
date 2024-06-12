using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsOrder
{
    public static class Validators
    {
        public static bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);


        }

        public static bool IsValidDate(string value)
        {
            return DateOnly.TryParse(value, out _);
        }
    }
}
