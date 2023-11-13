/*
 * Author: jesus Gomez
 * M03. Programació UF1
 * v1. 13/11/2023
 * 4. Implementa un programa que generi un array, indicant la seva mida per teclat. L’usuari haurà d’indicar un número per teclat, de manera que els valors de cada posició seran nombres múltiples consecutius del valor introduït per teclat. Per exemple, si es defineix un array de grandària 5 i s’indica un 3 com a valor, l’array contindrà els valors 3, 6, 9, 12, 15.
 *
 */


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int numUser, sum = 0,numM;
        const string msg = "introduce una longitud para la lista";
        const string msgo = "introduce un numero";
        const string msgoM = "introduce un numero para el multiplo";

        Console.WriteLine(msg);
        numUser = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(msgoM);
        numM = Convert.ToInt32(Console.ReadLine());

        int[] list = new int[numUser];

        for (int i = 0; i < list.Length; i++)
        {
            do
            {
                Console.WriteLine(msgo);
                sum = Convert.ToInt32(Console.ReadLine());
            }while(!(sum%numM == 0))

            list[i] = sum
        }

    }
}