int n = int.Parse(Console.ReadLine());
        
List<int> result = new List<int>();
        
for (int i = 0; i < 1000; i++)
{
    result.Add(1);
}
        
for (int j = 0; j < 1000; j++)
{
    result.Add(1000);
}
        
Console.Write(result.Count+"\n");
        
Console.Write(string.Join(" ", result)+"\n");