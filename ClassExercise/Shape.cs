namespace ClassExercise{
    class Shape{
        public int Height { get; set; }
        public int Width { get; set; }  
        public Shape(int height,int width)
        {
            Height=height;
            Width=width;
        }
        public virtual void Area(){
            
        }
        
        
        
    }
}