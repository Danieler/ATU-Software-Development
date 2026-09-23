Console.Write("First integer: ");
if (!int.TryParse(Console.ReadLine(), out int first)) { Console.WriteLine("Invalid integer"); return; }
Console.Write("Second integer: ");
if (!int.TryParse(Console.ReadLine(), out int second)) { Console.WriteLine("Invalid integer"); return; }
if (second == 0) { Console.WriteLine("Cannot divide by zero"); return; }
Console.WriteLine(first % second == 0 ? "Exactly divisible" : "Not exactly divisible");
