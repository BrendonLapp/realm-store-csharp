using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealmDAL.DTOs;

namespace RealmDAL.DataAccessControllers
{
    public class InventoryDataController
    {
        public List<InventoryDTO> GetAllInventoryItems()
        {
            throw new NotImplementedException();
        }

        public InventoryDTO GetInventoryItemByID(int InventoryID)
        {
            throw new NotImplementedException();
        }

        public bool AddNewInventoryItem(InventoryDTO NewItem)
        {
            throw new NotImplementedException();
        }

        public bool UpdateInventoryItem(int InventoryID, int Quantity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteInventoryItem(int InventoryID)
        {
            throw new NotImplementedException();
        }

        public bool RemoveFromInventory (int InventoryID, int Quantity)
        {
            throw new NotImplementedException();
        }
    }
}
