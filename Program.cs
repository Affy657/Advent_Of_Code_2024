using System;
using System.IO;
using Lib;

// Fichier de configuration pour stocker les dernières valeurs
string configFileName = "config.txt";
int defaultDay = 1;        // Valeur par défaut pour le jour
bool defaultBonus = false; // Valeur par défaut pour le bonus

// Lire les valeurs par défaut depuis le fichier de configuration
if (File.Exists(configFileName))
{
    string[] config = File.ReadAllLines(configFileName);
    if (config.Length >= 2)
    {
        int.TryParse(config[0], out defaultDay);
        defaultBonus = config[1].ToLower() == "true";
    }
}

Console.WriteLine("=============================================");
Console.WriteLine("           - Advent of Code 2024 -           ");
Console.WriteLine("=============================================\n");

Console.Write($"=>  Entrez le numéro du jour (entre 1 et 25) [{defaultDay}] : ");
string input = Console.ReadLine();
int day = string.IsNullOrWhiteSpace(input) ? defaultDay : int.Parse(input);


if (day >= 1 && day <= 25)
{
    string fileName = $"inputDay{day:00}.txt";

    Console.Write($"=>  Voulez-vous la version bonus (n / y) [{(defaultBonus ? "y" : "n")}] ? ");
    string bonusInput = Console.ReadLine().ToLower();

    bool isBonus = string.IsNullOrWhiteSpace(bonusInput) ? defaultBonus : bonusInput == "y";


    try
    {
        Console.WriteLine($"\n[INFO] Lecture du fichier : {fileName}");
        string[] data = File.ReadAllLines(fileName);

        AlgoBuilder builder = new AlgoBuilder(day, isBonus);
        IAlgo algo = builder.Build();

        if (algo == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[ERREUR] Algo introuvable !");
            Console.ResetColor();
            return;
        }

        Console.WriteLine("\n[INFO] Exécution de l'algorithme...\n");
        string result = algo.Solve(data, true);

        Console.WriteLine("[RESULTAT] Résultat de l'algorithme :");
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(result);
        Console.ResetColor();
        Console.WriteLine("\n");

        File.WriteAllLines(configFileName, new[] { day.ToString(), isBonus.ToString() });

    }
    catch (FileNotFoundException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[ERREUR] Le fichier {fileName} n'existe pas.");
        Console.ResetColor();
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[ERREUR] Une erreur est survenue : {ex.Message}");
        Console.ResetColor();
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("[ERREUR] Entrée invalide. Veuillez entrer un nombre entre 1 et 25.");
    Console.ResetColor();
}


