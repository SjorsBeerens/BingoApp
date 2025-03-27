using System;
using System.Collections.Generic;
using System.Linq;

namespace BingoApp.Business
{
    public class BingoGame
    {
        private Random _rnd;
        private List<int> _availableNumbers;
        public int MaxNumber { get; private set; }
        public List<int> DrawnNumbers { get; private set; }

        public BingoGame()
        {
            _rnd = new Random();
            _availableNumbers = new List<int>();
            DrawnNumbers = new List<int>();
        }

        public void StartGame(int maxNumber)
        {
            MaxNumber = maxNumber;
            _availableNumbers = Enumerable.Range(1, maxNumber).ToList();
            DrawnNumbers.Clear();
        }

        public int DrawNumber()
        {
            if (_availableNumbers.Count == 0)
                throw new InvalidOperationException("No numbers left to draw.");

            int index = _rnd.Next(_availableNumbers.Count);
            int number = _availableNumbers[index];
            _availableNumbers.RemoveAt(index);
            DrawnNumbers.Add(number);
            return number;
        }

        public bool HasNumbersLeft()
        {
            return _availableNumbers.Count > 0;
        }
    }
}
