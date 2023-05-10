using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Arrays em C#";

            //Forma de fazer um array de uma dimensão

            int[] array1 = { 2, 20, 200, 2000 };
            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);
            Console.WriteLine(array1[3]);
            Console.WriteLine();

            //Outra forma de fazer um array de uma dimensão

            string[] array2 = new string[4];
            array2[0] = "Mewtwo";
            array2[1] = "Zekron";
            array2[2] = "Reshiram";
            array2[3] = "Keldeo";
            Console.WriteLine(array2[0]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array2[2]);
            Console.WriteLine(array2[3]);
            Console.WriteLine();

            //a última forma de fazer um array de uma dimensão 

            int[] array3 = new int[] { 2000, 2001, 2002, 2003, 2004, 2005 };
            Console.WriteLine(array3[0]);
            Console.WriteLine(array3[1]);
            Console.WriteLine(array3[2]);
            Console.WriteLine(array3[3]);
            Console.WriteLine(array3[4]);
            Console.WriteLine(array3[5]);
            Console.WriteLine();

            // Array de duas dimensões

            string[,] array4 = { {"Luffy", "Zoro", "Sanji"}, {"Law", "Kid", "Shanks" } };
            Console.WriteLine(array4[0, 0]);
            Console.WriteLine(array4[0, 1]);
            Console.WriteLine(array4[0, 2]);
            Console.WriteLine(array4[1, 0]);
            Console.WriteLine(array4[1, 1]);
            Console.WriteLine(array4[1, 2]);
            Console.WriteLine();

            //Forma alternativa de escrever um array de duas dimensões

            string[,] array5 = new string[2, 3];
            array5[0, 0] = "Gon";
            array5[0, 1] = "Killua";
            array5[0, 2] = "Kurapika";
            array5[1, 0] = "Leorio";
            array5[1, 1] = "Kaito";
            array5[1, 2] = "Meruem";
            Console.WriteLine(array5[0, 0]);
            Console.WriteLine(array5[0, 1]);
            Console.WriteLine(array5[0, 2]);
            Console.WriteLine(array5[1, 0]);
            Console.WriteLine(array5[1, 1]);
            Console.WriteLine(array5[1, 2]);
            Console.WriteLine();


            //última forma alternativa de fazer um array de duas dimensões

            int[,] array6 = new int[,] { { 7, 14 , 21, 28 }, { 12, 24, 36, 48 } };
            Console.WriteLine(array6[0, 0]);
            Console.WriteLine(array6[0, 1]);
            Console.WriteLine(array6[0, 2]);
            Console.WriteLine(array6[0, 3]);
            Console.WriteLine(array6[1, 0]);
            Console.WriteLine(array6[1, 1]);
            Console.WriteLine(array6[1, 2]);
            Console.WriteLine(array6[1, 3]);
            Console.WriteLine();

            //O número de elementos que um array possui
            int elementos = array6.GetLength(0);
            Console.WriteLine(elementos);
            int elementos1 = array6.GetLength(1);
            Console.WriteLine(elementos1);

            Console.ReadKey();
        }
    }
}
