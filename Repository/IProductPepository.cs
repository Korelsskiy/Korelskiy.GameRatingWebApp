using Korelskiy.NextBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korelskiy.NextBlazor.Repository
{
    public interface IProductPepository
    {
        public IEnumerable<Game> GetAllGames();

        public void AddNewGame(Game game);
        public void DeleteGame(int id);
    }
}
