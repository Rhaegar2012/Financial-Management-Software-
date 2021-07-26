using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financial_Manager_V0._0.Model;

namespace Financial_Manager_V0._0.ViewModel
{
    class ReportViewModel
    {
        Account AccountQuery;

        //Constructor 
        public ReportViewModel()
        {
            AccountQuery = new Account();
        }

        //Executes preset report queries 
        public void ExecuteQueries()
        {
            AccountQuery.QueryTopProducts();
        }
    }
}
