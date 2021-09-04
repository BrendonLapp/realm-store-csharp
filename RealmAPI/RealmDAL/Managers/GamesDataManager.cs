using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RealmDAL.DTOs;

namespace RealmDAL.DataAccessControllers
{
    /// <summary>
    /// Data controller for the Games 
    /// </summary>
    public class GamesDataController
    {
        /// <summary>
        /// Performs a request for the Database to get a list of all games
        /// </summary>
        /// <returns>List of GameDTO objects</returns>
        public List<GameDTO> GetAllGames()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Performs a request to the database to be a single game
        /// </summary>
        /// <param name="GameID">The ID of the game being requested</param>
        /// <returns>GameDTO object with all the game details</returns>
        public GameDTO GetGameByID(int GameID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inserts a new game into the database. 
        /// </summary>
        /// <param name="NewGameName">The name of the new game being saved</param>
        /// <returns>Success as a bool</returns>
        public bool InsertIntoGame(string NewGameName)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Deletes a single game based on the given ID
        /// </summary>
        /// <param name="GameID">The supplied GameID to be deleted</param>
        /// <returns>Success as a bool</returns>
        public bool DeleteFromGame(int GameID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a Game in the database
        /// </summary>
        /// <param name="Game">GameDTO object</param>
        /// <returns>Success as a bool</returns>
        public bool UpdateGame(GameDTO Game)
        {
            throw new NotImplementedException();
        }
    }
}
