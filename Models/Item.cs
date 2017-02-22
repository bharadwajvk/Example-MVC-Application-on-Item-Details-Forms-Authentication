using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItemApplication.Models
{
    public class Item
    {
        private int _itemID;
        private string _itemCategory;
        private string _itemSubCategory;
        private string _itemDescription;
        private double _itemPrice;
        private int _quantity;
        
        public int ItemID
        {
            get { return _itemID; }
            set { _itemID = value; }

        }
        public string ItemCategory
        {
            get { return _itemCategory; }
            set { _itemCategory = value; }

        }
        public string ItemSubCategory
        {
            get { return _itemSubCategory; }
            set { _itemSubCategory = value; }

        }
        public string ItemDescription
        {
            get { return _itemDescription; }
            set { _itemDescription = value; }

        }
        public double ItemPrice
        {
            get { return _itemPrice; }
            set { _itemPrice = value; }

        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }

        }
    }
}