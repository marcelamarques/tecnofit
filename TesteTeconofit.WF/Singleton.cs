namespace TesteTeconofit.WF
{
    public class Singleton
    {
        private static Singleton instance;
        public bool StateDTR { get; set; }
        public int CountDataReceived { get; set; }

        private Singleton()
        {
            CountDataReceived = 0;
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
