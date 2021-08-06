using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financial_Manager_V0._0.EntityFramework;
using static System.Console;

namespace Financial_Manager_V0._0.Model
{
    class InventoryModel
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
        public InventoryModel(string itemName, int itemReference, int itemQuantity)
        {
            this.ItemName = itemName;
            this.ItemReferenceNumber = itemReference;
            this.ItemQuantity = itemQuantity;
        }
        public void AddInventoryItem()
        {
            using(var context= new FinancialEntities())
            {
                try
                {
                    var newInventoryItem = new Inventory()
                    {
                        ItemName = this.ItemName,
                        ItemQuantity = this.ItemQuantity
                    };
                    context.Inventories.Add(newInventoryItem);
                    context.SaveChanges();
                }catch(Exception ex)
                {
                    WriteLine(ex.InnerException?.Message);
                    
                }
               

            }
        }
        public InventoryModel SearchInventory(string query,string queryType)
        {
            
            using(var context=new FinancialEntities())
            {
                if (queryType.Equals("By Name"))
                {
                    var itemQuery = from item in context.Inventories
                                    where item.ItemName == query
                                    select item;

                }
                else if(queryType.Equals("By ID"))
                {
                    var itemQuery = from item in context.Inventories
                                    where item.ItemName == query
                                    select item;
                }
            }
            throw new NotImplementedException();
        }
    }

}
