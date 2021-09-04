using System;

namespace RealmDAL.APIResponseObjects
{
    /// <summary>
    /// Set API response object from the Pokemon TCG API
    /// </summary>
    public class PokemonSetAPIResponse
    {
        /// <summary>
        /// The name of the set
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The set code for the set
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// The release date of the set
        /// </summary>
        public DateTime releaseDate { get; set; }
    }
}
