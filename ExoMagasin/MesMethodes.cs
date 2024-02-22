using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoMagasin
{
    internal class MesMethodes
    {
        internal static void Magasin()
        {
            AfficherMenu();
            CreerStock();
            PanierClient();
            Achat();
        }
        internal static Dictionary<string, int> gestionstock;
        internal static Dictionary<string, int> panier;
        //int choixUser;
        //double montantAchat = 0;

        internal static void CreerStock()
        {
            //création du dictionnaire avec clé(article) et valeur(stock)
            gestionstock = new Dictionary<string, int>()
            {{"Coca", 4 },{"Sandwich", 2},{"Porte", 3 } };
        }

        internal static void AfficherMenu()
        {
            Console.WriteLine(" _________________________________________________________________________________");
            Console.WriteLine("|                                                                                 |");
            Console.WriteLine($"| Bienvenue dans la boutique en ligne, vous pouvez acheter 3 articles différents  |");
            Console.WriteLine("|_________________________________________________________________________________|");
            Console.WriteLine("");
            Console.WriteLine($" Choix 1 : Coca");
            Console.WriteLine($" Choix 2 : Sandwich");
            Console.WriteLine($" Choix 3 : Porte");
            Console.WriteLine($"Choix 4: Quitter et payer vos achats");
        }
        internal static void CalcultotalAchat()
        {
            // prix de l'article multiplié par la quantité dans le pannier
            double montantAchat = (panier["Coca"] * 1) + (panier["Sandwich"] * 5) + (panier["Porte"] * 200);
            Console.WriteLine($"Le montant total de vos achats est de {montantAchat} euros");
        }

        internal static void PanierClient()
        {
            // initialisation du panier au départ
            panier = new Dictionary<string, int>()
            {{"Coca", 0 },{"Sandwich", 0},{"Porte", 0 } };
        }

        internal static void Achat()
        {
            bool skip = false;
            while (!skip)
            {
                int choixUser = int.Parse(Console.ReadLine());// retirer du stock et ajouter au panier

                switch (choixUser)
                {
                    case 1:
                        if (gestionstock["Coca"] > 0)
                        {
                            gestionstock["Coca"] -= 1;
                            panier["Coca"] += 1;
                        }
                        else
                        {
                            Console.WriteLine("L'article n'est plus en stock");
                        }
                        break;

                    case 2:
                        if (gestionstock["Sandwich"] > 0)
                        {
                            gestionstock["Sandwich"] -= 1;
                            panier["Sandwich"] += 1;
                        }
                        else
                        {
                            Console.WriteLine("L'article n'est plus en stock");
                        }
                        break;

                    case 3:
                        if (gestionstock["Porte"] > 0)
                        {
                            gestionstock["Porte"] -= 1;
                            panier["Porte"] += 1;
                        }
                        else
                        {
                            Console.WriteLine("L'article n'est plus en stock");
                        }
                        break;

                    case 4:
                        CalcultotalAchat();
                        skip = true;
                        break;
                    default: Console.WriteLine("Veuillez choisir 1, 2, 3 ou 4");
                        break;

                }
            }

        }
        
    }
}
