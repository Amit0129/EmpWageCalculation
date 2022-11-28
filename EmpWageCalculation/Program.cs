namespace EmpWageCalculation
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        //public const int EMP_RATE_PER_HOUR = 20;
        //public const int NUM_OF_WORKING_DAY = 20;
        //public const int MAX_HRS_IN_MONTH = 100;

        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth)
        {
            int empHour = 0, totalEmpHour = 0, totalEmpDays = 0;

            while (totalEmpHour <= maxHourPerMonth && totalEmpDays < numOfWorkingDay)
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
            int totalEmplWage = totalEmpHour * empRatePerHour;
            Console.WriteLine($"Total EmpWage of company {company} is : {totalEmplWage}");
            return totalEmplWage;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Employee Wage Computation");
            computeEmpWage("Reliance",20,20,90);
            computeEmpWage("DMart",15,17,150);

        }
    }
}