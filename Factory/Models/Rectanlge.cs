using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Models;

internal class Rectanlge : IShape
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Render()
    {
        Console.WriteLine($"Rendering {nameof(Rectanlge)}: ({X},{Y})");
    }
}
