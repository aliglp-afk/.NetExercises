namespace ClassTemp
{
    public class Laptop:IDestroyable
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Sound { get; set; }

        public Laptop(string name,string color,string sound)
        {
            Name=name;
            Color=color;
            Sound=sound;
        }

        public void Destroy()
        {
            Console.WriteLine($"{Sound}");
        }
    }
}