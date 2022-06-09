namespace ClassTemp{
    sealed class Table:MyAbs,IDestroyable
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string Sound { get; set; }
        public override void Destroy(){
            Console.WriteLine($"{Sound}");
        }
        public override int Test()
        {
            return 0;
        }
        public Table(string name,string color,string material,string sound)
        {
            Name=name;
            Color=color;
            Material=material;
            Sound=sound;
        }
    }
}