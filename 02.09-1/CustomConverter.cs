using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09_1
{
    internal class CustomConverter
    {
        public void ConvertToInt(string input, out int result)
        {
            result = Convert.ToInt32(input);
        }

        public void ConvertToDouble(string input, out double result)
        {
            if (!double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                throw new FormatException($"Input string '{input}' was not in a correct format.");
            }
        }

        public void ConvertToBool(string input, out bool result)
        {
            result = Convert.ToBoolean(input);
        }

        public void ConvertToDateTime(string input, out DateTime result)
        {
            result = Convert.ToDateTime(input);
        }

        public void ConvertToLong(string input, out long result)
        {
            result = Convert.ToInt64(input);
        }
    }
}
