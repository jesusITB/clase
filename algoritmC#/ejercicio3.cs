/*
 * Author: jesus Gomez
 * M03. Programació UF1
 * v1. 13/11/2023
 * 3. Implementa un programa que, donada la següent llista, retorni l’element més gran i el més petit.
 *
 */


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {


        int[] list = new int[] {5,10,15,2,25,30,35,40};


        for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[i] > list[j])
                    {
                        int listaux = list[i];
                        list[i] = list[j];
                        list[j] = listaux;
                    }
                }
            }
        Console.WriteLine(list[0]);
        Console.WriteLine(list[list.Length-1]);
    }
}
