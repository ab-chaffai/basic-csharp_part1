using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace basic_csharp_part1
{
    internal static class FunctionEx
    {
        public static string getInfos(string message, bool required = false, string format = null)
        {
            var info = "";
            var loop = false;
            int step;

            do
            {
                // Affiche le message de demande
                Console.WriteLine(message);
                info = Console.ReadLine();

                // Vérifie si le champ est obligatoire et vide
                if (string.IsNullOrWhiteSpace(info) && required)
                {
                    Console.WriteLine("Ce champ est obligatoire !");
                    loop = true;
                }
                else loop = false;

                // Vérifie si le format attendu est un entier
                if (format != null && format == "int")
                {
                    // TryParse retourne false si la valeur n'est pas un entier
                    if (!int.TryParse(info, out step))
                    {
                        Console.WriteLine("Données incorrectes ! Veuillez entrer un nombre, S.V.P.");
                        loop = true;
                    }
                }
            }
            while (loop); // Répète tant que la saisie est invalide

            return info;
        }

        public static void printInfos(string name, string prenom, int age)
        {
            Console.WriteLine($"Je m'appelle : {name} {prenom} et j'ai {age} ans");
        }
    }
}