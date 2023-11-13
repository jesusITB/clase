/*
 * Author: jesus Gomez
 * M03. Programació UF1
 * v1. 13/11/2023
 * 2. implementa un programa que retorni una llista sense els elements duplicats.
 *
 */



using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] list = new int[] {10, 20, 30, 20, 10, 50, 60, 40, 80, 50, 40};

        for (int i = 0; i < list.Length - 1; i++)
        {
            for (int j = i + 1; j < list.Length; j++)
            {
                if (list[i] == list[j])
                {
                    list[i] = 0;
                }
                if (list[i] > list[j])
                {
                    int listaux = list[i];
                    list[i] = list[j];
                    list[j] = listaux;
                }
            }
        }
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] != 0)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
