/*ETAPE 2 : 
Demander les bornes. Générez aléatoirement le
nombre à trouver. Attribuez une notre au joueur :
 */
Random aleatoire = new Random();
int valATrouver = aleatoire.Next(1,10);
int nbTours = 5;
int nbr;
float note;
int[] tab = new int[nbTours];
Console.WriteLine("Vous avez " + nbTours + " à jouer");
for (int essai = 1; essai <= nbTours; essai++)
{
    Console.WriteLine("Essai " + essai);
    string chaineInt = Console.ReadLine();
    if (int.TryParse(chaineInt, out nbr))
    {
        tab[essai] = nbr;
        note =(float) nbTours /(float) essai;
        Console.WriteLine("les valeurs déja choisis :" + tab[essai]);
        if (nbr < 1 && nbr > 10)
        {
            Console.WriteLine("Entrez un nombre compris entre 1 et 10");
        }
        else if (nbr < valATrouver)
        {
            Console.WriteLine("Entrez un nombre plus grand");
        }
        else if (nbr > valATrouver)
        {
            Console.WriteLine("Entrez un nombre plus petit");
        }
        else if (nbr == valATrouver)
        {
            Console.WriteLine("Génial, Vous avez gagné");
            Console.WriteLine("Votre note est de : "+note+"/5");
            break;
        }
    }
    else
    {
        Console.WriteLine("Veuillez entrez un bon nombre");
    }
}