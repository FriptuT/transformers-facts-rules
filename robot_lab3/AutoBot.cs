namespace robot_lab3
{
    public class AutoBot
    {
        public string autoBot { get; set; }
        public string partener { get; set; }
        public string dusmanDirect { get; set; }

        public AutoBot(string autoBot, string partener, string dusmanDirect)
        {
            this.autoBot = autoBot;
            this.partener = partener;
            this.dusmanDirect = dusmanDirect;
        }
    }
}
