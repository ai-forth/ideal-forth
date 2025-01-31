// Begin program

Console.WriteLine("An example of the simplest task-runner fast-compute in c-sharp.");
Console.WriteLine("Computing operations with a vector struct.");

// Computations to perform.
var vec01 = new Vector(5, 4, 3);
var vec02 = new Vector(8, 9, 7);
var sum = vec01 + vec02;
Console.WriteLine("1 - Vector(5, 4, 3)");
Console.WriteLine("2 - Vector(8, 9, 7)");
Console.WriteLine("The sum of these vectors.: " + sum.V);

var diff = vec01 - vec02;
Console.WriteLine("1 - Vector(5, 4, 3)");
Console.WriteLine("2 - Vector(8, 9, 7)");
Console.WriteLine("The diff of these vectors.: " + diff.V);
//Console.ReadLine();

// Structures and operations for this program.
struct Vector
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    public int V { get; }

    public Vector(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public Vector(int v) : this()
    {
        V = v;
    }

    /// <summary>
    /// Addition of two Vectors
    /// </summary>
    /// <param name="v1">Vector to be added to </param>
    /// <param name="v2">Vector to be added</param>
    /// <returns>Vector representing the sum of two Vectors</returns>
    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X + v1.Y + v2.Y + v1.Z + v2.Z);
    }
    public static Vector operator -(Vector v1, Vector v2)
    {
        return new Vector((v1.X - v2.X) - (v1.Y + v2.Y) - (v1.Z + v2.Z));
    }
}

// End program