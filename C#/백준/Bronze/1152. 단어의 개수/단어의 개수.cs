string n = Console.ReadLine().Trim();
if (string.IsNullOrEmpty(n))
{
    Console.Write(0);
}
else
{
    string[] w = n.Split(' ');
    Console.Write(w.Length);
}