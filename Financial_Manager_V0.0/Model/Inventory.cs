using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Manager_V0._0.Model
{
    class Inventory
    {
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
            }
        }
        private int _itemReferenceNumber;
        public int ItemReferenceNumber
        {
            get
            {
                return _itemReferenceNumber;
            }
            set
            {
                _itemReferenceNumber = value;
            }
        }
        private int _itemQuantity;
        public int ItemQuantity
        {
            get
            {
                return _itemQuantity;
            }
            set
            {
                _itemQuantity = value;
            }
        }
        //Constructor
        public Inventory(string itemName, int itemReference, int itemQuantity)
        {
            this.ItemName = itemName;
            this.ItemReferenceNumber = itemReference;
            this.ItemQuantity = itemQuantity;
        }
        public void AddInventoryItem()
        {
            //TODO
        }
        public void SearchInventory(string query,string queryType)
        {
            //TODO
        }
    }

}
