// // Constants for the number of rows and columns
// const int ROWS = 3;
// const int COLS = 4;

// // Creates a 2Dimensional Array of Integers with 3 rows and 4 columns
// int[,] roundScore = new int[ROWS, COLS];

// // Begin Assigning Values by specifying row and column
// roundScore[0, 0] = 3;
// roundScore[0, 1] = 2;
// roundScore[0, 2] = 1;
// roundScore[0, 3] = 4;

// roundScore[1, 0] = 1;
// roundScore[1, 1] = 2;
// roundScore[1, 2] = 3;
// roundScore[1, 3] = 4;

// roundScore[2, 0] = 3;
// roundScore[2, 1] = 4;
// roundScore[2, 2] = 2;
// roundScore[2, 3] = 1;

// Alternatively, preset values, and automatic calculates number of rows and columns
using System.Diagnostics.CodeAnalysis;

int[,] roundScore =
{
//   0  1  2  3  << Columns
    {3, 2, 1, 4}, // row 0
    {1, 2, 3, 4}, // row 1
    {3, 4, 2, 1}  // row 2
};

// Get a specific value from a 2DArray (cell) - same as you assign
Console.WriteLine($"Round 0,3 is {roundScore[0,2]}");

// How can we get the length of 'rows' in a 2D array
int rowLength = roundScore.GetLength(0); // gets the # of rows
int colLength = roundScore.GetLength(1); // gets the # of columns

// How can we iterate over a 2 dimensional array? Need Nested Loop
// Print all values
for(int i = 0; i < rowLength; i++)
{
    for(int c = 0; c < colLength; c++)
    {
        Console.Write($"[{i}, {c}] {roundScore[i, c]}  ");
    }

    Console.WriteLine();
}

Console.WriteLine("\nAnother Example - How to do Sum in a 2x3 matrix?");

int[,] numbers = 
{
    {5, 1, 7},
    {2, 5, 1},
    {3, 2, 1}
};

// Show first
for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int c = 0; c < numbers.GetLength(1); c++)
    {
        Console.Write($"[{i}, {c}] {numbers[i, c]}  ");
    }

    Console.WriteLine();
}

Console.WriteLine($"Sum from 0,0 to 2,2");

int sum = 0;
for(int i = 0; i < numbers.GetLength(0); i++)
    sum += numbers[i, i];

Console.WriteLine($"Sum is {sum}");
    