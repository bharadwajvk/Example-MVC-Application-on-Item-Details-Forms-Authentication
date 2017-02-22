using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItemApplication.Models
{
    public class ItemMapper
    {
        public List<Item> ItemMapperMethod(List<ItemApplication.Item> lists)
        {
            List<Item> list = new List<Item>();
            foreach (var item in lists)
            {
                Item i = new Item();
                i.ItemID = item.Id;
                i.ItemCategory = item.ItemCategory;
                i.ItemSubCategory = item.ItemSubCategory;
                i.ItemDescription = item.ItemDescription;
                i.ItemPrice = Convert.ToDouble(item.ItemPrice);
                i.Quantity = item.ItemQuantity ?? 0;
                list.Add(i);
            }
            return list;
        }

        //public List<string> ItemCategoryMapperMethod(List)
        //{

        //}
    }
}