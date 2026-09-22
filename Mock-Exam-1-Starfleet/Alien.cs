public class Alien
{
    private string name;
    public string Name
    {
        set
        {
            if(!string.IsNullOrEmpty(value))
                name = value;
            else
                name = "Undefined";
        }

        get
        {
            return name;
        }
    }

    private string role;
    public string Role
    {
        get
        {
            return role;    
        }

        private set
        {
            if(IsRoleValue(value))
                role = value;
            else
                role = "Unknown Role";
        }
    }

    public Alien(string name, string role)
    {
        Name = name;
        Role = role;
    }

    private bool IsRoleValue(string role)
    {
        return role == "Captain" ||
            role == "Chief Officer" || 
            role == "Navigator" || 
            role == "Engineer" || 
            role == "Doctor";
    }

    public override string ToString()
    {
        return $"Name: {name} Role: {role}";
    }
}