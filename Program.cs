int calculCarre(int val)
{
    return val * val;
}

Console.WriteLine("Entrez un entier");
string str = Console.ReadLine();
int val = Convert.ToInt32(str);
Console.WriteLine(calculCarre(val));