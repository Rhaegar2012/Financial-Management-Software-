using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financial_Manager_V0._0.Model;
using Financial_Manager_V0._0.Utilities;


namespace Financial_Manager_V0._0.ViewModel
{
    class ReportViewModel:ObservableObject
    {
        Account AccountQuery;
        private string _topSellingProduct;
        public string TopSellingProduct {
            get 
            {
                return _topSellingProduct;  
            }
            set 
            {
                _topSellingProduct = value;
                OnPropertyChanged("TopSellingProduct");
            } 
        }
        private string _mostBoughtProduct;
        public string MostBoughtProduct {
            get
            {
                return _mostBoughtProduct;
            }
            set
            {
                _mostBoughtProduct = value;
                OnPropertyChanged("MostBoughtProduct");
            }
        }
        private string _topClient;
        public string TopClient { 
            get 
            {
                return _topClient;  
            }
            set
            {
                _topClient = value;
                OnPropertyChanged("TopClient");
            }
        }
        private string _topSupplier;
        public string TopSupplier { 
            get
            {
                return _topSupplier;
            }
            set
            {
                _topSupplier = value;
                OnPropertyChanged("TopSupplier");
            }
        }
        private string _numberIncomeTransactions;
        public string NumberIncomeTransactions {
            get 
            {
                return _numberIncomeTransactions;
            } 
            set 
            {
                _numberIncomeTransactions = value;
                OnPropertyChanged("NumberIncomeTransactions");
            } 
        }
        private string _numberExpenseTransactions;
        public string NumberExpenseTransactions {
            get 
            {
                return _numberExpenseTransactions;
            } 
            set 
            {
                _numberExpenseTransactions = value;
                OnPropertyChanged("NumberExpenseTransactions");
            } 
        }
        private string _totalIncome;
        public string TotalIncome {
            get 
            {
                return _totalIncome;
            }
            set 
            {
                _totalIncome = value;
                OnPropertyChanged("TotalIncome");
            } 
        }
        private string _totalExpense;
        public string TotalExpense { 
            get 
            {
                return _totalExpense;
            } 
            set 
            {
                _totalIncome = value;
                OnPropertyChanged("TotalExpense");
            } 
        }

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
            //Update report values 
            UpdateReport();
        }
        public void UpdateReport()
        {
            this.TopSellingProduct = AccountQuery.TopSellingProduct;
            this.MostBoughtProduct = AccountQuery.MostBoughtProduct;
            this.TopClient = AccountQuery.TopClient;
            this.TopSupplier = AccountQuery.TopSupplier;
            this.NumberIncomeTransactions = AccountQuery.NumberOfIncomeExtractions;
            this.NumberExpenseTransactions = AccountQuery.NumberOfExpenseExtractions;
            this.TotalIncome = AccountQuery.TotalIncome;
            this.TotalExpense = AccountQuery.TotalExpense;
        }
    }
}
