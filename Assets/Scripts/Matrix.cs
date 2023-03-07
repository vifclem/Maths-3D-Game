
using System;
using System.Numerics;
using UnityEngine;

public class Matrix
{
   
         
    
        public static void Main(string[] args)
        {
            int i, j, m, n;
            Console.WriteLine("Enter the Number of Rows and Columns : ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            Console.WriteLine("Enter the First Matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("First matrix is:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }

   
     

