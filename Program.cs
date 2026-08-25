int numero = 2;
int[] numeri = {1,2,3,4,5,6};
int somma=0;
double media=0;
int sommaDispari=0;
double mediaDispari=0;
int numPari=0;
int numDispari=0;

//CHECK NUMERO PARI O DIPARI
if(numero%2==0)
{
    Console.WriteLine("il numero è pari");
}
else
{
    Console.WriteLine("il numero è dispari");
}

//CALCOLO MEDIA NUMERI
for(int i=0; i<numeri.Length; i++)
{
    somma+=numeri[i];
}
media=(double)somma/numeri.Length;
Console.WriteLine($"media numeri: {media}");
somma=0;
media=0;
for(int i=0; i<numeri.Length; i++)
{
    if (numeri[i] % 2 == 0)
    {
        somma+=numeri[i];
        num_pari++;
    }
    else
    {
        sommaDispari+=numeri[i];
        numDispari++;
    }
}
media=(double)somma/num_pari;
mediaDispari=(double)sommaDispari/numDispari;
Console.WriteLine($"Media numeri pari: {media}");
Console.WriteLine($"Media numeri diapsri: {mediaDispari}");