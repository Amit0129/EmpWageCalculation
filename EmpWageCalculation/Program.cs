namespace EmpWageCalculation
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        //public const int EMP_RATE_PER_HOUR = 20;
        //public const int NUM_OF_WORKING_DAY = 20;
        //public const int MAX_HRS_IN_MONTH = 100;

       
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Employee Wage Computation");
            EmpWageBuilderObject dmert = new EmpWageBuilderObject("Demart", 20, 28, 300);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance",50,20,150);

            dmert.computeEmpWage();
            Console.WriteLine(dmert.ToString());

            reliance.computeEmpWage();           
            Console.WriteLine(reliance.ToString());


        }
    }
}