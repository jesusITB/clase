/*
 * Author: jesus Gomez
 * M03. Programació UF1
 * v1. 13/11/2023
 * 5. Implementa un programa que generi una matriu de 4x4 i mostri la diagonal principal (pots inicialitzar-la amb els valors enters que consideris).
 *
 */

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int numUser, sum = 0, numM;

        int[][] list = new int[4][];

        list[0] = new int[] { 1, 2, 3, 4 };
        list[1] = new int[] { 5, 6, 7, 8 };
        list[2] = new int[] { 9, 10, 11, 12 };
        list[3] = new int[] { 13, 14, 15, 16 };

        for (int i = 0; i < list.Length; i++)
        {
            Console.WriteLine($" resultado : {list[i][i]}");
        }
    }
}