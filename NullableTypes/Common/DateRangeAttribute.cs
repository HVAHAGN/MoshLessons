using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes.Common
{
    class DateRangeAttribute:RangeAttribute
    {
        public DateRangeAttribute(string minValue):base(typeof(DateTime), minValue, DateTime.Now.ToShortDateString())
        {

        }
    }
}
