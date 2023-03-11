using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryASM
{
    
    public class Intern : ILevelSalary
    {    
        string ILevelSalary.Name()
        {
            return "Intern";
        }

        double ILevelSalary.CoefficientsSalary(Position position)
        {
            return position.basicSalary * 0.5;
        }
    }
    
}
