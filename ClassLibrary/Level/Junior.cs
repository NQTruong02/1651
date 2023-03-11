using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryASM
{
    public class Junior : ILevelSalary
    {

        string ILevelSalary.Name()
        {
            return "Junior";
        }
        double ILevelSalary.CoefficientsSalary(Position position)
        {
            return position.basicSalary * 1.4;
        }
    }
}
