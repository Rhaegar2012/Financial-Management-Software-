﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Financial_Manager_V0._0.Utilities;

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
        }
        //Methods
        public void RegisterAccount(object obj)
        {
            //TODO
        }


    }
}
