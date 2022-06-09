namespace ClassExercise{
    class Rectangle:Shape{
        public Rectangle(int height,int width):base(height,width)
        {
            
        }
        public override void Area()
        {
            int area =Height*Width;
            Console.WriteLine($"{area}");
        }
    }
}