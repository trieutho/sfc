using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfc.api.Repository
{
    public interface IEmployeeRepository : IRepository
    {
        object GetEmployeeList();

        object GetEmployeeDetails(string emp_no);
    }
}
