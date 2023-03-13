int calculCarre(int val) 
{
    return val * val;  //retour du carré de la valeur rentrée
}

Console.WriteLine("Entrez un entier");  //demande de saisie clavier
string str = Console.ReadLine();        //saisie clavier
int val = Convert.ToInt32(str);         //convertion de la saisie
Console.WriteLine(calculCarre(val));    //appel de la fonction avec val de la saisie