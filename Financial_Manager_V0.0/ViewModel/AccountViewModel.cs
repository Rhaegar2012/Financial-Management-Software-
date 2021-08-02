using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Financial_Manager_V0._0.Utilities;
using Financial_Manager_V0._0.Model;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Financial_Manager_V0._0.ViewModel
{
    class AccountViewModel:ObservableObject
    {
        //Input data 
        private string in_invoiceNumber;
        public string InvoiceNumber
        {
            get
            {
                return in_invoiceNumber;
            }
            set
            {
                in_invoiceNumber = value;
                OnPropertyChanged("InvoiceNumber");
            }
        }
        private string in_clientName;
        public string ClientName
        {
            get
            {
                return in_clientName;
            }
            set
            {
                in_clientName = value;
                OnPropertyChanged("ClientName");
            }
        }
        private string in_itemName;
        public string ItemName
        {
            get
            {
                return in_itemName;
            }
            set
            {
                in_itemName = value;
                OnPropertyChanged("ItemName");
            }
        }
        private string in_Quantity;
        public string Quantity
        {
            get
            {
                return in_Quantity;
            }
            set
            {
                in_Quantity = value;
                OnPropertyChanged("Quantity");
            }
        }
        private string in_unitPrice;
        public string UnitPrice
        {
            get
            {
                return in_unitPrice;
            }
            set
            {
                in_unitPrice = value;
                OnPropertyChanged("UnitPrice");
            }
        }
        private string in_billingType;
        public string BillingType
        {
            get
            {
                return in_billingType;
            }
            set
            {
                in_billingType = value;
                OnPropertyChanged("BillingType");
            }
        }
        public string in_date;
        public string Date
        {
            get
            {
                return in_date;
            }
            set
            {
                in_date = value;
                OnPropertyChanged("Date");
            }
        }
        public ObservableCollection<string> RecentAccountList { get; private set; }
        //Buttons
        private ICommand _addAccountButton;
        public ICommand AddAccountButton
        {
            get
            {
                return _addAccountButton;
            }
            set
            {
                _addAccountButton = value;
            }
        }
        
        //Constructor 
        public AccountViewModel()
        {
            AddAccountButton = new RelayCommand(new Action<object>(RegisterAccount));
            RecentAccountList = new ObservableCollection<string>();
        }
        //Methods
        public void RegisterAccount(object obj)
        {
            
            if (CheckInput())
            {
                int InvoiceNo = Int32.Parse(this.InvoiceNumber);
                int Quantity = Int32.Parse(this.Quantity);
                string BillingType = "";
                decimal UnitPrice = Decimal.Parse(this.UnitPrice);
                decimal TotalAmount=Quantity*UnitPrice;
                DateTime Date = Convert.ToDateTime(this.Date);
                //Extract substring from Billing Type 
                if (this.BillingType.Contains("Invoice"))
                {
                    BillingType = "Invoice";
                }
                else if (this.BillingType.Contains("Bill"))
                {
                    BillingType = "Bill";
                }
                Account NewAccount = new Account(InvoiceNo, this.ClientName, BillingType, this.ItemName, Quantity, UnitPrice, Date);
                UpdateAccountList(this.InvoiceNumber, this.ClientName, this.ItemName, BillingType, TotalAmount.ToString(), this.Date);
                NewAccount.WriteToDatabase();
            }
            else
            {
                MessageBox.Show("Missing Input", "Empty input warning");
            }
         
        }
        private bool CheckInput()
        {
            
            bool CompleteInput = true;
            List<string> InputBoxes = new List<string> { this.ClientName,this.BillingType,this.InvoiceNumber,
                this.UnitPrice,this.Quantity,this.ItemName,this.Date};
            foreach (string input in InputBoxes){
                if (string.IsNullOrEmpty(input))
                {
                    CompleteInput = false;
                    return CompleteInput;
                }

            }
            return CompleteInput;
        }
        private void UpdateAccountList(string InvoiceNo, string ClientName, string ItemName,string AccountType, string TotalAmount,string Date)
        {
            string Addition = $"   {ClientName} " +
                $"                 {InvoiceNo}" +
                $"                 {AccountType}" +
                $"                 {ItemName}" +
                $"                 {TotalAmount}" +
                $"                 {Date}";
            RecentAccountList.Add(Addition);

        }


    }
}
