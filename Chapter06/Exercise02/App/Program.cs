using static System.Console;

using Geometry;
using System.Security.Cryptography;
using System.Runtime.Intrinsics.Arm;

Rectangle r = new(Height: 3, Width: 4.5);
WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area: {r.Area}");

Square s = new(5);
WriteLine($"Square    H: {s.Height}, W: {s.Width}, Area: {s.Area}");

# if DEBUG
// experement--------------------------------------------------------------
Square s1 = new()
{
    Height = 3,
    Width = 11
};

WriteLine($"Square    H: {s1.Height}, W: {s1.Width}, Area: {s1.Area}");
//-------------------------------------------------------------------------
#endif

Circle c = new(radius: 4.5);
WriteLine($"Circle    H: {c.Height}, W: {c.Width}, Area: {c.Area}");

Console.ReadLine();