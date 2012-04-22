using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.Objects;
using System.Data;

namespace MyDay.Data
{
    internal static class MyDayDataExtentions
    {
        internal static DbTransaction BeginTransaction(this ObjectContext context)
        {
            if (context.Connection.State != ConnectionState.Open)
                context.Connection.Open();
            
            return context.Connection.BeginTransaction();
        }
    }
}
