namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Room<IShape> room = new Room<IShape>();
            room.Height = 10;
            room.Floor = new Rectangle() { Length = 100, Width = 10 };
            Room<IShape> room2 = new Room<IShape>();
            room2.Height = 10;
            room2.Floor = new Trapezoid() { Length1 = 10, Length2 = 10, Width = 20 };
            Console.WriteLine(room.Floor.Area());
            Console.WriteLine(room2.Floor.Area());
            Console.WriteLine(room.CompareTo(room2));
        }
    }

    public interface IShape : ICloneable
    {
        double Area() => 0;
    }

    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area() => Length * Width;

        public object Clone() => MemberwiseClone();
    }

    public class Trapezoid : IShape
    {
        public double Length1 { get; set; }
        public double Length2 { get; set; }
        public double Width { get; set; }

        public double Area() => (Length1 + Length2) * Width / 2;

        public object Clone() => MemberwiseClone();
    }

    public class Room<T> : ICloneable, IComparable where T : IShape
    {
        public double Height { get; set; }
        public T Floor { get; set; }
        public double Volume() => Floor.Area() * Height;
        public object Clone()
        {
            return new Room<T> { Height = this.Height, Floor = (T)Floor.Clone() };
        }

        public int CompareTo(object obj)
        {
            Room<T> room = obj as Room<T>;
            return Floor.Area().CompareTo(room.Floor.Area());
        }
    }

    public class RoomComparerByVolume<T> : IComparer<Room<T>> where T : IShape
    {
        public int Compare(Room<T> first, Room<T> second) => 
            first.Volume() > second.Volume() ? 1 : 
                first.Volume() < second.Volume() ? -1 : 0;
    }
}
