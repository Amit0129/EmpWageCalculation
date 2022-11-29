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

        private int numOfComany = 0;
        private CompanyEmpWage[] companyEmpWagesArray;

        public EmpWageBuilderObject()
        {
            this.companyEmpWagesArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth)
        {
            companyEmpWagesArray[numOfComany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDay, maxHourPerMonth);
            numOfComany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfComany; i++)
            {
                companyEmpWagesArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWagesArray[i]));
                Console.WriteLine(this.companyEmpWagesArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHour = 0, totalEmpHour = 0, totalEmpDays = 0;

            while (totalEmpHour <= companyEmpWage.maxHourPerMonth && totalEmpDays < companyEmpWage.numOfWorkingDay)
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
            return totalEmpHour * companyEmpWage.empRatePerHour;
            
        }

    }
    
}
