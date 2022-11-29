using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCalculation
{
    internal class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDay;
        public int maxHourPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDay = numOfWorkingDay;
            this.maxHourPerMonth = maxHourPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return $"The Employee Wage of the Company {this.company} is {this.totalEmpWage}";
        }
    }
}
