//Create a Point class which models a 2D point with x and y coordinates should contain:

//Two instance variables x and y  of int type, that will be available only in this class.

//A constructor that constructs a point with the given x and y coordinates.

//A method GetXYPair() which returns the x and y in a 2-element int array. This method should be available everywhere in the current assembly

//A method called Distance(int x, int y) that returns the distance (double) from this point to another point at the given (x, y) coordinates.

//An overloaded Distance(Point point) method that returns the distance from this point to the given Point instance.

//The distance methods should be available everywhere in the current assembly and in descendant classes in other assemblies;

//Create explicit cast to double operator that returns the distance (double) from this point to the origin (0, 0).

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point asd = new Point(1, 1);
        }
    }

    class Point
    {
        private int x;
        private int y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(int x)
        {
            this.x = x;
            this.y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        internal int[] GetXYPair()
        {
            return new int[] { x, y };
        }

        protected internal double Distance(int x, int y)
        {
            return Math.Sqrt((Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2)));
        }

        protected internal double Distance(Point point)
        {
            return Math.Sqrt((Math.Pow(this.x - point.x, 2) + Math.Pow(this.y - point.y, 2)));
        }

        public static explicit operator double(Point point)
        {
            return Math.Sqrt((Math.Pow(0 - point.x, 2) + Math.Pow(0 - point.y, 2)));
        }
    }

}
