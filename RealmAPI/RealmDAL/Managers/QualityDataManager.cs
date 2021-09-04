using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RealmDAL.DTOs;

namespace RealmDAL.DataAccessControllers
{
    /// <summary>
    /// Data controller for quality
    /// </summary>
    public class QualityDataController
    {
        /// <summary>
        /// Gets a quality entry based on the provided ID
        /// </summary>
        /// <param name="QualityID">The provided quality ID</param>
        /// <returns>QualityDTO</returns>
        public QualityDTO GetQualityByID (int QualityID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all qualities saved in the database
        /// </summary>
        /// <returns>List of QualityDTOs</returns>
        public List<QualityDTO> GetAllQualities ()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new quality to the database
        /// </summary>
        /// <param name="NewQuality">Quality DTO to be added</param>
        /// <returns>Success as a bool</returns>
        public bool AddNewQuality(QualityDTO NewQuality)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Performs an update on the suppled quality
        /// </summary>
        /// <param name="UpdatedQuality">Quality DTO to update</param>
        /// <returns>Success as bool</returns>
        public bool UpdateQuality (QualityDTO UpdatedQuality)
        {
            throw new NotImplementedException();
        }

        public bool DeleteQuality (int QualityID)
        {
            throw new NotImplementedException();
        }
    }
}
