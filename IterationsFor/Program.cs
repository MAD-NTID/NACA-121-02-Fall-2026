// For loops are good for when you know the number of times to loop
// What is the For Loop good for?

// Practical Approach for Programming a Menu
// Don't Worry About this Yet, it's like a List in Python
string[] menu =
{
    "Option 1",
    "Option 2",
    "Option 3",
    "Exit"
};

// We can use a "list" with a for loop to dynamically display a menu listing
// This is good in case you later update your menu and you don't have to touch
// the code to display the new menu, only the list
for(int i = 0; i < menu.Length; i++)
{
    Console.WriteLine($"{i + 1} - {menu[i]}");
}

Console.Write("Select an Option: ");