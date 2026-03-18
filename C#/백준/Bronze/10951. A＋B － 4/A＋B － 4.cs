string input;
while ((input = Console.ReadLine()) != null)
{
    int[] a = Array.ConvertAll(input.Split(' '), int.Parse);
    Console.Write(a[0] + a[1] + "\n");
}