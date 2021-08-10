using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financial_Manager_V0._0.Utilities;
using Financial_Manager_V0._0.Model;
using System.Windows.Input;
using System.Windows;

namespace Financial_Manager_V0._0.ViewModel
{
    class ClientViewModel:ObservableObject
    {
        //Input properties
        private string _clientName;
        public string ClientName
        {
            get
            {
                return _clientName;
            }
            set
            {
                _clientName = value;
                OnPropertyChanged("ClientName");
            }
        }
        private string _clientEmail;
        public string ClientEmail
        {
            get
            {
                return _clientEmail;
                
            }
            set
            {
                _clientEmail = value;
                OnPropertyChanged("ClientName");
            }
        }
        private string _clientPhone;
        public string ClientPhone
        {
            get
            {
                return _clientPhone;
            }
            set
            {
                _clientEmail = value;
                OnPropertyChanged("ClientPhone");
            }
        }
        private string _clientAddress;
        public string ClientAddress
        {
            get
            {
                return _clientAddress;
            }
            set
            {
                _clientAddress = value;
                OnPropertyChanged("ClientAddress");
            }
        }
        private string _clientCity;
        public string ClientCity
        {
            get
            {
                return _clientCity;
            }
            set
            {
                _clientCity = value;
                OnPropertyChanged("ClientCity");
            }
        }
        private string _clientZipCode;
        public string ClientZipCode
        {
            get
            {
                return _clientZipCode;
               
            }
            set
            {
                _clientZipCode = value;
                OnPropertyChanged("ClientZipCode");
            }
        }
        //Button
        private ICommand _addButton;
        public ICommand AddButton
        {
            get
            {
                return _addButton;
            }
            set
            {
                _addButton = value;
            }
        }
        private ICommand _searchButton;
        public ICommand SearchButton
        {
            get
            {
                return _searchButton;
            }
            set
            {
                _searchButton = value;
            }
        }
        //Constructor 
        public ClientViewModel()
        {
            AddButton = new RelayCommand(new Action<object>(AddClient));
            SearchButton = new RelayCommand(new Action<object>(SearchClient));
        }
        //Methods
        public void AddClient(object obj)
        {
            //TODO
        }
        public void SearchClient(object obj)
        {
            //TODO
        }
    }
}
