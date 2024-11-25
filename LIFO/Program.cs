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
        Matrixok elso = new Matrixok();
        elso.Fill(3);
        Console.WriteLine("M1----------------------");
        elso.Print();   
        Matrixok masodik = new Matrixok();
        masodik.Fill(5);
        Console.WriteLine("M2----------------------");
        masodik.Print();

        UMatrix matrix = new UMatrix();
        matrix.Fill(5);
        matrix[1, 3] = 10;
        matrix[1, 2] = 20;

        Console.WriteLine(matrix);
        matrix.RotateToLeft();
        Console.WriteLine(matrix);
        matrix.RotatetToRight();
        Console.WriteLine(matrix);
        
    }
}