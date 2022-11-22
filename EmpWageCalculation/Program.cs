namespace EmpWageCalculation
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAY = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Employee Wage Computation");

            int empHour = 0, empDalyWage = 0, totalMonthWage = 0;
            //For loop
            for (int i = 1; i <= NUM_OF_WORKING_DAY; i++)
            {
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
                empDalyWage = empHour * EMP_RATE_PER_HOUR;
                totalMonthWage = totalMonthWage + empDalyWage;
                Console.WriteLine($"Emp Wage Day {i} : {empDalyWage}");
            }
            Console.WriteLine("Total Wage Of The Month is: " + totalMonthWage);
        }
    }
}