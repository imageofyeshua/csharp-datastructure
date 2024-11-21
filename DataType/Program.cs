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

        const int DaysInWeek = 7;
        System.Console.WriteLine($"Const: {DaysInWeek}");

        CurrencyEnum currency = CurrencyEnum.WON;

        switch(currency)
        {
            case CurrencyEnum.WON:
                System.Console.WriteLine("It's Won");
                break;
            case CurrencyEnum.EUR:
                System.Console.WriteLine("It's Euro");
                break;
            case CurrencyEnum.USD:
                System.Console.WriteLine("It's Dollar");
                break;
            default:
                System.Console.WriteLine("Nothing");
                break;
        }

        ActionEnum guest = ActionEnum.List;
        System.Console.WriteLine($"Guest: {guest.ToString("G")}");
        System.Console.WriteLine($"Guest: {guest.ToString("F")}");
        System.Console.WriteLine($"Guest: {guest.ToString("D")}");
        System.Console.WriteLine($"Guest: {guest.ToString("X")}");

        ActionEnum user = ActionEnum.List | ActionEnum.Details;
        System.Console.WriteLine($"User: {user.ToString("X")}");
        ActionEnum editor = ActionEnum.List | ActionEnum.Add | ActionEnum.Edit;
        System.Console.WriteLine($"Editor: {editor.ToString("X")}");
    }

    [Flags]
    enum ActionEnum
    {
        None = 0b_0000_0000, // 0
        List = 0b_0000_0001, // 1
        Details = 0b_0000_0010, // 2
        Add = 0b_0000_0100, // 4
        Edit = 0b_0000_1000, // 8
        Delete = 0b_0001_0000, // 16
        Publicsh = 0b_0010_0000, // 32
    }

    enum CurrencyEnum
    {
        WON,
        USD,
        EUR
    }
}