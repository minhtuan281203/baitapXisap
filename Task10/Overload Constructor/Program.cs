namespace Constructor
{
    public class Rectangle
    {
        double _length, _breadth;
        public Rectangle()
        {
            _length = 13.5;
            _breadth = 20.5;
        }
        public Rectangle(double len, double wide)
        {
            _length = len;
            _breadth = wide;
        }
        public double Area()
        {
            return _length * _breadth;
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Console.WriteLine("Area = "+rect.Area());

            Rectangle rect2 = new Rectangle(2.5, 6.9);
            Console.WriteLine("Area = "+rect2.Area());

            Console.ReadKey();
        }
    }
}