using System.Globalization;

namespace DemoCSharpBase
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region code_formateur
            /*   //string s = Console.ReadLine();
            #region Exemple
            //string s = Console.ReadLine();

               //DateTime today = new DateTime();
               //int x = int.Parse(s);

               ////x.ToString();

               //object o = "toto";



               //x = (string)o + 3;

               //Console.WriteLine(x);

               //Console.WriteLine($"La date du \n jour est \t{today}");

               //int x, y;
               //Console.Write("Entrez nombre 1 : ");
               //jour = int.Parse(Console.ReadLine());
               //Console.Write("Entrez nombre 2 : ");
               //mois = int.Parse(Console.ReadLine());

               //Console.WriteLine(x/y);
               //Console.WriteLine(x%y);
               //Console.WriteLine((float)x / y);

               //demander la date de naissance a l'utilisateur
               //calculer son age actuel
               //afficher

               int jour, mois, annee;

               Console.Write("Jour ? ");
               jour = int.Parse(Console.ReadLine());

               Console.Write("Mois ? ");
               mois = int.Parse(Console.ReadLine());

               Console.Write("année ? ");
               annee = int.Parse(Console.ReadLine());

               DateTime date = new DateTime(2024, 02, 16);

               DateTime dateNaissance = new DateTime(annee,mois,jour);
               DateTime date2 = DateTime.Now;

               //int age = date2.Year - dateNaissance.Year;           
               //Console.WriteLine(age);

               //Console.WriteLine(dateNaissance);
               TimeSpan s = date2.Subtract(dateNaissance);

               int ageOk = (int)(s.TotalDays / 365.25);
               Console.WriteLine(ageOk);


               if(ageOk >= 18 && ageOk < 67)
               {
                   Console.WriteLine("Tu peux travailler");
                   if(ageOk >= 21) Console.WriteLine("Tu peux perdre tout ton fric au casino");
               }
               else
               {
                   if(ageOk < 18) Console.WriteLine("Retourne à l'école gamin");
                   if(ageOk >= 67) Console.WriteLine("Tu peux enfin profiter de ta jeunesse");
               }

               string role = "admin";

               switch(role)
               {
                   case "admin":
                       Console.WriteLine("T'as tout les droits");
                       break;
                   case "modo":
                       Console.WriteLine("Tu peux ban les boulets");
                       break;
                   case "user":
                       Console.WriteLine("Tu peux jouer");
                       break;
                   default:
                       Console.WriteLine("Role inexistant");
                       break;
               }

               // if (condition dans la paranthèse) ? true : false
               string reponse = (role == "admin") ? "Tu peux tout faire" : 
                   (role == "modo") ? "j'ai des droit" : "je peux juste jouer";

               if(role == "admin")
               {
                   reponse = "Tu peux tout faire";
               }
               else
               {
                   reponse = "Tu peux juste jouer";
               }

               Console.WriteLine(reponse);*/
            //int jour, mois, annee;

            //Console.Write("Jour ? ");
            //jour = int.Parse(Console.ReadLine());

            //Console.Write("Mois ? ");
            //mois = int.Parse(Console.ReadLine());

            //Console.Write("année ? ");
            //annee = int.Parse(Console.ReadLine());

            //DateTime date = new DateTime(2024, 02, 16);

            //DateTime dateNaissance = new DateTime(annee,mois,jour);
            //DateTime date2 = DateTime.Now;

            ////int age = date2.Year - dateNaissance.Year;           
            ////Console.WriteLine(age);

            ////Console.WriteLine(dateNaissance);
            //TimeSpan s = date2.Subtract(dateNaissance);

            //int ageOk = (int)(s.TotalDays / 365.25);
            //Console.WriteLine(ageOk);


            //if(ageOk >= 18 && ageOk < 67)
            //{
            //    Console.WriteLine("Tu peux travailler");
            //    if(ageOk >= 21) Console.WriteLine("Tu peux perdre tout ton fric au casino");
            //}
            //else
            //{
            //    if(ageOk < 18) Console.WriteLine("Retourne à l'école gamin");
            //    if(ageOk >= 67) Console.WriteLine("Tu peux enfin profiter de ta jeunesse");
            //}

            //string role = "admin";

            //switch(role)
            //{
            //    case "admin":
            //        Console.WriteLine("T'as tout les droits");
            //        break;
            //    case "modo":
            //        Console.WriteLine("Tu peux ban les boulets");
            //        break;
            //    case "user":
            //        Console.WriteLine("Tu peux jouer");
            //        break;
            //    default:
            //        Console.WriteLine("Role inexistant");
            //        break;
            //}

            //// if (condition dans la paranthèse) ? true : false
            //string reponse = (role == "admin") ? "Tu peux tout faire" : 
            //    (role == "modo") ? "j'ai des droit" : "je peux juste jouer";

            //if(role == "admin")
            //{
            //    reponse = "Tu peux tout faire";
            //}
            //else
            //{
            //    reponse = "Tu peux juste jouer";
            //}

            //Console.WriteLine(reponse); 
            #endregion

            #region exo_magasin
            /*
                Mettre en place un système de vente basique
                Demander à l'utilisateur combien d'article il souhaite
                
                tout les 2 articles, le 3eme lui est offert
                2 + 1
                chiffre % 2 = 0
                Annoncer à l'utilisateur combien il doit en payer et combien sont gratuits
                (pas de calcul de prix ou de choix d'article... pour le moment...)

                Il faut savoir que le magasin n'a que 14 articles en stock
                Et si le client en commande 40, il n'en recevra quand même que 14

                Si le client passe sa carte de fidélité, il recoit 1 article gratuit 
                pour chaque article acheté

                
             */

            int nbArticlegratuit = 0;
            int nbArticle;
            int stockArticle = 14;
            float prixArticle = 0;

            Console.WriteLine("Combien d'article(s) voulez-vous acheter ?");
            nbArticle = int.Parse(Console.ReadLine());

            Console.WriteLine("Quel est le prix d'un article ?");
            prixArticle = float.Parse(Console.ReadLine());

            if (nbArticle <= stockArticle)
            {
                nbArticlegratuit = nbArticle / 3;
            }
            else
            {
                nbArticlegratuit = stockArticle/3;
                nbArticle = stockArticle;
                Console.WriteLine($"Vous recevrez seulement {stockArticle}, vous êtes gourmand et prenez tout le stock!");
            }
            Console.WriteLine($"Vous avez {nbArticlegratuit} gratuit(s)");
            Console.WriteLine($" Vous devez payer {(nbArticle-nbArticlegratuit)*prixArticle} euros");





           /* int nbrVoulu, nbrGratuit, nbrPayant;
            int stock = 0;

            Console.WriteLine("Avez vous la carte ? O / N");
            bool carte = (Console.ReadLine() == "O") ? true : false;

            Console.WriteLine("Combien d'articles voulez vous ? ");
            nbrVoulu = int.Parse(Console.ReadLine());
            if(stock == 0) { 
                Console.WriteLine("va mourrir"); 
                return; 
            }
            if(nbrVoulu > stock)
            {
                Console.WriteLine($"Désolé notre stock est limité à {stock}");
                nbrVoulu = stock;
            }

            nbrGratuit = nbrVoulu / (carte ? 2 : 3);
            nbrPayant = nbrVoulu - nbrGratuit;

            Console.WriteLine($"Payant : {nbrPayant}");
            Console.WriteLine($"Gratuit : {nbrGratuit}");*/

            #endregion

        }
    }
}
