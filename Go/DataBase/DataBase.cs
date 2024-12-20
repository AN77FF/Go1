using Go.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Go.DataBase
{
    public class DataBase : IDataBase
    {
        private const string FilePath = "gameData.xml";

        public void SaveGame(GoGame game)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GoGame));
            using (FileStream stream = new FileStream(FilePath, FileMode.Create))
            {
                serializer.Serialize(stream, game);
            }
        }

        public GoGame LoadGame()
        {
            if (!File.Exists(FilePath))
                return null;

            XmlSerializer serializer = new XmlSerializer(typeof(GoGame));
            using (FileStream stream = new FileStream(FilePath, FileMode.Open))
            {
                return (GoGame)serializer.Deserialize(stream);
            }
        }

        void IDataBase.SaveGame(GoGame game)
        {
            throw new NotImplementedException();
        }

        GoGame IDataBase.LoadGame()
        {
            throw new NotImplementedException();
        }
    }
}

