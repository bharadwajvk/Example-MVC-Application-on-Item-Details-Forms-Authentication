using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItemApplication.Models
{
    public class ItemViewModel
    {
        private List<string> _itemCategory;
        private List<string> _itemSubCategory;
        private List<Item> _item;

        public List<string> ItemCategory
        {
            get { return _itemCategory; }
            set { _itemCategory = value; }
        }
        public List<string> ItemSubCategory
        {
            get { return _itemSubCategory; }
            set { _itemSubCategory = value; }
        }

        public List<Item> Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
    }

}