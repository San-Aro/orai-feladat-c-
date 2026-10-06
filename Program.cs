using System.Runtime.Serialization.Formatters;
using System.Security.Principal;
/*
-----------------222222222222222222222--------
Console.Write("Adja meg a csokoládá sorszámát: ");
int id = int.Parse(Console.ReadLine());

int oszto = 0;

if (id <= 1)
{
    Console.WriteLine("Sajnos nem nyert!");
}
else
{
    for (int i = 1; i <= id; i++)
    {
        if (id % i == 0)
        {
            oszto++;
        }
    }
}

if  (oszto == 2)
{
    Console.WriteLine("Gratulálunk nyertél!");
}
else if (oszto > 2)
{
    Console.WriteLine("Sajnos nem nyert!");
}



-----------------333333333333------------

for  (int i = 1; i < 11; i++)
{
    for (int j = 1; j < 11; j++)
    {
        Console.Write($"{i * j} ");
        
    }
    Console.WriteLine(" ");
}
*/

Console.Write("Adja meg az alsó intervallumot: ");
int numMin = int.Parse(Console.ReadLine());

Console.Write("Adja meg a felső intervallumot: ");
int numMax = int.Parse(Console.ReadLine());

int sumNUM = 0;

for (int i = numMin; i <= numMax; i++)
{
    if (i % 2 == 0)
    {
        sumNUM += i;
    }
}

Console.WriteLine(sumNUM);