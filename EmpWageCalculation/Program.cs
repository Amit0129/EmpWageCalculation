namespace EmpWageCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Employee Wage Computation");
            EmpWageBuilderObject empWageBuilder = new EmpWageBuilderObject();

            empWageBuilder.addCompanyEmpWage("Reliance", 30, 20, 150);
            empWageBuilder.addCompanyEmpWage("Demart", 20, 28, 200);
            empWageBuilder.addCompanyEmpWage("Nayak Ind",100,15,50);
            empWageBuilder.computeEmpWage();


        }
    }
}