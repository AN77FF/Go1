using Go.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go.DataBase
{
        public interface IDataBase
        {
            void SaveGame(GoGame game);
            GoGame LoadGame();
        
        }
}

