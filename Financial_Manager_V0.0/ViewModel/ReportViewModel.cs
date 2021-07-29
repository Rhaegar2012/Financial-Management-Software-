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
        private string _topSellingProduct;
        public string TopSellingProduct { get; set; }
        private string _mostBoughtProduct;
        public string MostBoughtProduct { get; set; }
        private string _topClient;
        public string TopClient { get; set; }
        private string _topSupplier;
        public string TopSupplier { get; set; }


        //Constructor 
        public ReportViewModel()
        {
            AccountQuery = new Account();
        }

        //Executes preset report queries 
        public void ExecuteQueries()
        {
            AccountQuery.QueryTopProducts();
            AccountQuery.QueryTopClientSupplier();
            AccountQuery.QueryNumberOfTransactions();
            AccountQuery.QueryTotalExpenseIncome();
        }
    }
}
