using System;
using System.IO;
using System.Text.Json;

namespace BingoApp.Data
{
    public static class GameDataLoader
    {
        public static IGameData Load(string fileName)
        {
            try
            {
                string json = File.ReadAllText(fileName);
                var gameData = JsonSerializer.Deserialize<GameData>(json);
                if (gameData == null)
                {
                    throw new InvalidOperationException("Failed to deserialize game data.");
                }
                return gameData;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to load game data.", ex);
            }
        }
    }
}
