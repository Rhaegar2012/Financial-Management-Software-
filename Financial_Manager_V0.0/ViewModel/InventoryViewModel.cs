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
        public string ItemSearchName
        {
            get
            {
                return _itemSearchName;
            }
            set
            {
                _itemSearchName = value;
                OnPropertyChanged("ItemSearchName");
            }
        }
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
        //Search Output Variable
        private string _itemIDSearchOutput;
        public string ItemIDSearchOutput
        {
            get
            {
                return _itemIDSearchOutput;
            }
            set
            {
                _itemIDSearchOutput = value;
            }
        }
        private string _itemQuantitySearchOutput;
        public string ItemQuantitySearchOutput
        {
            get
            {
                return _itemQuantitySearchOutput;
            }
            set
            {
                _itemQuantitySearchOutput = value;
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
        //Create inventory entry
        private InventoryModel CreateEntry(string ItemName, string itemNo, string itemQuantity)
        {
            int ItemReferenceID = Int32.Parse(itemNo);
            int ItemQuantity = Int32.Parse(itemQuantity);
            InventoryModel Entry = new InventoryModel(ItemName, ItemReferenceID, ItemQuantity);
            return Entry;
        }
        //Action Methods
        public void AddInventoryItem(object obj)
        {

            if (checkInput("add"))
            {
                
                inventoryEntry = CreateEntry(this.ItemName,this.ItemReferenceNumber,this.Quantity);
                inventoryEntry.AddInventoryItem();
            }
            
        }
        public void SearchItem(object obj)
        {
            if (checkInput("search"))
            {
                inventoryEntry = CreateEntry(this.ItemName, this.ItemReferenceNumber, this.Quantity);
                inventoryEntry.SearchInventory(this.ItemSearchName, this.SearchCategory);
            }
    
        }
        private bool checkInput(string method)
        {
            bool inputComplete;
            switch (method)
            {
                case "add":
                    {
                        List<string> inputList = new List<string>() { this.ItemName, this.ItemReferenceNumber, this.Quantity };
                        for(int i = 0; i < inputList.Count; i++)
                        {
                            if (String.IsNullOrEmpty(inputList[i]))
                            {
                                MessageBox.Show("Complete all input fields to add inventory entry");
                                return inputComplete = false;
                                
                            }

                        }
                        break;
                    }
                case "search":
                    {
                        List<string> inputList = new List<string>() { this.SearchCategory, this.ItemSearchName };
                        for (int i=0; i<inputList.Count; i++)
                        {
                            if (String.IsNullOrEmpty(inputList[i]))
                            {
                                MessageBox.Show("Complete all input fields to search inventory item");
                                return inputComplete = false;
                            }
                        }
                        break;
                    }
            }
            return inputComplete=true;
        }

    }
}
