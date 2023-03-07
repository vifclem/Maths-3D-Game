
using System;
using System.Numerics;
using UnityEngine;

public class Matrix
{
   
         
    
        public static void Main(string[] args)
        {
            int i, j, m, n;
            Console.WriteLine("Combien de lignes et de colonnes veut-tu ? : ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            Console.WriteLine("Entre les chiffres de la matrice");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("La premiere Matrice est :");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    public void MultiplieVector()
    {
        int k, f;
        Console.WriteLine("Quel sont les coordoner du vecteur en (X,Y,Z) :");
        k = Convert.ToInt32(Console.ReadLine());
        f = Convert.ToInt32(Console.ReadLine());
        int[,] Vector = new int[k, f];


    }

    }




