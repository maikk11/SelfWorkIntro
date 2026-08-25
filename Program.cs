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

//STAMPA VALORI IN POSIZIONE PARI IN UN ARRAY
for(int i; i<numeri.Length; i += 2)
{
    Console.WriteLine($"{numeri[i]}");
}

//STAMPARE ELEMENTO MAGGIORE IN UN ARRAY
int massimo = numeri[0];
for (int i = 1; i < numeri.Length; i++)
{
    if (numeri[i] > massimo)
    {
        massimo = numeri[i];
    }
}
Console.WriteLine($"Il valore massimo è {massimo}");

//CREAZIONE ARRAY DA UTENTE + SOMMATORIA
Console.WriteLine("Inserire lunghezza array: ");
int lungArray=int.Parse(Console.ReadLine());
int [] array = new int [lungArray];
somma=0;
for(int i=0; i < lungArray; i++)
{
    Console.WriteLine($"Inserisci elemento in posizione: {i}");
    array[i]=int.Parse(Console.ReadLine());
    somma+=array[i];
}
Console.WriteLine($"La somma dell'array è: {somma}");

//CHECK STRINGA PALINDROMA
string parola = "anna";
string rovesciata = "";

for (int i = parola.Length - 1; i >= 0; i--)
{
    rovesciata += parola[i];
}

Console.WriteLine(parola == rovesciata ? "È palindroma" : "Non è palindroma");