using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooooooooooooo
{
    class Staff : Person
    {
        protected DateTime workStart;
        protected DateTime workFinish;
        protected int salary;
        protected string jobTitle;

        public Staff (DateTime _workStart, DateTime _workFinish, int _salary, string _jobTitle, int _age) : base(_age)
        {
            workStart = _workStart;
            workFinish = _workFinish;
            salary = _salary;
            jobTitle = _jobTitle;
        }
    }
}
