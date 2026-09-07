// See https://aka.ms/new-console-template for more information
Console.WriteLine("Podaj PESEL: ");
string pesel = Console.ReadLine() ?? string.Empty;
Console.WriteLine(Plec(pesel));
Console.WriteLine(CyfraKontrolna(pesel));
static char Plec(string pesel) {

    if (pesel[9] % 2 == 0)
    {
        return 'K';
    }
   
      return 'M';

   
   
};

static bool CyfraKontrolna(string pesel)
{
    int r;
    int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
    int s = 0;
    for (int i = 0; i < 10; i++)
    {
        s += (pesel[i] - '0') * weights[i];
    }
    int m = s % 10;
    if (m == 0)
    {
        r = 0;
    }
    else
    {
        r = 10 - m;

    }
    if(pesel[10] - '0' == r)
    {
        return true;
    }
    else
    {
        return false;
    }
}
;








