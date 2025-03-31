namespace BingoApp.Business
{
    public interface IBingoGame
    {
        void StartGame(int maxNumber);
        int DrawNumber();
        bool HasNumbersLeft();
        int MaxNumber { get; }
        List<int> DrawnNumbers { get; }
    }
}
