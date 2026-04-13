            string str = Console.ReadLine();
            string ans = null;
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    ans += char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    ans += char.ToUpper(c);
                }
            }
            Console.WriteLine(ans);