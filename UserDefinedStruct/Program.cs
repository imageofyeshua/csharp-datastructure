public enum CurrencyEnum { WON, EUR, USD }

public readonly struct Price(decimal amount, CurrencyEnum currency)
{
    public readonly decimal Amount { get; init; } = amount;
    public readonly CurrencyEnum Currency { get; init; } = currency;

    public override string ToString() => $"{Amount} {Currency}";
}

class Program
{
    static void Main(string[] args)
    {
        Price priceRegular = new(100, CurrencyEnum.WON);
        System.Console.WriteLine(priceRegular);

        Price priceDiscount = priceRegular with { Amount = 50 };
        System.Console.WriteLine(priceDiscount);
    }
}