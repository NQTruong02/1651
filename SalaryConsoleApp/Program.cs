using LibraryASM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CalculationSalaryApp
{
    class Program
    {

        static void Main(string[] args)
        {
            EmployeeList listE = new EmployeeList();
            int choice = 0;
            do
            {
                Console.Clear();
                PrintMenu();
                try
                {                    
                    if (choice < 0 || choice > 6)
                    {
                        Console.WriteLine("Please Enter 0-5 number");
                    }
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {                        
                        case 1:
                            
                                Console.WriteLine("You choose add a new Employee to the Empoyeelist");
                                Console.WriteLine("Please insert information of Employee");
                                Console.Write("Name: ");
                                string Name = Console.ReadLine();
                                
                                int Positon = InputPosition();                                
                                int Level = InputLevel();                                
                                double Hour = InputHour();

                                Employee newE = new Employee(Name, Positon, Level, Hour);
                                listE.ListEmployee.Add(newE);   
                                Console.WriteLine("Employee information has been added");                                  
                            
                            Console.ReadKey();
                            break;                       
                        case 2:
                            Console.WriteLine("You choose Print List of Employee");
                            PrintList(listE);
                            Console.ReadKey();
                            break;
                           case 3:
                                EmployeeList.SortBySalary(listE);
                                PrintList(listE);
                                Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Please try again you must enter(0-5)!!!");
                            break;
                    }

                }
                catch (System.Exception)
                {
                    choice = -1;
                    Console.WriteLine("Your input is not a number");
                }               
            } while (choice != 0);
        }

        static void PrintMenu()
        {
            Console.WriteLine("			**************************Menu**************************");
            Console.WriteLine("			********************************************************");            
            Console.WriteLine("			**                                                    **");
            Console.WriteLine("			** 1.ADD New Employee                                 **");
            //Console.WriteLine("			** 2.Atend Salary Employee                            **");
            //Console.WriteLine("			** 3.OT Salary Employee                               **");
      
            Console.WriteLine("			** 2.Print List of Employee                           **");
            Console.WriteLine("			** 3.Sort Employee by Salary                          **");
            Console.WriteLine("			** 0.Exit                                             **");
            Console.WriteLine("			**                                                    **");
            Console.WriteLine("			**************Please enter your choice******************");
            Console.WriteLine("			********************************************************\n");

            Console.WriteLine("Please enter your choice:");
        }
        private static void PrintList(EmployeeList listE)
        {
            PrintLine();
            PrintRow("Name", "Position", "Level", "Hour Work(h)", "Attendance($)", "Bonus($)", "Salary($)");
            PrintLine();
            for (int i = 0; i < listE.ListEmployee.Count; i++)
            {
                string hourWork = Convert.ToString(listE.ListEmployee[i].Hour);
                string atend = Convert.ToString(listE.ListEmployee[i].SubtractionSalary());
                string OT = Convert.ToString(listE.ListEmployee[i].OTSalary());
                string salary = Convert.ToString(listE.ListEmployee[i].Calculationsalary());
                PrintRow(listE.ListEmployee[i].Name,
                    listE.ListEmployee[i].Position.Name,
                    listE.ListEmployee[i].Level.Name(),
                    hourWork, "$" + atend, "$" + OT, "$" + salary);                   
            }
            PrintLine();
        }

        static int tableWidth = 110;        
        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

        static public int InputPosition()
        {
            int choice = -1;
            do
            {
                try
                {
                    Console.Write("Positon '(1)Architect,(2)Developer,(3)Tester': ");
                    choice = int.Parse(Console.ReadLine());
                    if (choice < 1 || choice > 3)
                    {
                        Console.WriteLine("Please choose only 1 or 3");
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please choose only 1 or 3");
                }

            } while (choice < 1 || choice > 3);

            return choice;
        }

        static public int InputLevel()
        {
            int choice = -1;
            do
            {
                try
                {
                    Console.Write("Level '(1)Leader,(2)Senior,(3)Junior,(4)Intern': ");
                    choice = int.Parse(Console.ReadLine());
                    if (choice < 1 || choice > 4)
                    {
                        Console.WriteLine("Please choose only 1 or 4");
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please choose only 1 or 4");
                }

            } while (choice < 1 || choice > 4);

            return choice;
        }

        static public double InputHour()
        {
            double choice = -1;
            do
            {
                try
                {
                    Console.Write("Hour Work: ");
                    choice = double.Parse(Console.ReadLine());
                    if (choice < 1 || choice > 744)
                    {
                        Console.WriteLine("Please choose only 1 or 744");
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please choose only 1 or 744 ");
                }

            } while (choice < 1 || choice > 744);

            return choice;
        }

       
    }
}
