namespace Access.Mod
{
    public partial class Car : object
    {
        public int Wheels { get; set; }
        public bool IsEV { get; set; }
        public void Start()
        {
            Console.WriteLine("Starting...");
        }
    }
}


