using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BingoApp.Data
{
    public class GameData
    {
        public int MaxNumber { get; set; }
        public List<int> DrawnNumbers { get; set; }

        public void Save(string filePath)
        {
            var json = JsonSerializer.Serialize(this);
            File.WriteAllText(filePath, json);
        }

        public static GameData Load(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<GameData>(json);
        }
    }
}
