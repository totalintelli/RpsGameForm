namespace RpsGameForm
{
    internal class GameEventArgs
    {
        public int UserSelect { get; private set; }
        public int ComSelect { get; private set; }
        public Results GameResult { get; set; }
        public GameEventArgs(int UserSelect, int ComSelect)
        {
            this.UserSelect = UserSelect;
            this.ComSelect = ComSelect;
        }
        public GameEventArgs(int UserSelect, int ComSelect, Results GameResult)
        {
            this.UserSelect = UserSelect;
            this.ComSelect = ComSelect;
            this.GameResult = GameResult;
        }
    }
}