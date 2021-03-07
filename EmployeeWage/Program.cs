using System;

namespace EmployeeWages
{
    class Program
    {
        public static void Main()
        {
            EmpWageBuilderObject DMart = new EmpWageBuilderObject("NOKIA", 20, 2, 10);
            DMart.computeEmpWage();
            EmpWageBuilderObject Relaince = new EmpWageBuilderObject("SAMSUNG", 10, 4, 20);
            Relaince.computeEmpWage();



        }

    }
}