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
                _clientPhone = value;
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
        //Input property for querying 
        private string _clientQuery;
        public string ClientQuery
        {
            get
            {
                return _clientQuery;
            }
            set
            {
                _clientQuery = value;
                OnPropertyChanged("ClientQuery");
            }
        }
        //Output properties 
        private string _queryName;
        public string QueryName
        {
            get
            {
                return _queryName;
            }
            set
            {
                _queryName = value;
                OnPropertyChanged("QueryName");
            }
        }
        private string _queryEmail;
        public string QueryEmail
        {
            get
            {
                return _queryEmail;
            }
            set
            {
                _queryEmail = value;
                OnPropertyChanged("QueryEmail");
            }
        }
        private string _queryPhone;
        public string QueryPhone
        {
            get
            {
                return _queryPhone;
            }
            set
            {
                _queryPhone = value;
                OnPropertyChanged("QueryPhone");
            }
        }
        private string _queryAddress;
        public string QueryAddress
        {
            get
            {
                return _queryAddress;
            }
            set
            {
                _queryAddress = value;
                OnPropertyChanged("QueryAddress");
            }
        }
        private string _queryCity;
        public string QueryCity
        {
            get
            {
                return _queryCity;
            }
            set
            {
                _queryCity = value;
                OnPropertyChanged("QueryCity");
            }
        }
        private string _queryZip;
        public string QueryZip
        {
            get
            {
                return _queryZip;
            }
            set
            {
                _queryZip = value;
                OnPropertyChanged("QueryZip");
            }
        }
        //Button
        private ICommand _addButton;
        public ICommand AddClientButton
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
        public ICommand SearchClientButton
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
            AddClientButton = new RelayCommand(new Action<object>(AddClient));
            SearchClientButton = new RelayCommand(new Action<object>(SearchClient));
        }
        //Methods
        public void AddClient(object obj)
        {
            Console.WriteLine("Client add method accessed");
            ClientModel newClient = new ClientModel(this.ClientName, this.ClientPhone, this.ClientAddress, this.ClientEmail, this.ClientCity, this.ClientZipCode);
            newClient.AddClient();
        }
        public void SearchClient(object obj)
        {
            ClientModel clientQuery = new ClientModel(this.ClientQuery);
        }
    }
}
