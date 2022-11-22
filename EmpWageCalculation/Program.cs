namespace EmpWageCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Employee Wage Computation");

            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_hOUR = 20;
            //Variable
            int empHour = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Full Time");
                empHour = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee is Part Time");
                empHour = 4;
            }
            else
            {
                empHour = 0;
                Console.WriteLine("Employ is Absent");
            }
            empWage = empHour * EMP_RATE_PER_hOUR;
            Console.WriteLine("Employ Wage is : " + empWage);
        }
    }
}