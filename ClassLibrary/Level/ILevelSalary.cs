using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryASM
{
    public interface ILevelSalary
    {
        string Name();
        double CoefficientsSalary(Position position);
    }
}
