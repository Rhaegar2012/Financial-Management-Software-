using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financial_Manager_V0._0.Utilities;
using Financial_Manager_V0._0.Model;
using System.Windows.Input;


namespace Financial_Manager_V0._0.ViewModel
{
    class InventoryViewModel : ObservableObject
    {
        //Inventory object
        private InventoryModel inventoryEntry;
        //Input Variables
        private string _itemReferenceNumber;
        public string ItemReferenceNumber
        {
            get
            {
                return _itemReferenceNumber;
            }
            set
            {
                _itemReferenceNumber = value;
                OnPropertyChanged("ItemReferenceNumber");
            }
        }
        private string _itemName;
        public string ItemName
        {
            get
            {
                return _itemName;
            }
            set
            {
                _itemName = value;
                OnPropertyChanged("ItemName");
            }
        }
        private string _quantity;
        public string Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                OnPropertyChanged("Quantity");
            }
        }
        private string _searchCategory;
        public string SearchCategory
        {
            get
            {
                return _searchCategory;
            }
            set
            {
                _searchCategory = value;
                OnPropertyChanged("SearchCategory");
            }
        }
        private string _itemSearchName;
        public string ItemSearchCategory
        {
            get
            {
                return _itemSearchName;
            }
            set
            {
                _itemSearchName = value;
                OnPropertyChanged("ItemSearchCategory");
            }
        }
        //Button command variables 
        private ICommand _addItemButton;
        public ICommand AddItemButton
        {
            get
            {
                return _addItemButton;
            }
            set
            {
                _addItemButton = value;
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
        public InventoryViewModel()
        {
            AddItemButton = new RelayCommand(new Action<object>(AddInventoryItem));
            SearchButton = new RelayCommand(new Action<object>(SearchItem));
           
        }
        //Action Methods
        public void AddInventoryItem(object obj)
        {

            if (checkInput("add"))
            {
                int itemNo = Int32.Parse(this.ItemReferenceNumber);
                int itemQuantity = Int32.Parse(this.Quantity);
                inventoryEntry = new InventoryModel(this.ItemName, itemNo, itemQuantity);
                inventoryEntry.AddInventoryItem();
            }
            
        }
        public void SearchItem(object obj)
        {
            //TODO
        }
        private bool checkInput(string method)
        {
            switch (method)
            {
                case "add":
                    {
                        break;
                    }
                case "search":
                    {
                        break;
                    }
            }
            throw new NotImplementedException();
        }

    }
}
