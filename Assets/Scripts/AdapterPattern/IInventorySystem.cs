using System.Collections.Generic;

namespace AdapterPattern
{
    public interface IInventorySystem
    {
        public void SyncInventories();

        public void AddItem(InventoryItem item, SaveLocation location);

        public void RemoveItem(InventoryItem item, SaveLocation location);

        public List<InventoryItem> GetInventory(SaveLocation location);
    }
}