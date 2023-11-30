namespace robot_lab3
{
    public class Decepticon
    {
        public string decepticon { get; set; }
        public string partener { get; }
        public string dusmanDirect { get; set; }

        public Decepticon(string decepticon, string partener, string dusmanDirect)
        {
            this.decepticon = decepticon;
            this.partener = partener;
            this.dusmanDirect = dusmanDirect;
        }
    }
}
