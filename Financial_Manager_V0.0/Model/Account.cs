using System;
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
        
    }
}
