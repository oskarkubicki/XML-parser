namespace Project2apmbd.Models
{
    public class Studies
    {
        public Studies()
        {
        }


        public Studies(string name, string mode)
        {
            this.name = name;
            this.mode = mode;
        }


        public string name { get; set; }

        public string mode { get; set; }
    }
}