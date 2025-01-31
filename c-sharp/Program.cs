// Begin program

Console.WriteLine("An example of the simplest task-runner fast-compute in c-sharp.");
Console.WriteLine("Computing operations with a vector struct.");

// Computations to perform.
var sum = Vector.x + Vector.y;

// Outputs to print.
Console.WriteLine("Print the addition of two vectors.: " + sum);

// Structures and operations for this program.
struct Vector
{
    public static int x = 5;
    public static int y = 4;
}

// End program