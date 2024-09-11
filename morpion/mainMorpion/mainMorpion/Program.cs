using System;
using System.Diagnostics;
using System.Numerics;

class Hello
{
    static void Main()
    {
        jeu jouer = new jeu();
        jouer.jeueee();
    }
}



public class jeu
{

    public bool siGagnant(char[,] grille, char pion)
    {
        if (grille[0,0].Equals(pion) & grille[0,1].Equals(pion) & grille[0,2].Equals(pion) |
            grille[1,0].Equals(pion) & grille[1,1].Equals(pion) & grille[1,2].Equals(pion) |
            grille[2,0].Equals(pion) & grille[2,1].Equals(pion) & grille[2,2].Equals(pion) |
            
            grille[0,0].Equals(pion) & grille[1,0].Equals(pion) & grille[2,0].Equals(pion) |
            grille[0,1].Equals(pion) & grille[1,1].Equals(pion) & grille[2,1].Equals(pion) |
            grille[0,2].Equals(pion) & grille[1,2].Equals(pion) & grille[2,2].Equals(pion) |
            
            grille[0,0].Equals(pion) & grille[1,1].Equals(pion) & grille[2,2].Equals(pion) |
            grille[2,0].Equals(pion) & grille[1,1].Equals(pion) & grille[0,2].Equals(pion) )
        {
            return true;
        }
        else
        {
            return false;
        }
        
        
        
    }
    public void jeueee()
    {
        const int TAILLE = 3;
        char[,] grille = new char[TAILLE,TAILLE];
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                grille[i,j] = ' ';
            }
        }

        bool encours = true;
        int joueur = 1;
        char pionJoueur = 'X';
        int x, y;
        bool champsValide = false;
        while (encours)
        {
            
            Console.Clear();
            for (int i = 0; i < TAILLE; i++)
            {
                Console.Write("|");
                for (int j = 0; j < TAILLE; j++)
                {
                    Console.Write(grille[i,j]+"|");
                }
                Console.WriteLine();
            }

            if (joueur == 1)
            {
                Console.WriteLine("Joueur 1 a vous de jouer : x,y");
            }
            else
            {
                Console.WriteLine("Joueur 2 a vous de jouer : x,y");
            }

            
            while (!champsValide)
            {
                x=Convert.ToInt32(Console.ReadLine());
                y=Convert.ToInt32(Console.ReadLine());

                if (x>=0 & x<=2 & y>=0 & y<=2 )
                {
                    if (grille[y,x]==' ')
                    {
                         champsValide = true;
                         grille[y, x] = pionJoueur;
                    }
                    else
                    {
                        Console.WriteLine("Ressaye champs invalide !! ");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Ressaye champs invalide !! ");
                }
            }

            champsValide = false;

            if (siGagnant(grille,pionJoueur))
            {
                Console.Clear();
                encours = false;
                Console.WriteLine("joueur "+ joueur + " a gagner !!!");
                for (int i = 0; i < TAILLE; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < TAILLE; j++)
                    {
                        Console.Write(grille[i,j]+"|");
                    }
                    Console.WriteLine();
                }
            }



            if (joueur==1)
            {
                joueur = 2;
                pionJoueur = 'O';
            }
            else
            {
                joueur = 1;
                pionJoueur = 'X'; 
            }
            
        }
        
        
    }
}