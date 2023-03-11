using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryASM
{
    public class EmployeeList : Employee
    {

        public List<Employee> ListEmployee { get; set; }
       


        public EmployeeList()
        {
            this.ListEmployee = new List<Employee>();        

        }

        public static void SortBySalary(EmployeeList listE)
        {
            for (int i = 0; i < listE.ListEmployee.Count; i++)
            {
                for (int j = i + 1; j < listE.ListEmployee.Count; j++)
                {               
                    if (listE.ListEmployee[i].Calculationsalary() < listE.ListEmployee[j].Calculationsalary())
                    {
                        var temp = listE.ListEmployee[i];
                        listE.ListEmployee[i] = listE.ListEmployee[j];
                        listE.ListEmployee[j] = temp;
                        //listE.ListEmployee[i].Name.CompareTo(listE.ListEmployee[j].Name);
                    }
                    //listE.ListEmployee[j].Calculationsalary().CompareTo(listE.ListEmployee[i].Calculationsalary());
                }
            }

        }


    }
}
