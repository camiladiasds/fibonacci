using System.Collections.Generic;
using System.Runtime.ExceptionServices;

Console.WriteLine("Digite quantos elementos a fibonacci vai ter");
var qtNumber = Convert.ToInt32(Console.ReadLine());

var listNumbers = new List<int>();

if (qtNumber == 1) listNumbers.Add(0);
else if (qtNumber >= 2)
{
    listNumbers.Add(0);
    listNumbers.Add(1);
}

if (qtNumber >= 2)
{
    for (int i = 1; i < qtNumber -1; i++)
    {
        var item = listNumbers[i] + listNumbers[i - 1];
        listNumbers.Add(item);
    }
}

Console.WriteLine("Resultado:");
listNumbers.ForEach(p => Console.WriteLine(p));