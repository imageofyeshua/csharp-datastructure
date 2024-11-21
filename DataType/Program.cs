class Program
{
    static void Main(string[] args)
    {
        int a = -20;
        byte b = 0x0f;
        uint c = 0b01101110;

        System.Console.WriteLine($"Integer: {a}");
        System.Console.WriteLine($"Byte: {b}");
        System.Console.WriteLine($"Unsigned Integer: {c}");

        float temperature = 36.6f;
        double reading = -4.5179823;
        decimal salary = 100000.47M;

        System.Console.WriteLine($"Float: {temperature}");
        System.Console.WriteLine($"Double: {reading}");
        System.Console.WriteLine($"Decimal: {salary}");

        bool isTrue = true;
        bool first = isTrue || false;
        bool second = isTrue && false;
        bool third = 50 > 10;

        System.Console.WriteLine($"Bool: {isTrue}");
        System.Console.WriteLine($"Bool: {first}");
        System.Console.WriteLine($"Bool: {second}");
        System.Console.WriteLine($"Bool: {third}");

        char letter = 'M'; // character literal
        char bullet = '\u25cf'; // unicode
        char special = '\x107'; // hexadecimal

        System.Console.WriteLine($"Char: {letter}");
        System.Console.WriteLine($"Char: {bullet}");
        System.Console.WriteLine($"Char: {special}");

    }
}