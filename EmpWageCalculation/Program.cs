namespace EmpWageCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Employee Wage Computation");

            //Constant
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            //random = Reference Variable
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}