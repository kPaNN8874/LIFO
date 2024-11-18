using LIFO;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        Verem verem = new Verem(12);
        verem.Push(12.45);
        Halmaz halmaz = new(5);
        halmaz.Push("Piroska");
        halmaz.Push("Géza");
        halmaz.Push("István");
        halmaz.Push("Piroska");
        halmaz.Push("Péter");
        //halmaz.Push("Ádám");
        Console.WriteLine(halmaz.ToString());
        halmaz.Remove("István");
        Console.WriteLine(halmaz.ToString());
    }
}