// Begin program

Console.WriteLine("An example of the simplest task-runner fast-compute in c-sharp.");
Console.WriteLine("Computing operations with a vector struct.");

// Computations to perform.
var sum = Vector.x + Vector.y + Vector.z;

// Outputs to print.
Console.WriteLine("Print the addition of two vectors.: " + sum);

// Structures and operations for this program.
struct Vector
{
    public static int x = 5;
    public static int y = 4;
    public static int z = 3;

    /// <summary>
        /// Addition of two Vectors
        /// </summary>
        /// <param name="v1">Vector to be added to </param>
        /// <param name="v2">Vector to be added</param>
        /// <returns>Vector representing the sum of two Vectors</returns>
        public static Vector operator +(Vector v1, Vector v2)
        {
            return v1.x + v2.x + v1.y + v2.y + v1.z + v2.z;
        }
}

// End program