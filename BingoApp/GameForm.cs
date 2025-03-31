using System;
using System.Windows.Forms;
using BingoApp.Business;
using BingoApp.Data;

namespace BingoApp
{
    public partial class GameForm : Form
    {
        private readonly IBingoGame _bingoGame;
        private readonly IGameData _gameData;

        public GameForm(IBingoGame bingoGame, IGameData gameData)
        {
            InitializeComponent();
            _bingoGame = bingoGame;
            _gameData = gameData;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                int maxNumber = Convert.ToInt32(tbxMaxNumber.Text);
                // Initialize game
                lbxDrawnNumbers.Items.Clear();
                btnStart.Enabled = false;
                btnLoadGame.Enabled = false;
                btnStop.Enabled = true;
                btnStopAndSaveGame.Enabled = true;

                _bingoGame.StartGame(maxNumber);
                DrawNextNumber();
                timer.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please supply a valid number");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Move previous number into ListBox
            int oldNumber = Convert.ToInt32(lblNumber.Text);
            lbxDrawnNumbers.Items.Insert(0, oldNumber);

            if (_bingoGame.HasNumbersLeft())
            {
                DrawNextNumber();
            }
            else
            {
                timer.Stop();
                MessageBox.Show("The bingo has ended!");
            }
        }

        private void DrawNextNumber()
        {
            int nextNumber = _bingoGame.DrawNumber();
            lblNumber.Text = nextNumber.ToString();
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Bingo Save File|*.bingo|All Files|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Initialize GUI
                lbxDrawnNumbers.Items.Clear();
                btnStart.Enabled = false;
                btnLoadGame.Enabled = false;
                btnStop.Enabled = true;
                btnStopAndSaveGame.Enabled = true;
                // Load game
                try
                {
                    var gameData = GameDataLoader.Load(dlg.FileName);
                    _bingoGame.StartGame(gameData.MaxNumber);
                    foreach (int number in gameData.DrawnNumbers)
                    {
                        _bingoGame.DrawNumber();
                        lbxDrawnNumbers.Items.Add(number);
                    }
                    tbxMaxNumber.Text = gameData.MaxNumber.ToString();
                    DrawNextNumber();
                    timer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong when loading from the database");
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnLoadGame.Enabled = true;
            btnStop.Enabled = false;
            btnStopAndSaveGame.Enabled = false;
            timer.Stop();

            MessageBox.Show("The bingo has ended!");
        }

        private void btnStopAndSaveGame_Click(object sender, EventArgs e)
        {
            timer.Stop();
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Bingo Save File|*.bingo|All Files|*.*";
            dlg.AddExtension = true;
            dlg.DefaultExt = "bingo";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btnStart.Enabled = true;
                btnLoadGame.Enabled = true;
                btnStop.Enabled = false;
                btnStopAndSaveGame.Enabled = false;

                var gameData = new GameData
                {
                    MaxNumber = _bingoGame.MaxNumber,
                    DrawnNumbers = _bingoGame.DrawnNumbers
                };
                gameData.Save(dlg.FileName);

                MessageBox.Show("The bingo has ended and data has been saved!");
            }
            else
            {
                timer.Stop();
            }
        }
    }
}
