
int numery = 266998666;
string ilosciliczb = numery.ToString();
char[] liczby = ilosciliczb.ToArray();

int licznik0 = 0;
int licznik1 = 0;
int licznik2 = 0;
int licznik3 = 0;
int licznik4 = 0;
int licznik5 = 0;
int licznik6 = 0;
int licznik7 = 0;
int licznik8 = 0;
int licznik9 = 0;

foreach(char m in liczby) 
{
    if (m == '0') 
    {
        licznik0++;
    }
    else if (m == '1') 
    {
        licznik1++;
    }
    if (m == '2') 
    {
        licznik2++;
    }
    else if (m == '3') 
    {
        licznik3++;
    }
    if (m == '4') 
    {
        licznik4++;
    }
    else if (m == '5') 
    {
        licznik5++;     
    }
    if (m == '6') 
    {
        licznik6++;
    }
    else if (m == '7') 
    {
        licznik7++;    
    }
    if (m == '8') 
    {
        licznik8++;
    }
    else if (m == '9') 
    {
        licznik9++;
    }
}
Console.WriteLine("wynik dla liczby" + numery);
Console.WriteLine("0===>" + licznik0);
Console.WriteLine("1===>" + licznik1);
Console.WriteLine("2===>" + licznik2);
Console.WriteLine("3===>" + licznik3);
Console.WriteLine("4===>" + licznik4);
Console.WriteLine("5===>" + licznik5);
Console.WriteLine("6===>" + licznik6);
Console.WriteLine("7===>" + licznik7);
Console.WriteLine("8===>" + licznik8);
Console.WriteLine("9===>" + licznik9);