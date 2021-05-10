using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonQuestions
{
    public partial class Employee
    {
        partial void GenerateEmployeeId()
        {
            this.EmpId = new Random().Next(1,15);
        }
    }
}
