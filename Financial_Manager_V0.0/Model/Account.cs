﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Financial_Manager_V0._0.EntityFramework;
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
        private string _numberOfExpenseExtractions
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
            string sqlQueryTopSellingProduct = "Select COUNT(ItemName),ItemName From Invoice Where AccountType='@Invoice' Group By ItemName ORDER BY COUNT(ItemName) DESC";
            using (var context=new FinancialEntities())
            {
                foreach (Invoice invoice in context.Invoices.SqlQuery(sqlQueryTopSellingProduct))
                {
                    WriteLine(invoice.ItemName);
                }
            }
        }
        //Obtains the top client/supplier
        public void QueryTopClientSupplier()
        {
            //TODO
        }
        //Obtains Number of Expense Income Transactions
        public void QueryNumberOfTransactions()
        {
            //TODO
        }
        //Obtains Total Expense Income 
        public void QueryTotalExpenseIncome()
        {
            //TODO
        }
        
    }
}
