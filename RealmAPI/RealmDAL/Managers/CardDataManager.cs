using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RealmDAL.DTOs;

namespace RealmDAL.DataAccessControllers
{
    /// <summary>
    /// Data controller for Cards
    /// </summary>
    public class CardDataController
    {
        /// <summary>
        /// Adds a new card to the database
        /// </summary>
        /// <param name="NewCard">CardDTO object for the new card</param>
        /// <returns>Success as a bool</returns>
        public bool AddCard(CardDTO NewCard)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Searchs for cards by a partial query string. Returns a list of CardDTOs containing the SearchQuery
        /// </summary>
        /// <param name="SearchQuery">Input from the user</param>
        /// <returns>List of CardDTOs</returns>
        public List<CardDTO> SearchCardsByPartialName(string SearchQuery)
        {
            throw new NotImplementedException(); 
        }
    }
}
