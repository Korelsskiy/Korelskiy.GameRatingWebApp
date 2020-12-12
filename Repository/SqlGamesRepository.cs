using Korelskiy.NextBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korelskiy.NextBlazor.Repository
{
    public class SqlGamesRepository : IProductPepository
    {
        private readonly DB _context;

        public SqlGamesRepository(DB context)
        {
            _context = context;
        }
        public void AddNewGame(Game game)
        {
            _context.Games.Add(game);
            _context.SaveChanges();
        }

        public IEnumerable<Game> GetAllGames()
        {
            return _context.Games;
        }
        public void DeleteGame(int id)
        {
            var deletedGame = _context.Games.Find(id);

            if (deletedGame != null)
            {
                _context.Games.Remove(deletedGame);
                _context.SaveChanges();
            }
        }
    }
}
