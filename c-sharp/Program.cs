// Begin program

Console.WriteLine("An example of the simplest task-runner fast-compute in c-sharp.");
Console.WriteLine("Computing operations with a vector struct.");

// Computations to perform.
var vec01 = new Vector(5, 4, 3);
var vec02 = new Vector(8, 9, 7);
var vec03 = new Vector(14, 29, 37);
var sum01 = vec01 + vec02;
var sum02 = sum01 + vec03;
Console.WriteLine("1 - Vector(5, 4, 3)");
Console.WriteLine("2 - Vector(8, 9, 7)");
Console.WriteLine("3 - Vector(14, 29, 37)");
// The factor of cast in terms of projective geometry.
Console.WriteLine("The sum of these vectors: " + (sum01.V + sum02.V));

var diff01 = vec01 - vec02;
var diff02 = diff01 - vec03;
// The factor of negative cast in terms of projective geometry.
Console.WriteLine("The diff of these vectors: " + (diff01.V - diff02.V));

// Structures and operations.
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

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X + v1.Y + v2.Y + v1.Z + v2.Z);
    }
    public static Vector operator -(Vector v1, Vector v2)
    {
        return new Vector((v1.X - v2.X) - (v1.Y + v2.Y) - (v1.Z + v2.Z));
    }
}
struct Complex
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }
    public static Complex operator -(Complex c1, Complex c2)
    {
        return new Complex((c1.Real - c2.Real), (c1.Imaginary + c2.Imaginary));
    }
}

// End program