public record Dog(string Name, string Breed, int Height, float Weight, int Age);

class Program
{
    static void Main(string[] args)
    {
        Dog rex = new ("Rex", "Schnauzer", 40, 11, 5);
        Dog beauty = rex with { Name = "Beauty", Height = 35 };
        (string name, _, _, _, int age) = beauty;
    }
}
