using System.IO;
using System.Text.Json;

namespace BingoApp.Data
{
    public class GameData : IGameData
    {
        public int MaxNumber { get; set; }
        public List<int> DrawnNumbers { get; set; }

        public void Save(string fileName)
        {
            try
            {
                string json = JsonSerializer.Serialize(this);
                File.WriteAllText(fileName, json);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to save game data.", ex);
            }
        }
    }
}
