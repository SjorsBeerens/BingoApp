using System;
using System.Windows.Forms;
using BingoApp.Business;
using BingoApp.Data;

namespace BingoApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Handmatige Dependency Injection
            IBingoGame bingoGame = new BingoGame();
            IGameData gameData = new GameData();
            GameForm gameForm = new GameForm(bingoGame, gameData);

            Application.Run(gameForm);
        }
    }
}
