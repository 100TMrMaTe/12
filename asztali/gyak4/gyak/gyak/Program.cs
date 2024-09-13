static int szamBekeres(int minimum = 3, int maximum = 15)
{
    if (minimum > maximum)
    {
        throw new ArgumentException("A minimum nem lehet nagyobb mint a maximum ");
    }
    int szam = 0;
    while (szam == 0)
    {
        try
        {
            Console.Write("Kérek egy egész számot {0} és {1} között: ", minimum, maximum);
            szam = Convert.ToInt32(Console.ReadLine());
            if (szam < minimum || szam > maximum)
            {
                throw new Exception();
            }
        }
        catch
        {
            szam = 0;

        }
    }




    return szam;
}

static string szoGeneralas(int hossz)
{
    string[] betuk = { "euioöüóőúűáéaí", "qwrtzpsdfghjklyxcvbnm" };
    Random random = new Random();
    int melyikJon = random.Next(2);
    string vissza = "";
    for (int i = 0; i < hossz; i++)
    {
        vissza += betuk[melyikJon][random.Next(betuk[melyikJon].Length)];
    }

    return vissza;
}
static void Main(string[] args)
{
    szamBekeres(5, 10);
}