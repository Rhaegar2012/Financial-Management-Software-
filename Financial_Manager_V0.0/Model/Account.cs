using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Financial_Manager_V0._0.EntityFramework;
using Financial_Manager_V0._0.Utilities;
using static System.Console;


namespace Financial_Manager_V0._0.Model
{
    class Account
    {
        //Input properties
        private int _InvoiceNo;
        public int InvoiceNo
        {
            get
            {
                return _InvoiceNo;
            }
            set
            {
                _InvoiceNo = value;
            }
        }
        private string _ClientName;
        public string ClientName
        {
            get
            {
                return _ClientName;
            }
            set
            {
                _ClientName = value;
            }
        }
        private string _AccountType;
        public string AccountType
        {
            get
            {
                return _AccountType;
            }
            set
            {
                _AccountType = value;
            }
        }
        private string _ItemName;
        public string ItemName
        {
            get
            {
                return _ItemName;
            }
            set
            {
                _ItemName=value ;
            }
        }
        private int _Quantity;
        public int Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                _Quantity = value;
            }
        }
        private decimal _UnitPrice;
        public decimal UnitPrice
        {
            get
            {
                return _UnitPrice;
            }
            set
            {
                _UnitPrice = value;
            }
        }
        private DateTime _Date;
        public DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                _Date = value;
            }
        }
        //Report  properties 
        private string _topSellingProduct;
        public string TopSellingProduct
        {
            get
            {
                return _topSellingProduct;
            }
            set
            {
                _topSellingProduct = value;
            }
        }
        private string _mostBoughtProduct;
        public string MostBoughtProduct
        {
            get
            {
                return _mostBoughtProduct;
            }
            set
            {
                _mostBoughtProduct = value;
            }
        }
        private string _topClient;
        public string TopClient
        {
            get
            {
                return _topClient;
            }
            set
            {
                _topClient = value;
            }
        }
        private string _topSupplier;
        public string TopSupplier
        {
            get
            {
                return _topSupplier;
            }
            set
            {
                _topSupplier = value;
            }
        }
        private string _totalIncome;
        public string TotalIncome
        {
            get
            {
                return _totalIncome;
            }
            set
            {
                _totalIncome = value;
            }
        }
        private string _totalExpense;
        public string TotalExpense
        {
            get
            {
                return _totalExpense;
            }
            set
            {
                _totalExpense = value;
            }
        }
        private string _numberOfIncomeExtractions;
        public string NumberOfIncomeExtractions
        {
            get
            {
                return _numberOfIncomeExtractions;
            }
            set
            {
                _numberOfIncomeExtractions = value;
            }
        }
        private string _numberOfExpenseExtractions;
        public string NumberOfExpenseExtractions
        {
            get
            {
                return _numberOfExpenseExtractions;
            }
            set
            {
                _numberOfExpenseExtractions = value;
            }
        }
        //Object for collection methods 
        private CollectionMethods collection = new CollectionMethods();

        
        //Constructor 
        public Account(int invoiceNo,string clientname, string accounttype,string itemname, int quantity,decimal unitprice, DateTime date)
        {
            this.InvoiceNo = invoiceNo;
            this.ClientName = clientname;
            this.AccountType = accounttype;
            this.ItemName = itemname;
            this.Quantity = quantity;
            this.UnitPrice = unitprice;
            this.Date = date;

            
            
      
        }
        // Overloaded Constructor for Empty AccountQuery calls 
        public Account()
        {

        }
        
        //Writes an Account Record to the database using entity framework
        public  int WriteToDatabase()
        {
            using(var context=new FinancialEntities())
            {
                try
                {
                    var AccountEntry = new Invoice()
                    {
                        AccountType = this.AccountType,
                        ClientName = this.ClientName,
                        InvoiceNo = this.InvoiceNo,
                        ItemName = this.ItemName,
                        Quantity = this.Quantity,
                        UnitPrice = this.UnitPrice,
                        Date = this.Date

                    };
                    context.Invoices.Add(AccountEntry);
                    context.SaveChanges();
                    //On succesful save, EF populates the database with a generated identity field
                    return AccountEntry.InvoiceID;

                }
                catch (Exception ex)
                {
                    WriteLine(ex.InnerException?.Message);
                    return 0;
                }
            }
        
        }
        //Obtains the Top selling /most bought product
        public void QueryTopProducts()
        {
            var context = new FinancialEntities();
            Dictionary<string, decimal> TopSellingItemValueCounts = new Dictionary<string, decimal>();
            Dictionary<string, decimal> MostBoughtProductValueCounts = new Dictionary<string, decimal>();
            //Top Selling product query
            var TopSellingQuery = from query in context.Invoices
                                  where query.AccountType == "Invoice"
                                  select query;

            //Most bought product query
            var MostBoughtQuery = from item in context.Invoices
                                  where item.AccountType == "Bill"
                                  select item;
            //Multiply Unit Price and Quantity
            foreach(var item in TopSellingQuery)
            {
                decimal value =(decimal) item.Quantity * (decimal) item.UnitPrice;
                if (TopSellingItemValueCounts.ContainsKey(item.ItemName))
                {
                    TopSellingItemValueCounts[item.ItemName] += value;
                }
                else
                {
                     TopSellingItemValueCounts.Add(item.ItemName, value);
                }

            }
            foreach(var item in MostBoughtQuery)
            {
                decimal value = (decimal)item.Quantity * (decimal)item.UnitPrice;
                if (MostBoughtProductValueCounts.ContainsKey(item.ItemName))
                {
                    MostBoughtProductValueCounts[item.ItemName] += value;
                }
                else
                {
                    MostBoughtProductValueCounts.Add(item.ItemName, value);
                }
            }

            this.TopSellingProduct = collection.MaxDictValue(TopSellingItemValueCounts);
            this.MostBoughtProduct = collection.MaxDictValue(MostBoughtProductValueCounts);
        }
        //Obtains the top client/supplier
        public void QueryTopClientSupplier()
        {
            var context = new FinancialEntities();
            Dictionary<string, decimal> TopClientValueCounts = new Dictionary<string,decimal>();
            Dictionary<string, decimal> TopSupplierValueCounts = new Dictionary<string, decimal>();
            //Top client product query 
            var TopClientQuery = from item in context.Invoices
                                 where item.AccountType == "Invoice"
                                 select item;
            //Top supplier product query
            var TopSupplierQuery = from item in context.Invoices
                                   where item.AccountType == "Bill"
                                   select item;
            foreach (var item in TopClientQuery)
            {
                decimal value = (decimal)item.Quantity * (decimal)item.UnitPrice;
                if (TopClientValueCounts.ContainsKey(item.ClientName))
                {
                    TopClientValueCounts[item.ClientName] += value;
                }
                else
                {
                    TopClientValueCounts.Add(item.ClientName, value);
                }

            }
            foreach (var item in TopSupplierQuery)
            {
                decimal value = (decimal)item.Quantity * (decimal)item.UnitPrice;
                if (TopSupplierValueCounts.ContainsKey(item.ClientName))
                {
                    TopSupplierValueCounts[item.ClientName] += value;
                }
                else
                {
                    TopSupplierValueCounts.Add(item.ClientName, value);
                }
            }
            this.TopClient = collection.MaxDictValue(TopClientValueCounts);
            this.TopSupplier = collection.MaxDictValue(TopSupplierValueCounts);
        }
        //Obtains Number of Expense Income Transactions
        public void QueryNumberOfTransactions()
        {
            var context = new FinancialEntities();
            var IncomeTransactionQuery = from item in context.Invoices
                                       where item.AccountType=="Invoice"
                                       select item;

            var ExpenseTransactionQuery = from item in context.Invoices
                                           where item.AccountType == "Bill"
                                           select item;
            this.NumberOfIncomeExtractions = IncomeTransactionQuery.Count().ToString();
            this.NumberOfExpenseExtractions = ExpenseTransactionQuery.Count().ToString();
        }
        //Obtains Total Expense Income 
        public void QueryTotalExpenseIncome()
        {
            WriteLine("I'm accessed");
            var context = new FinancialEntities();
            decimal TotalIncome = 0.0M;
            decimal TotalExpense = 0.0M;
            var IncomeQuery = from item in context.Invoices
                              where item.AccountType == "Invoice"
                              select item;

            var ExpenseQuery = from item in context.Invoices
                               where item.AccountType == "Bill"
                               select item;

            foreach( var item in IncomeQuery)
            {

                int quantity = (int)item.Quantity;
                decimal unitPrice =(decimal) item.UnitPrice;
                TotalIncome += quantity*unitPrice;
            }
            foreach(var item in ExpenseQuery)
            {
                int quantity = (int)item.Quantity;
                decimal unitPrice = (decimal)item.UnitPrice;
                TotalExpense += quantity * unitPrice;
            }
            this.TotalIncome = TotalIncome.ToString();
            this.TotalExpense = TotalExpense.ToString();
        }
        
    }
}
