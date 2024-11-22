class Program
{
    static void Main(string[] args)
    {
        int age = 28;
        object ageBoxing = age;
        int ageUnboxing = (int)ageBoxing;
        System.Console.WriteLine(ageUnboxing);

        string firstName = "Daniel", lastName = "Park";
        int year = 1976;
        int rapture = 2025;
        string note = firstName + " " + lastName.ToUpper()
            + " was born in " + year;
        string initials = firstName[0] + "." + lastName[0] + ".";
        System.Console.WriteLine(note);
        System.Console.WriteLine(initials);

        string note2 = string.Format("{0} {1} will leave this world in {2}", firstName, lastName.ToUpper(), rapture);
        System.Console.WriteLine(note2);
        string note3 = $"{firstName} {lastName.ToUpper()} will definitely be up in the sky in {rapture}";
        System.Console.WriteLine(note3);

        string[] names = ["Jason", "Eunice", "Issac", "Daniel"];
        DateTime[] dates = [new(1971, 10, 11), new(1973, 7, 9), new(2012, 12, 20), new(1976, 11, 24)];
        float[] temperatures = [35.5f, 34.1f, 45.2f, 89.0f];
        System.Console.WriteLine($"{"Name", -8} {"Birth date", 10} {"Temp. [C]", 11} -> Result");
        for (int i = 0; i < names.Length; i++)
        {
            string line = $"{names[i], -8} {dates[i], 10:dd.MM.yyyy} {temperatures[i], 11:F1} -> {
                temperatures[i] switch
                {
                    > 40.0f => "Very high",
                    > 37.0f => "High",
                    > 36.0f => "Normal",
                    > 35.0f => "Low",
                    _ => "Very low"
                }
            }";
            System.Console.WriteLine(line);
        }
    }
}