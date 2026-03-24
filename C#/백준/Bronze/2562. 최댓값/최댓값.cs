int b = 0;
int c = 0;
for (int i = 0; i < 9; i++)
{
    int a = int.Parse(Console.ReadLine());
    if (a > b)
    {
        b = a;
        c = i+1;
    }
}
Console.WriteLine(b);
Console.Write(c);