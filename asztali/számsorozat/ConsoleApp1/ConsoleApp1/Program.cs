


List<int> szamok = new List<int> { };

StreamReader olvas = new StreamReader("sorozat.txt");
olvas.ReadLine();
while (!olvas.EndOfStream)
{
    string line = olvas.ReadLine();
    szamok.Add(Convert.ToInt32(line));
}
olvas.Close();
Console.WriteLine("2. feladat:");
Console.WriteLine(szamok.Count);
Console.WriteLine();
Console.WriteLine("3.feladat:");

int a = 0;
for (int i = 0; i < szamok.Count; i++)
{
    if(szamok[i] %2==1)
    {
        a++;
    }
}
Console.WriteLine(a);
Console.WriteLine();
Console.WriteLine("4.feladat:");
static void beker(List<int> szamok)
{
    Console.Write("neve:");
    string nev = Console.ReadLine();
    Console.Write("txt:");
    string txt = Console.ReadLine();
    Console.Write("kezdés:");
    int kezdes = Convert.ToInt32(Console.ReadLine());
    Console.Write("vege:");
    int veg = Convert.ToInt32(Console.ReadLine());
    while (veg < kezdes)
    {
        Console.Write("vege:");
        veg = Convert.ToInt32(Console.ReadLine());
    }
    StreamWriter ir = new StreamWriter(nev + "." + txt);

    for (int i = kezdes + 1; i <= veg; i++)
    {
        ir.WriteLine(szamok[i]);
    }


    ir.Close();
}
beker(szamok);
Console.WriteLine();
Console.WriteLine("5.feladat:");