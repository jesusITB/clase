/*
 * Author: jesus Gomez
 * M03. Programació UF1
 * v1. 13/11/2023
 * 1. Implementa un programa que demani a l’usuari quants valors vol introduir i el programa generi una llista, a partir de valors introduïts per teclat, retornant la suma de tots els elements d’aquesta.
 *
 */




using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num = 0, sum = 0;
        const string msg = "introduce una longitud para la lista";
        const string msgo = "introduce un numero";

        Console.WriteLine(msg);
        num = Convert.ToInt32(Console.ReadLine());


        int[] list = new int[num];

        for (int i = 0; i < list.Length; i++)
        {
            Console.WriteLine(msgo);
            list[i] = Convert.ToInt32(Console.ReadLine());
            sum += list[i];
        }

        for (int i = 0; i < list.Length; i++)
        {
            Console.WriteLine($"resultado: {list[i]}");
        }
        Console.WriteLine($"resultado de suma: {sum}");
    }
}