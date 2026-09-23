Console.Write("Enter marital status (S/M/W/E/D): ");
string? input = Console.ReadLine();
if (string.IsNullOrWhiteSpace(input) || input.Trim().Length != 1)
{
    Console.WriteLine("Error: invalid code");
    return;
}
switch (char.ToUpperInvariant(input.Trim()[0]))
{
    case 'S': Console.WriteLine("Single"); break;
    case 'M': Console.WriteLine("Married"); break;
    case 'W': Console.WriteLine("Widowed"); break;
    case 'E': Console.WriteLine("Separated"); break;
    case 'D': Console.WriteLine("Divorced"); break;
    default: Console.WriteLine("Error: invalid code"); break;
}
