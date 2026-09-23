Console.Write("First integer: ");
if (!int.TryParse(Console.ReadLine(), out int first)) { Console.WriteLine("Invalid integer"); return; }
Console.Write("Second integer: ");
if (!int.TryParse(Console.ReadLine(), out int second)) { Console.WriteLine("Invalid integer"); return; }
int minimum = first < second ? first : second;
Console.WriteLine($"Minimum: {minimum}");
