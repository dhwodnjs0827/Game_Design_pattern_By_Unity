using System.Collections.Generic;
using UnityEngine;

namespace AdapterPattern
{
    /// <summary>
    /// 서드파티 인벤토리 시스템을 흉내내는 placeholder 클래스
    /// </summary>
    public class InventorySystem
    {
        public void AddItem(InventoryItem item)
        {
            Debug.Log("Adding item to the cloud");
        }
        
        public void RemoveItem(InventoryItem item)
        {
            Debug.Log("Removing item from cloud");
        }

        public List<InventoryItem> GetInventory() 
        {
            Debug.Log("Returning an inventory list store");

            return new List<InventoryItem>();
        }
    }
}