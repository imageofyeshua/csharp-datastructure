public class Person
{
    private string _location = string.Empty;
    public string Name { get; set; }
    public required int Age { get; set; }

    public Person() => Name = "---";

    public Person(string name)
    {
        Name = name;
    }

    public void Relocate(string location)
    {
        if (!string.IsNullOrEmpty(location))
        {
            _location = location;
        }
    }

    // public float GetDistance(string location)
    //     => DistanceHelper.GetDistance(_location, location);
}