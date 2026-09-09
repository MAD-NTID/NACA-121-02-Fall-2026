public class Car
{
    // { } is the encapsulation at the top level of the class
    
    // The make of the car (company that makes it)
    public string make;

    // The model of the car
    public string model;

    // Year the car was made
    public int year;

    // License plate of the car such as NY-1234
    public string license;

    // This is an empty contructor, AKA. Default Constructor
    public Car() {}

    // This is a parameterized constructor
    public Car(string make, string model, int year, string license)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.license = license;
    }
}