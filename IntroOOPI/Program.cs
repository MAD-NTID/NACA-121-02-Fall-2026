// Create a new instance of a Car
// In other words, create an object of type Car
Car myNewCar = new Car();

// Assign Values to the myNewCar object attributes
myNewCar.make = "Toyota";
myNewCar.model = "Tercel";
myNewCar.year = 1993;
myNewCar.license = "NY-1234";

Console.WriteLine($"Your brand new car is a {myNewCar.year} {myNewCar.make} {myNewCar.model} with license plate {myNewCar.license}");

// Isaiah
Car isaiahCar = new Car();
isaiahCar.make = "BMW";
isaiahCar.model = "525i";
isaiahCar.year = 2025;
isaiahCar.license = "CA-1234";

Console.WriteLine($"Your brand new expensive and luxurious car is a {isaiahCar.year} {isaiahCar.make} {isaiahCar.model} with license plate {isaiahCar.license}");

// Abhik
Car abhikCar = new Car();
abhikCar.make = "Ford";
abhikCar.model = "Mustang GT";
abhikCar.year = 2023;
abhikCar.license = "NJ-1234";

Console.WriteLine($"Your brand new expensive and luxurious car and noisy is a {abhikCar.year} {abhikCar.make} {abhikCar.model} with license plate {abhikCar.license}");

// Shamik
Car shamikCar = new Car();
shamikCar.make = "Ferrari";
shamikCar.model = "S790";
shamikCar.year = 2024;
shamikCar.license = "NJ-4321";

Console.WriteLine($"Your brand new expensive and luxurious car and italian car is a {shamikCar.year} {shamikCar.make} {shamikCar.model} with license plate {shamikCar.license}");

// Prof. MB
Car profMBCar = new Car("Toyota", "Tacoma", 2006, "NY-4321");

Console.WriteLine($"Your brand new car is a {profMBCar.year} {profMBCar.make} {profMBCar.model} with license plate {profMBCar.license}");

// constant variable of type string named MICHAEL
 string MICHAEL = "Michael";

// Means you can't change its value once declared and initialized
MICHAEL = "Tony";