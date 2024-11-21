using Statistics = (int Min, int Max, double Avg);

class Program
{
	static void Main(string[] args)
	{

		Statistics result = Calculate(4, 8, 13);
		System.Console.WriteLine($"Min = {result.Min} / Max = {result.Max} / Avg = {result.Avg:F2}");

		Statistics Calculate(params int[] numbers)
		{
			if (numbers.Length == 0) return (0, 0, 0);
			int min = int.MaxValue;
			int max = int.MinValue;
			int sum = 0;
			foreach (int number in numbers)
			{
				if (number > max) max = number;
				if (number < min) min = number;
				sum += number;
			}
			return (min, max, (double) sum / numbers.Length);
		}

		/*
		(int, int, double) result = Calculate(4, 8, 13);
		System.Console.WriteLine($"Min = {result.Item1} / Max = {result.Item2} / Avg = {result.Item3:F2}");
		
		(int, int, double) Calculate(params int[] numbers)
		{
			if (numbers.Length == 0) return (0, 0, 0);
			int min = int.MaxValue;
			int max = int.MinValue;
			int sum = 0;
			foreach (int number in numbers)
			{
				if (number > max) max = number;
				if (number < min) min = number;
				sum += number;
			}
			return (min, max, (double) sum / numbers.Length);
		}
		*/
	}
}