using System.Xml;

namespace DemoBoucle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exemple boucle
            //int i = 10;
            //bool flag = true;
            //while (i > 0 && flag)
            //{
            //    Console.WriteLine("coucou" + i);
            //    if (i == 5)
            //    {
            //        Console.WriteLine("Bidule");
            //        flag = false;

            //        for (int j = 0; j < i; j++)
            //        {
            //            Console.WriteLine("for " + j);

            //        }
            //    }
            //    i--;
            //}
            //Console.WriteLine(i);

            //for (int max = 0; max < int.MaxValue; max++)
            //{
            //    if (max == 1000000000) Console.WriteLine("toto");
            //}
            //Console.Read();
            #endregion

            /*
             1) Definissez un mot de passe au préalable
                demander à l'utilisateur son mot de passe
                Si le mot de passe entré est correcte : Afficher "Bienvenue"
                Si l'utilisateur se trompe 3 fois, lui suggérer de rentrer chez lui

             2) A l'aide de boucle : 
                Afficher les tables de multiplication de 1 à 10

             3) Un magasin en ligne propose 3 articles
                Coca : 1€ (stock 4)
                Sandwich : 5€ (stock 2)
                Porte : 200€ (stock 3)

                Tant que l'utiliseur veut continuer ses achats, le programme
                continue à lui proposer la liste des articles en stock
                et lui demande de faire son choix (1 2 ou 3 )

                Quand il choisit d'arrêter, le programme affiche le total à payer
             */


            // exo 1 
            string mdpOK = "Test1234";
            string mdpTest = "";
            int nbTentative = 3;

            while(mdpOK != mdpTest && nbTentative > 0) 
            {
                Console.WriteLine("Entrez votre mot de passe");
                mdpTest = Console.ReadLine();
                nbTentative--;
                if(mdpOK != mdpTest && nbTentative != 0)
                    Console.WriteLine($"T'as foiré il te reste {nbTentative} tentatives");
              
            }

            Console.WriteLine((mdpOK == mdpTest) ? "Bienvenue" : "Rentre chez toi");
        }
    }
}
