namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape;
            Console.WriteLine("enter shape type");
            int ch = byte.Parse(Console.ReadLine());
            if (ch == 1)
            {
                shape = new Square();
                shape.GetDimensions();
                shape.CalculateArea();
                shape.DispalyArea();

            }

            else if (ch == 2)
            {
                shape = new Rectangle();
                shape.GetDimensions();
                shape.CalculateArea();
                shape.DispalyArea();

            }
        }
    }
}
