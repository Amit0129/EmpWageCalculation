using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCalculation
{
    internal class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDay;
        private int maxHourPerMonth;
        private int totalEmplWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDay = numOfWorkingDay;
            this.maxHourPerMonth = maxHourPerMonth;
        }
        public void computeEmpWage()
        {
            int empHour = 0, totalEmpHour = 0, totalEmpDays = 0;

            while (totalEmpHour <= this.maxHourPerMonth && totalEmpDays < this.numOfWorkingDay)
            {
                totalEmpDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHour = 8;
                        break;
                    case IS_PART_TIME:
                        empHour = 4;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                totalEmpHour += empHour;
                Console.WriteLine("Days: " + totalEmpDays + " Emp Hrs : " + empHour);


            }
            totalEmplWage = totalEmpHour * this.empRatePerHour;
            Console.WriteLine($"Total EmpWage of company {company} is : {totalEmplWage}");
        }
        public string ToString()
        {
            return $"The Employee Wage of the Company {this.company} is {this.totalEmplWage}";
        }

    }
    


}
