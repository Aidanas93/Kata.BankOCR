using System;
using System.Collections.Generic;

namespace Kata.BankOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\Aidanas\Desktop\Kata BankOCR\Kata.BankOCR\BankOCR.txt");

            IList<string[,]> numbers = new List<string[,]>();

            for(int i = 0; i < 9; i++)
            {
                numbers.Add(new string[3, 3]
                {{" "," "," "},
                 {" "," "," "},
                 {" "," "," "} 
                });
                // j row
                for (int j = 0; j < 3; j++)
                {
                    // k column
                    int x = i * 3 + 3;
                    for (int k = i*3; k < x; k++)
                    {
                        string textRow;
                        string textChar;
                        textRow = text[j];


                        textChar = textRow.Substring(k, 1);
                        numbers[i][j, k - (i*3)] = textChar;
                    }
                }
            }





            string[,] numberOne = new string[3, 3]
            {{" "," "," "},
             {" "," ","|"},
             {" "," ","|"} };

            string[,] numberTwo = new string[3, 3]
            {{" ","_"," "},
             {" ","_","|"},
             {"|","_"," "} };

            numbers.Add(numberOne);
        }
    }
}
