namespace ToDoList;

public class ProgrammeTournant
{
    private static List<Tache> Taches = new List<Tache>();
    private int NumTache = Taches.Count;

    public ProgrammeTournant()
    {
        Console.WriteLine("Veuiller entrer une commande : ");
    }


    public void AddTache()
    {
        Console.WriteLine("Nom de la tache que vous voulez ajouter ?\n");
        string TacheName = Console.ReadLine();
        Console.WriteLine("Description de la tache que vous voulez ajouter ?\n");
        string TacheDescription = Console.ReadLine();
        Taches.Add(new Tache(TacheName, TacheDescription));
        Console.WriteLine("Ajouter avec sucess !\n");
    }

    public void AddTask()
    {
        Console.WriteLine("A quelle tache voulez vous rajouter des elements ? Entre 0 et " + NumTache + " \n");
        var num = Console.ReadLine();

        if(int.Parse(num) < 0 || int.Parse(num) > NumTache)
        {
            this.AddTask();
        }
        else
        {
            Console.WriteLine("Nom de la task que vous voulez ajouter ?\n");
            string TacheName = Console.ReadLine();
            Console.WriteLine("Description de la tache que vous voulez ajouter ?\n");
            string TacheDescription = Console.ReadLine();
            Taches[int.Parse(num)].addTache(TacheName, TacheDescription);
            Console.WriteLine("Ajouter avec sucess !\n");
        }
    }

    public void SupprimerTache()
    {
        Console.WriteLine("Quelle tache voulez vous supprimer ? Entre 0 et " + NumTache + " \n");
        int num = int.Parse(Console.ReadLine());
        if (num < 0 || num > NumTache)
        {
            Console.WriteLine("Est-ce que vous etes sur de supprimer " + num + " ?\n Si oui taper OUI sinon NON");
            string confirmation = Console.ReadLine();
            if (confirmation == "OUI")
            {
                Taches.RemoveAt(num);
                Console.WriteLine("Suprimmer avec succes ! \n");
            }
        }
        else
        {
            Console.WriteLine("Vous avez rentrer une valeur incorecte.\n");
        }
    }

    public void SupprimerTask()
    {
        Console.WriteLine("A quelle tache voulez vous supprimer un element ? Entre 0 et " + NumTache + " \n");
        int numTache = int.Parse(Console.ReadLine());
        if (numTache < 0 || numTache > NumTache)
        {
            Console.WriteLine("Quelle elements voulez vous supprimer ? Entre 0 et " +
                              Taches[numTache].getTasks().Count + " \n");
            int num = int.Parse(Console.ReadLine());
            if (num < 0 || num > Taches[numTache].getTasks().Count)
            {
                Console.WriteLine("Est-ce que vous etes sur de supprimer " + num + " ?\n Si oui taper OUI sinon NON");
                string confirmation = Console.ReadLine();
                if (confirmation == "OUI")
                {
                    Taches[numTache].getTasks().RemoveAt(num);
                    Console.WriteLine("Suprimmer avec succes ! \n");
                }
            }
            else
            {
                Console.WriteLine("Vous avez rentrer une valeur incorecte.\n");
            }
        }
    }

    public void AfficherTache()
    {
        Console.WriteLine("Quelle tache voulez vous voir ? Entre 0 et " + NumTache + " \n");
        int num = int.Parse(Console.ReadLine());
        if (num < 0 || num > NumTache)
        {
            Console.WriteLine(Taches[num].ToText());
        }
        else
        {
            Console.WriteLine("Mauvais numero veuiller ressayer !!\n");
        }
    }

    public void AfficherToutTache()
    {
        string text = "''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''\n";
        if (NumTache <= 0)
        {
            Console.WriteLine("Aucune tache actuellement !\n");
        }
        else
        {
            for (int i = 0; i < NumTache; i++)
            {
                text = text +"Tache numero "+ i + "\n";
                text += Taches[i].ToText();
                text += "''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''\n";
            }
            Console.WriteLine(text);
        }
    }

    public void FinirTask()
    {
        Console.WriteLine("A quelle tache voulez vous finir un element ? Entre 0 et " + NumTache + " \n");
        int numTache = int.Parse(Console.ReadLine());
        if (numTache < 0 || numTache > NumTache)
        {
            Console.WriteLine("Quelle tache voulez vous finir ? entre 0 et " + Taches[numTache].getTasks().Count +
                              " .\n");
            int num = int.Parse(Console.ReadLine());
            if (num < 0 || num > Taches[numTache].getTasks().Count)
            {
                Taches[numTache].FinirTache(num);
            }
        }
    }
}