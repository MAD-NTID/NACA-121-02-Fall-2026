public class Car
{
    // { } is the encapsulation at the top level of the class
    
    // The make of the car (company that makes it)
    private string make; // Attribute associated with the Make Property
    public string Make //  Property - exposed to modify the make attribute
    {
        get { return make; }
        set
        {
            if(!string.IsNullOrEmpty(value))
                make = value;
            else
                make = "Invalid Make";
        }
    }

    // The model of the car
    public string model;

    // Year the car was made
    public int year;

    // License plate of the car such as NY-1234
    public string license;

    private bool running;

    // This is an empty contructor, AKA. Default Constructor
    public Car() {}

    // This is a parameterized constructor
    public Car(string make, string model, int year, string license)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.license = license;
        running = false;
    }

    public string RevUp()
    {
        // if(EngineIsRunning()) // or use attribute directly
        if(running)
            return "Vroom vroom vroom";
        
        return "Engine is not Running";
    }

    // Suppose we want to start engine and rev up (to ensure car is running)
    // We use overload method RevUp with an option to start engine or not
    public string RevUp(bool startEngine)
    {
        running = startEngine;

        return RevUp();
    }

    public string RevUp(bool startEngine, int revPower)
    {
        RevUp(startEngine);

        string revTimes = "";

        for(int i = 0; i < revPower; i++)
            revTimes += "vroom ";

        return revTimes;
    }

    // Void method, does not return value, but does midify some variable
    public void StartEngine()
    {
        // Start the engine
        running = true;
    }

    // Getter (gets the value of an attribute)
    public bool EngineIsRunning()
    {
        return running;
    }

    // Override the ToString() method to return a custom string
    public override string ToString()
    {
        return $"Make: {make}\nModel: {model}\nYear: {year}\nLicense: {license}\nRunning Status: {running}";
    }
}