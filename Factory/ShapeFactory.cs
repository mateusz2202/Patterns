using Factory.Enums;
using Factory.Models;

namespace Factory;

internal class ShapeFactory
{

    public IShape Create(ShapeType type)
    {
        IShape result = type switch
        {
            ShapeType.Circle => new Circle(),
            ShapeType.Triagle => new Triagle(),
            ShapeType.Rectangle => new Rectanlge(),
            _ => throw new ArgumentException("Invaild enum value for shape type", nameof(type)),
        };

        return result;
    }
}
