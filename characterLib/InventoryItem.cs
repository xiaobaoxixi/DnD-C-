using System;
namespace characterLib
{
    public class InventoryItem
    {
        public InventoryItem(string itemNamem, uint weight, uint cost)
        {
            ItemName = itemNamem;
            Weight = weight;
            Cost = cost;
        }

        public string ItemName { get; set; }
        public uint Weight { get; set; } // uint represents only positive integer, 0 - 4 billion
        public uint Cost { get; set; }
    }
}
