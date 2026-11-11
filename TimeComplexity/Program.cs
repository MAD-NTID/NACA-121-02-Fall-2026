// O(1) - Constant Time
// O(N) - Linear Time
// O(n^2) - Quadratic Time

// Increase this number to observe how execution time changes
using System.Diagnostics;
using System.Runtime.Serialization.Formatters;

int student_size = 25000;

// Create an array of string
string[] students = new string[student_size];

// Fill the students array
for(int i = 0; i < student_size - 1; i++)
    students[i] = $"Student - {i + 1}";

// Let's put 'Peter' as the last student in the array
students[student_size - 1] = "Peter";

/*
    O(1) - Constant Time
    We already know where Peter is sitting. 

    We can access Peter directly using his array index.

    It does not matter whether there are 5 or 500 or 50000 students.

    Accessing a known array index takes constant time.
*/
Console.WriteLine($"O(1) - We know 'Peter' is in index {student_size - 1}");
Stopwatch peterStopWatchO1 = new Stopwatch();

peterStopWatchO1.Start();

string peter = students[student_size - 1];

peterStopWatchO1.Stop();

Console.WriteLine($"Found - '{peter}' at index position {student_size - 1}");
PrintElapses(peterStopWatchO1);

/*
    O(n) - Linear Time

    We know Peter is in the classroom, but we do not know which chair he is sitting in.

    We must check each student until we find Peter.

    Best Case Scenario Possible is that Peter is in the first chair, O(1)
    Worst Case Scenario is that Peter is in the last chair, O(n)
*/

Console.WriteLine($"O(n) - We don't know 'Peter's index");
Stopwatch findPeter = new Stopwatch();

findPeter.Start();

int peterIndex = -1;
for(int i = 0; i < student_size; i++)
{
    if(students[i] == "Peter")
    {
        peterIndex = i;
        peter = students[i];
        break;
    }
}

findPeter.Stop();

if(peterIndex >= 0 && peterIndex <= student_size)
    Console.WriteLine($"Found - '{peter}' at index position {peterIndex}");

PrintElapses(findPeter);

/*
    O(n^2) - Quadratic Time

    There are multiple classrooms, and each classroom contains multiple students.

    We do not know which classroom Peter is in or which chair he is sitting in.

    Best Case Scenario: Peter is in the first class in and the first seat
    Worst Case Scenario: Peter is in the last class in and the last seat
*/
int classroom_size = 50;
string[,] classroom = new string[classroom_size, student_size];

// Create N number of classrooms, with each having N number of students
for(int c = 0; c < classroom.GetLength(0); c++)
    for(int s = 0; s < classroom.GetLength(1); s++)
        classroom[c, s] = $"Classroom: {c} Student Number: {s}";

// Let's put Peter in a random classroom and random seat
Random random = new Random();
int randomClassroom = random.Next(0, classroom_size);
int randomSeat = random.Next(0, student_size);

classroom[randomClassroom, randomSeat] = "Peter";

Stopwatch peterSquare = new Stopwatch();

peterSquare.Start();

int peterClassroom = -1;
peterIndex = -1;

for(int c = 0; c < classroom.GetLength(0); c++)
    for(int s = 0; s < classroom.GetLength(1); s++)
        if(classroom[c, s] == "Peter")
        {
            peterClassroom = c;
            peterIndex = s;

            break;
        }

peterSquare.Stop();

if(peterClassroom >= 0 && peterIndex >= 0)
    Console.WriteLine($"Found - '{peter}' at in Classroom {peterClassroom} in seat # {peterIndex}");

PrintElapses(peterSquare);

void PrintElapses(Stopwatch stopwatch)
{
    Console.WriteLine(  $"{stopwatch.ElapsedMilliseconds}ms\n" + 
                    $"{stopwatch.ElapsedTicks} ticks\n" + 
                    $"{stopwatch.Elapsed}\n"); 
}