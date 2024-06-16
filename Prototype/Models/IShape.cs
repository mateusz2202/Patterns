namespace Prototype.Models;

internal interface IRender
{
    public int X { get; set; }
    public int Y { get; set; }
    void Render();
}

internal interface IClone
{
    IRender Clone();
}

internal interface IShape : IRender, IClone
{
    public IBorder Border { get; set; }
}

internal interface IBorder : IRender, IClone
{
    public int Thickness { get; set; }   
}

internal abstract class Shape : IShape
{
    public int X { get; set; }
    public int Y { get; set; }
    public IBorder Border { get; set; }

    public abstract void Render();  

    public IRender Clone()
    {
        var cloneBase = MemberwiseClone() as IShape;

        cloneBase.Border = Border.Clone() as IBorder;

        return cloneBase;
    }
}


