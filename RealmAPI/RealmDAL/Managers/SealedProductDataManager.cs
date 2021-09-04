using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RealmDAL.DTOs;

namespace RealmDAL.DataAccessControllers
{
    /// <summary>
    /// Data controller for sealed product
    /// </summary>
    public class SealedProductDataController
    {
        public List<SealedProductDTO> GetAllSealedProducts ()
        {
            throw new NotImplementedException();
        }

        public List<SealedProductDTO> GetSealedProductsByGame (int GameID)
        {
            throw new NotImplementedException();
        }

        public SealedProductDTO GetSealedProduct (int SealedProductID)
        {
            throw new NotImplementedException();
        }

        public bool AddSealedProduct (SealedProductDTO NewProduct)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSealedProduct (SealedProductDTO UpdatedProduct)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSealedProduct (int SealedProductID)
        {
            throw new NotImplementedException();
        }
    }
}
