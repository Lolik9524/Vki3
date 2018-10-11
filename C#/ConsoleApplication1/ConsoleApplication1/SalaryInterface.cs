using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface ILeadSalary : ISalarySize
    {
        int Size { get; set; }
    }

    public interface IEmployeeSalary : ISalarySize
    {
       
        int CurrentAmount { get; }
    }

    public interface IAccotreSalary : ISalarySize
    {
        
        void Pay(int amount);

    }

    public interface ISalarySize
    {
        int Size { get; }
    }

}
