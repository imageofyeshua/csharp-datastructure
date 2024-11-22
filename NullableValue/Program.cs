class Program
{
    static void Main(string[] args)
    {
        int? age = 34;
        float? note = 5.5f;
        Nullable<bool> isAccepted = null;

        if (age != null) { System.Console.WriteLine(age.Value); }
        if (note.HasValue) { System.Console.WriteLine(note.Value); }

        int chosenAge = age ?? 18;
        float shownNote = note.GetValueOrDefault(5.0f);
        bool result = isAccepted.GetValueOrDefault(true);
        System.Console.WriteLine(result);

        DateTime date = new(1976, 11, 24);
        int? yourAge = GetAgeFromBirthDate(date);
        yourAge ??= 18; // same as yourAge = yourAge ?? 18
        System.Console.WriteLine(yourAge);

        int? GetAgeFromBirthDate(DateTime date)
        {
            double days = (DateTime.Now - date).TotalDays;
            return days > 0 ? (int)(days / 365) : null;
        }

        float? eternity = 1.23456789f;
        string? daysAhead = GetFormatted(eternity);
        System.Console.WriteLine(daysAhead);

        string? GetFormatted(float? number) => number?.ToString("F2");
    }
}