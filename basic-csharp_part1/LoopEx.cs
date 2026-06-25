namespace basic_csharp_part1
{
    internal static class LoopEx
    {
        public static string GetKey()
        {
            const int key_length = 5;

            while (true)
            {
                Console.WriteLine("Veuillez entrer le mot clé: ");
                string key = Console.ReadLine();

                if (string.IsNullOrEmpty(key) || key.Length < key_length)
                {
                    Console.WriteLine("Le mot clé doit contenir au moins 5 caractères.");
                    continue;
                }

                if (key.Contains(' ') || key.Contains('\t'))
                {
                    Console.WriteLine("Le mot clé ne doit pas contenir d'espaces.");
                    continue;
                }

                return key;
            }
        }

        public static void getkeyV2()
        {
            var key = "";

            while (true)
            {
                Console.WriteLine("Veuillez entrer le mot clé: ");
                key = Console.ReadLine();

                if (key != "" && key.Length >= 5)
                {
                    if (!key.Contains(' ') && !key.Contains("\t"))
                        break;
                }
            }
        }
    }
}