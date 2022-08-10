int a = 2;
int b = 10;

int max = 0;
int min = a;

if (a > max) max = a;
if (b > max) max = b;

Console.Write("max = ");
Console.WriteLine(max);

if (a < min) min = a;
if (b < min) min = b;

Console.Write("min = ");
Console.WriteLine(min);

