using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryASM
{
    public class Employee
    {
        public string Name { get; set; }
        public Position Position { get; set; }
        public ILevelSalary Level { get; set; }
        public double Hour { get; set; }       


        public Employee()
        {
            this.Name = "nothing yet";
          
            this.Hour = 0.0;
        }

        public Employee(string n, int p, int l, double h)
        {
            this.Name = n;
           
            if (p == 1)
            {
                Architect position = new Architect();
                this.Position = position;
                if (l == 1)
                {
                    Leader level = new Leader();
                    this.Level = level;
                }
                else if (l == 2)
                {
                    Senior level = new Senior();
                    this.Level = level;
                }
                else if (l == 3)
                {
                    Junior level = new Junior();
                    this.Level = level;
                }
                else if (l == 4)
                {
                    Intern level = new Intern();
                    this.Level = level;
                }
            }

            else if (p == 2)
            {
                Developer position = new Developer();
                this.Position = position;
                if (l == 1)
                {
                    Leader level = new Leader();
                    this.Level = level;
                }
                else if (l == 2)
                {
                    Senior level = new Senior();
                    this.Level = level;
                }
                else if (l == 3)
                {
                    Junior level = new Junior();
                    this.Level = level;
                }
                else if (l == 4)
                {
                    Intern level = new Intern();
                    this.Level = level;
                }
            }

            else if (p == 3)
            {
                Tester position = new Tester();
                this.Position = position;
                if (l == 1)
                {
                    Leader level = new Leader();
                    this.Level = level;
                }
                else if (l == 2)
                {
                    Senior level = new Senior();
                        this.Level = level;
                }
                else if (l == 3)
                {
                    Junior level = new Junior();
                    this.Level = level;
                }
                else if (l == 4)
                {
                    Intern level = new Intern();
                    this.Level = level;
                }
            }
            this.Hour = h;
        }
        public double SubtractionSalary()
        {
            double atend = 0.0;
            if (this.Hour == 200)
            {
                atend = 0;           
                
           }

            else if (this.Hour < 200)
            {
              
                atend = (200 - Hour) * 10.0;
            }
            return atend;

        }

        public double OTSalary()
        {
            double OT = 0.0;
            if (this.Hour > 200)
            {
                OT = (this.Hour - 200) * 30.0;
            }
            return OT;
        }

        public double Calculationsalary()
        {
            
            double position = this.Level.CoefficientsSalary(this.Position);
            double result = (position * this.Hour) - this.SubtractionSalary() + this.OTSalary();
            return result;
        }
    




        

    }
}
