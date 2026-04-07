using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();

Console.WriteLine(2000);

for (int i = 0; i < 1000; i++)
{
    sb.Append("1 ");
}

for (int j = 0; j < 1000; j++)
{
    sb.Append("1000 ");
}

Console.WriteLine(sb.ToString().TrimEnd());