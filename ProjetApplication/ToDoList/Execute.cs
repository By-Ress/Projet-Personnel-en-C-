// See https://aka.ms/new-console-template for more information


using ToDoList;
using static System.Console;

public class Execute
{
    public static void Main(string[] args)
    {
        Console.WriteLine("BONJOUR DANS VOTRE TODOLIST (VISIBLE SUR CONSOLE)!");
        ProgrammeTournant programmeTournant = new ProgrammeTournant();
        bool exec = true;
        while (exec == true)
        {
            var text = ReadLine();
            switch (text)
            {
                case "ADDTACHE" : programmeTournant.AddTache();
                    break;
                case "ADDELEM" : programmeTournant.AddTask();
                    break;
                case "SUPPTACHE" : programmeTournant.SupprimerTache();
                    break;
                case "SUPPELEM" : programmeTournant.SupprimerTask();
                    break;
                case "AFFTACHE" : programmeTournant.AfficherTache();
                    break;
                case "AFFALL" : programmeTournant.AfficherToutTache();
                    break;
                case "FINIRELEM" : programmeTournant.FinirTask();
                    break;
                case "CLEAR" : Console.Clear();
                    break;
                case "HELP" : Console.WriteLine("Les Commandes sont :\n" +
                                                "ADDTACHE pour ajouter une tache\n" +
                                                "ADDELEM pour ajouter un element a une tache\n" +
                                                "SUPPTACHE pour supprimer une tache definitivement\n" +
                                                "SUPPELEM pour supprimer un element a une tache\n" +
                                                "AFFTACHE pour afficher une tache\n" +
                                                "AFFALL pour afficher toutes les taches\n" +
                                                "FINIRELEM pour finir l'element d'une tache\n" +
                                                "CLEAR pour supprimer les elements de la console\n" +
                                                "HELP pour avoir accees au commande\n");
                    break;
                case "EXIT" : exec = false; 
                    break;
                default: Console.WriteLine("Taper HELP pour voir les commandes !!"); 
                    break;
            }
            Console.WriteLine("Veuiller entrer une commande : ");
        }
    }
}


/*
Tache tache1 = new Tache("Faire des projets");
   tache1.addTache("Allé chercher a manger pour le soir",
       "chaque soir je dois aller prendre un truc a manger car jai rien pour cuissiner a la maison");
   tache1.addTache("Faire les courses",
       "Je dois acheter de quoi dejeuner les matins afins que j'evite de manger dehors.");
   Console.WriteLine(tache1.ToText());
   tache1.FinirTache(1);
   Console.WriteLine(tache1.ToText());
   Tache tache2 = new Tache("Test Vide", "Pour tester comment reagis le code quand il n'y a rien dans les taches.");
   Console.WriteLine(tache2.ToText());
   */