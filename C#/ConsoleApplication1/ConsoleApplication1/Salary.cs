using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Salary: ILeadSalary, IEmployeeSalary, IAccotreSalary
    {

       public void Pay(int amount){}
       public int CurrentAmount { get; }
       public int Size { get; set; }
   }
}
