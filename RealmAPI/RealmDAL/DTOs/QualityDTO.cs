﻿namespace RealmDAL.DTOs
{
    public class QualityDTO
    {
        /// <summary>
        /// The ID of the quality type
        /// </summary>
        public int QualityID { get; set; }
        /// <summary>
        /// The percentage that the quality will be discounted by
        /// </summary>
        public decimal Percentage { get; set; }
        /// <summary>
        /// The full name of the quality
        /// </summary>
        public string QualityName { get; set; }
        /// <summary>
        /// The shorted name of the quality
        /// </summary>
        public string QualityShortName { get; set; }
    }
}
