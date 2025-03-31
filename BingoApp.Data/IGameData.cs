namespace BingoApp.Data
{
    public interface IGameData
    {
        int MaxNumber { get; set; }
        List<int> DrawnNumbers { get; set; }
        void Save(string fileName);
    }
}
