Console.Write("Irish time (HH.MM): ");
string? input = Console.ReadLine();
string[] parts = (input ?? "").Split('.');
if (parts.Length != 2 || parts[1].Length != 2 ||
    !int.TryParse(parts[0], out int hours) || !int.TryParse(parts[1], out int minutes) ||
    hours is < 0 or > 23 || minutes is < 0 or > 59)
{
    Console.WriteLine("Invalid time. Use HH.MM, for example 22.35");
    return;
}
Console.WriteLine($"Washington: {(hours - 5 + 24) % 24:D2}:{minutes:D2}");
Console.WriteLine($"Moscow:     {(hours + 3) % 24:D2}:{minutes:D2}");
Console.WriteLine($"Tokyo:      {(hours + 9) % 24:D2}:{minutes:D2}");
