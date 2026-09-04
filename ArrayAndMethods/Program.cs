Console.WriteLine("Hello, World!");


int[] myFirstArray = new int[10];

myFirstArray[0] = 4;
myFirstArray[1] = 1;
myFirstArray[2] = 2;
myFirstArray[3] = 3;
myFirstArray[9] = 3;


System.Console.WriteLine("The length of the array is " + myFirstArray.Length);
int counter = 0;
for (counter = 0; counter < 4; counter++)
{
    System.Console.WriteLine(myFirstArray[counter]);
}
    // System.Console.WriteLine(myFirstArray[1]);
    // System.Console.WriteLine(myFirstArray[2]);
    // System.Console.WriteLine(myFirstArray[3]);

int mySum = sum(5,7);
System.Console.WriteLine("The sum of 5 + 7 is " + mySum);
mySum = sum(6);
System.Console.WriteLine("The sum of 6 + is " + mySum);

// int counter = 0;
// for (counter = 0; counter < 10; counter+=3)
// {
//     Console.WriteLine(counter);
// }


// Console.WriteLine("While Loop");

// counter = 0;
// while (counter < 10)
// {
//     Console.WriteLine(counter);
//     counter +=3;
// }

 static int sum(int num1, int num2 = 5)
{
    
    return num1 + num2;
}