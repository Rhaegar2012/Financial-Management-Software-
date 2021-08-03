using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financial_Manager_V0._0.Utilities;

namespace Financial_Manager_V0._0.ViewModel
{
    class InventoryViewModel : ObservableObject
    {
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
        //Constructor
        public InventoryViewModel()
        {

        }

    }
}
