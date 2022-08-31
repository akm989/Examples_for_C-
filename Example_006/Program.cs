int a = 10;
int b = 18;
int c = 21;
int d = 17;
int e = 22;

int max = a;

if (a < b) max = b;
if (b < c) max = c;
if (c < d) max = d;
if (d < e) max = e;

Console.Write("max = ");
Console.WriteLine(max);
