namespace TCG_Store.Models
{
    public class Game
    {
        /// <summary>
        /// The ID of the game. Generated by the database
        /// </summary>
        public int GameID { get; set; }
        /// <summary>
        /// The name of the game
        /// </summary>
        public string GameName { get; set; }
    }
}
