namespace EmpWageCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Employee Wage Computation");

            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //Variable
            int empHour = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHour = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHour = 0;
            }
            empWage = empHour * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employ Wage is : " + empWage);
        }
    }
}