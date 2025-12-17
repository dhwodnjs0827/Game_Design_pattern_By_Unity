using System.Collections.Generic;
using UnityEngine;

namespace AdapterPattern
{
    /// <summary>
    /// 어댑터처럼 행동할 클래스
    /// </summary>
    public class InventorySystemAdapter : InventorySystem, IInventorySystem
    {
        private List<InventorySystem> cloudInventory;

        public void SyncInventories()
        {
            var cloudInventory = GetInventory();
            
            Debug.Log("Synchronizing local drive and cloud inventories");
        }

        public void AddItem(InventoryItem item, SaveLocation location)
        {
            if (location == SaveLocation.Cloud)
            {
                AddItem(item);
            }
            
            if (location == SaveLocation.Local)
            {
                Debug.Log("Adding item to local drive");
            }
            
            if (location == SaveLocation.Both)
            {
                Debug.Log("Adding item to local drive and on the cloud");
            }
        }

        public void RemoveItem(InventoryItem item, SaveLocation location)
        {
            Debug.Log("Removing item from local/cloud/both");
        }

        public List<InventoryItem> GetInventory(SaveLocation location)
        {
            Debug.Log("Get inventory from local/cloud/both");

            return new List<InventoryItem>();
        }
    }
}