using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Lib
{
    public class ItemUtilities
    {
        public static List<Item> GetItemsByUrgency(string urgencyLevel, List<Item> itemList)
        {
            return itemList.Where(l => l.UrgencyLevel.ToString().Equals(urgencyLevel)).ToList();
        }

        public static List<Item> GetItemsByTitleFilter(string filter, List<Item> itemList)
        {
            return itemList.Where(l => l.Title.Contains(filter)).ToList();
        }

        public static List<Item> GetItemsBeforeDateFilter(DateTime before, List<Item> itemList)
        {
            return itemList.Where(l => l.Deadline <= before).ToList();
        }

        public static List<Item> GetItemsAfterDateFilter(DateTime after, List<Item> itemList)
        {
            return itemList.Where(l => l.Deadline >= after).ToList();
        }
    }
}
