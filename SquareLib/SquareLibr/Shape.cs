using SquareLibr.Interface;

namespace SquareLibr
{
    public abstract class Shape : ISquare
    {
        public abstract double Area { get; }
    }
}
