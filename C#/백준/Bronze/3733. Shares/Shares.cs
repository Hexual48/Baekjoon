            string input;
            while ((input = Console.ReadLine()) != null)
            {
                string[] str = input.Split();
                if (str.Length < 2) continue;
                long n = long.Parse(str[0]);
                long s = long.Parse(str[1]);
                Console.WriteLine(s / (n + 1));
            }