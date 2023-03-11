using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryASM
{
    public class Leader : ILevelSalary
    {
        string ILevelSalary.Name()
        {
            return "Leader";
        }
        double ILevelSalary.CoefficientsSalary(Position position)
        {
            return position.basicSalary * 2.2 ;
        }
    }
}
