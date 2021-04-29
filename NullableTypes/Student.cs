using NullableTypes.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
   public  class Student
    {
        public int Id { get; set; }
        [CustomRequired]
        public string Name { get; set; }
    }
}
