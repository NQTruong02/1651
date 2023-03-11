using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryASM
{
    public class Senior : ILevelSalary
    {
        string ILevelSalary.Name()
        {
            return "Senior";
        }
        double ILevelSalary.CoefficientsSalary(Position position)
        {
            return position.basicSalary * 1.8;
        }
    }
}
