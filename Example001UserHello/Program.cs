// See https://aka.ms/new-console-template for more information

// Console.Write("Enter YOUR NAME ");
// string username = Console.ReadLine(); 
// 
// Console.Write("Привет, ");
// Console.Write(username);

// int d = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"d равно {d}");
int lut = 1;
for ( ;lut<4; )
{   int k = new Random().Next(-100,10);
    Console.WriteLine(k + "  \n");
    lut++;
}