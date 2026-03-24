using System.Text;

string s = Console.ReadLine();
StringBuilder sb = new StringBuilder();

for (char c = 'a'; c <= 'z'; c++) {
    sb.Append(s.IndexOf(c) + " ");
}
Console.WriteLine(sb.ToString().Trim());