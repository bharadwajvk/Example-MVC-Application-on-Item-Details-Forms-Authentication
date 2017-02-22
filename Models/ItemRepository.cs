using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItemApplication.Models
{
    public class ItemRepository
    {
        public ItemViewModel ItemData()
        {
            ItemViewModel itemViewModel = new ItemViewModel();
            DatabaseEntities db = new DatabaseEntities();
            var list = db.Items.ToList();
            ItemMapper m = new ItemMapper();
            List<Item> mappedList = m.ItemMapperMethod(list);
            itemViewModel.Item = mappedList;
            itemViewModel.ItemCategory = ItemCategory();
            itemViewModel.ItemSubCategory = ItemSubCategory();
            return itemViewModel;
        }

        public List<string> ItemCategory()
        {
            DatabaseEntities db = new DatabaseEntities();
            var list1 = (from c in db.Items
                        select c.ItemCategory).ToList();
            return list1.Distinct().ToList();
        }
        public List<string> ItemSubCategory()
        {
            DatabaseEntities db = new DatabaseEntities();
            var list1 = (from c in db.Items
                        select c.ItemSubCategory).ToList();
            return list1.Distinct().ToList();
        }
    }
}