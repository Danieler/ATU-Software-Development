Console.Write("Side A: ");
if (!double.TryParse(Console.ReadLine(), out double a)) { Console.WriteLine("Invalid number"); return; }
Console.Write("Side B: ");
if (!double.TryParse(Console.ReadLine(), out double b)) { Console.WriteLine("Invalid number"); return; }
Console.Write("Side C: ");
if (!double.TryParse(Console.ReadLine(), out double c)) { Console.WriteLine("Invalid number"); return; }
bool valid = double.IsFinite(a) && double.IsFinite(b) && double.IsFinite(c) &&
    a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
Console.WriteLine(valid ? "Valid triangle" : "Invalid triangle");
