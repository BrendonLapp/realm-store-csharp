using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RealmDAL.DTOs;

namespace RealmDAL.DataAccessControllers
{
    /// <summary>
    /// Data controller for sets
    /// </summary>
    public class SetDataController
    {
        public List<SetDTO> GetAllSets()
        {
            throw new NotImplementedException();
        }

        public List<SetDTO> GetSetsByGame(int GameID)
        {
            throw new NotImplementedException();
        }

        public int AddNonExistingSetsToDataBase(SetDTO NewSet)
        {
            throw new NotImplementedException();
        }
    }
}
