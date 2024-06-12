using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsOrder
{
    internal static class DataUIUT
    {
        public static int? GetInteger(this DataRow dataRow, string columnName)
        {
            return dataRow[columnName] != DBNull.Value ? Convert.ToInt32(dataRow[columnName]) : null;
        }

    }
}
