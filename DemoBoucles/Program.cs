namespace DemoBoucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boucles

            /* int i = 0;
             bool flag = true;
             while (i < 10 && flag) // Bien vérifier les conditions de sorties ! être dans la bonne plage.
             {
                 Console.WriteLine("Je boucle tant que la condition est vérifiée j'exécute mon code" +i +"fois");
                 if(i == 5)
                 {
                     Console.WriteLine("J'applique ceci quand la condition est OK");
                     flag = false; // le Bool passe faux et on sort
                 }
                 i++; // incrémentation du compteur pour stopper la boucle
                 // return; force la sortie (mais pas propre à utiliser comme ça)

             }*/

            /*
             1) définissez un mot de passe au préalable
            demander à l'utilisateur son mot de passe
            si le mot de passe entré est correcte : "afficher Bienvenue"
            si l'utilisateur se trompe 3 fois, lui suggérer de rentrer chez lui
              
             */


            /*                string mdp = "azer1234";
                            bool acces = false;
                            int i = 2;
                            Console.WriteLine("Veuillez entrer votre mot de passe");

                            while (i >= 0  && !acces)
                            {

                                string mdpUser = Console.ReadLine();
                                if (mdp == mdpUser && !acces)
                                {
                                    Console.WriteLine("Bienvenue");
                                    acces = true;
                                }
                                else if (mdp != mdpUser)
                                {
                                    Console.WriteLine($"Mauvaise saisie veuillez réssayer, il vous reste {i} essai(s)");
                                    i--;
                                }
                                else
                                    Console.WriteLine("Rentre chez toi");*/

            // CORRECTION EXO1
            /*            string mdpOK = "Test1234";
                        string mdpTest = "";
                        int nbTentative = 3;

                        while(mdpOK != mdpTest && nbTentative > 0)
                        {
                            Console.WriteLine("Entrez votre mot de passe");
                            mdpTest = Console.ReadLine();
                            nbTentative--;
                            if(mdpOK != mdpTest && nbTentative != 0)
                                Console.WriteLine($" Il te reste {nbTentative} tentatives");
                        }

                        Console.WriteLine((mdpOK == mdpTest) ? "Bienvenue" : "Rentre chez toi");*/


            #endregion

            #region exo_2_boucles

            // afficher tables mulitiplication de 1 à 10 avec boucles

            /*for(int i = 1; i <= 10; i++)
            {
                    Console.WriteLine($"-----Table de {i}-----");
                for (int j = 1; j <= 10; j++) 
                {
                    Console.WriteLine($"{i} x {j} = {i*j}");
                    
                }
                
            }*/

            #endregion

            #region exo_3_magasin

            /* magasin propose 3 articles
             coca : 1€ (stock 4)
            sandwich : 5€ (stock 2)
            porte 200€ (stock 3) 

             Tant que l'utilisateur veut continuer ses achats, le programme lui propose la liste des articles en stock et lui demande
            un choix (1 2 3)
            quand il veut stopper le prog affiche le total à payer 
             */

            /*            int stockCoca = 4;
                        int stockSandwich = 2;
                        int stockPorte = 3;

                        bool continuerAchat = true;
                        int choix;
                        int total = 0;

                        while(continuerAchat)
                        { 
                           Console.WriteLine($"Bienvenue dans la boutique en ligne, vous pouvez acheter 3 articles différents");
                           Console.WriteLine($" Choix 1 : Coca (stock disponible {stockCoca})");
                           Console.WriteLine($" Choix 2 : Sandwich (stock disponible {stockSandwich})");
                           Console.WriteLine($" Choix 3 : Porte (stock disponible {stockPorte})");
                           Console.WriteLine($"Choix 4: Quitter et payer vos achats");
                           choix = int.Parse( Console.ReadLine() );

                            switch (choix)
                            {
                                case 1:
                                    if (stockCoca > 0)
                                    {
                                        Console.WriteLine($"Voici votre Coca");
                                        stockCoca--;
                                        total += 1;
                                    }
                                    else
                                        Console.WriteLine("Ce choix n'est plus disponible");
                                    break;

                                case 2:
                                    if (stockSandwich > 0)
                                    {
                                        Console.WriteLine($"Voici votre sandwich");
                                        stockSandwich--;
                                        total += 5;
                                    }
                                     else
                                        Console.WriteLine("Ce choix n'est plus disponible");
                                    break;

                                case 3:
                                    if (stockPorte > 0)
                                    {
                                        Console.WriteLine($"Voici votre porte");
                                        stockPorte--;
                                        total += 200;
                                    }
                                    else
                                        Console.WriteLine("Ce choix n'est plus disponible");
                                    break;

                                case 4:
                                    continuerAchat = false;
                                    break;
                                default: Console.WriteLine("veuillez choisir uniquement 1/2/3/4");
                                    break;
                            }
                        }
                        Console.WriteLine($"Merci pour vos achats");
                        Console.WriteLine($"Le total de vos achats est de : {total} euro(s)");
            */
            #endregion

            #region exo_tableau


        }
    }
}
