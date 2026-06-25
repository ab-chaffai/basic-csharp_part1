using System.Collections;

namespace basic_csharp_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("                    Type de variable                          ");
            Console.WriteLine("==============================================================");

            // 1) Entier 
            byte age1 = 0; //0 - 255
            sbyte age2 = 0; // -127 à 128
            short age3 = 0; // -32768 à 32767
            ushort age4 = 0; // 65535 que les valeurs positives
            int age5 = 768; // plus de 2 milliard
            uint age6 = 4_100_674_764; // que les valeurs positives
            long age7 = 4_100_674_764_689;
            ulong age8 = 0; // que les valeurs positives

            // 2) / Décimaux
            float taille = 3.25f;
            decimal taille2 = 5.27m;
            double taille3 = 76.5843; // haute précision après la virgule

            // 3) Boolean
            bool isTrue = false;

            // 4) les Types Anonymes "variable"
            var ano = new { nom = "Jhon Doe", age = 35, genre = 'M' };
            var personnes = new[]
            {
                ano,
                new { nom = "Jhon Doe", age = 35, genre = 'F' },
                new { nom = "Al Doe", age = 15, genre = 'M' },
                new { nom = "Rui Doe", age = 25, genre = 'M' },
                new { nom = "Lucy Doe", age = 13, genre = 'F' },
                new { nom = "Erza Doe", age = 28, genre = 'F' }
            };

            var adultes = personnes.Where(p => p.age > 18);
            foreach (var item in adultes) Console.WriteLine(item);

            Console.WriteLine("Min Byte = " + Byte.MinValue + " ; Max Byte: " + Byte.MaxValue);
            Console.WriteLine("Min SByte = " + SByte.MinValue + " ; Max SByte: " + SByte.MaxValue);
            Console.WriteLine("Min Short = " + short.MinValue + " ; Max Short: " + short.MaxValue);
            Console.WriteLine("Min UShort = " + ushort.MinValue + " ; Max UShort: " + ushort.MaxValue);
            Console.WriteLine("Min Int = " + int.MinValue + " ; Max Int: " + int.MaxValue);
            Console.WriteLine("Min UInt = " + uint.MinValue + " ; Max UInt: " + uint.MaxValue);
            Console.WriteLine("Min Long = " + long.MinValue + " ; Max Long: " + long.MaxValue);
            Console.WriteLine("Min ULong = " + ulong.MinValue + " ; Max ULong: " + ulong.MaxValue);
            Console.WriteLine("Min Float = " + float.MinValue + " ; Max Float: " + float.MaxValue);
            Console.WriteLine("Min Decimal = " + decimal.MinValue + " ; Max Decimal: " + decimal.MaxValue);
            Console.WriteLine("Min Double = " + double.MinValue + " ; Max Double: " + double.MaxValue);

            Console.WriteLine("==============================================================");
            Console.WriteLine("                    II) Les Opérateurs                        ");
            Console.WriteLine("==============================================================");

            // Strict Inferiorité               " < "
            // Inferieur ou égale               " <= "
            // Strict Supperiorité              " > "
            // Superieur ou égale               " > "
            // Strict Egale                     " == "
            // Difference                       " != "
            // Non logique et Non binaire       " ! "
            // ET logique booléen               " && "
            // OU logique booléen               " || "
            // OU exclusif binaire / logique    " ^ "
            // Opérateur ternaire               " c ? t : f "

            Console.WriteLine("==============================================================");
            Console.WriteLine("                    III) Les Conditions                       ");
            Console.WriteLine("==============================================================");

            int age;
            age = 18;

            // ===========  If Else  ================
            if (age < 18)
            {
                Console.WriteLine("Vous etes mineur, vous avez: " + age + " ans");
            }
            else if (age >= 18 && age <= 60)
            {
                Console.WriteLine("Vous etes adulte, vous avez: " + age + " ans");
            }
            else
            {
                Console.WriteLine("Vous etes senior, vous avez: " + age + " ans");
            }

            // ===========  Switch case  ================
            switch (age)
            {
                case < 18:
                    Console.WriteLine("Vous etes mineur, vous avez: " + age + " ans");
                    break;
                case <= 60:
                    Console.WriteLine("Vous etes adulte, vous avez: " + age + " ans");
                    break;
                default:
                    Console.WriteLine("Vous etes senior, vous avez: " + age + " ans");
                    break;
            }

            // Switch Expression
            var order = 1;
            var moyenne = 12;

            // 01 exemple
            var prize = order switch
            {
                1 => "Gold",
                2 => "Silver",
                3 => "Bronze",
                _ => "No prize"
            };

            Console.WriteLine(prize);

            // 02 exemple
            var result = moyenne switch
            {
                < 10 => "Reprend l'année",
                > 10 and < 12 => "Passe en session",
                _ => "Valide l'année",
            };
            Console.WriteLine(result);

            // 03 exemple
            var result2 = order switch
            {
                int i when i > 2 => "la condition est correct pour i>2",
                _ => "La condition n'est pas remplie"
            };
            Console.WriteLine(result2);


            Console.WriteLine("==============================================================");
            Console.WriteLine("                     IV) Les Boucles                          ");
            Console.WriteLine("==============================================================");

            // ===========  1- While  ================
            var key = "";

            while (key == "")
            {
                Console.WriteLine("Veuillez entrer une clé correct: ");
                key = Console.ReadLine();
            }

            // ===========  2- While  ================
            do
            {
                Console.WriteLine("Veuillez entrer une clé correct: ");
                key = Console.ReadLine();
            } while (key == "");

            //exercice
            /*string myKey = LoopEx.GetKey();
            Console.WriteLine($"Mot clé valide: {myKey}");*/

            // ===========  3- For  ================
            string myText = "This is a for iteration";
            for (int i = 0; i < myText.Length; i++)
            {
                Console.Write(myText[i] + ", ");
            }

            Console.WriteLine("==============================================================");
            Console.WriteLine("                    V) Les Fonctions                          ");
            Console.WriteLine("==============================================================");

            var name = FunctionEx.getInfos("Veuillez rentrer votre Nom de famille ?"); ;
            var prenom = FunctionEx.getInfos("Veuillez rentrer votre Prenom ?", true); ;
            var yourAge = FunctionEx.getInfos("Veuillez rentrer votre Age ?", true, "int");

            FunctionEx.printInfos(name, prenom, int.Parse(yourAge));


            Console.WriteLine("==============================================================");
            Console.WriteLine("                    VI) Les Collections                       ");
            Console.WriteLine("==============================================================");

            // ===========  1- Les tableau  ================
            string[] names = new string[3];
            int[] ages = new int[3] { 3, 10, 12 };

            // remplir le tableau
            names[0] = "Emilie";
            names[1] = "Jhon";
            names[2] = "David";

            // parcourir le tableau avec forEach
            foreach (var nom in names)
            {
                Console.WriteLine(nom);
            }

            // dans la nouvelle syntaxe
            char[] gender = { 'F', 'M' };

            // ===========  2- Les Listes  ================
            List<string> nameList = new List<string>();
            var ageList = new List<int>();
            List<char> sexeList = new() { 'F', 'M' };

            string[] add_ = { "Franck", "Jhon", "Anna", "Amélie" };
            nameList.Add("Amélie");
            nameList.AddRange(add_);

            //suppression
            nameList.Remove("Jhon");
            nameList.RemoveAt(0);

            bool findIt(string item)
            {
                return item == "Amélie";
            }

            Predicate<string> match = findIt;

            nameList.RemoveAll(match);

            // ===========  3- Les ArrayList  ================
            ArrayList nameArray = new ArrayList();
            var ageArray = new ArrayList();
            ArrayList sexeArray = new() { 'F', 'M' };

            // ===========  4- Les Dictionnaires  ================
            Dictionary<string, string> city = new Dictionary<string, string>();
            Dictionary<string, string> city2 = new() { { "Anna", "Stanford" }, { "Alex", "Texas" } };
            city.Add("Jhon", "Denver");

            Console.WriteLine(city2["Anna"]);

            foreach (var item in city2) Console.WriteLine(item);

            city2.Remove("Anna");

            Console.WriteLine("==============================================================");
            Console.WriteLine("                    VII) Les Tuples                           ");
            Console.WriteLine("==============================================================");

            (string, int, char) tuple1 = ("Jhon Doe", 35, 'M');
            Console.WriteLine(tuple1.Item1);
            var (nom_j, age_j, gender_j) = ("Jana Doe", 23, 'F');
            Console.WriteLine(nom_j);
            (string nom_a, int age_a, char gender_a) tuple2 = ("Leyla", 28, 'F');
            Console.WriteLine(tuple2.nom_a);
            var t3 = ("Alexa Doe", 44, 'F');
            Console.WriteLine(t3.Item1);

            (string, int, char) getData()
            {
                return t3;
            }
        }
    }
}
