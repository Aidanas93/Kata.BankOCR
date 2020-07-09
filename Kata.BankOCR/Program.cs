using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.BankOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\Aidanas\Desktop\Kata BankOCR\Kata.BankOCR\BankOCR.txt");

            IList<string[,]> fileNumbers = new List<string[,]>();

            for(int i = 0; i < 9; i++)
            {
                fileNumbers.Add(new string[3, 3]
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
                        fileNumbers[i][j, k - (i*3)] = textChar;
                    }
                }
            }

            string[,] numberZero = new string[3, 3]
            {{" ","_"," "},
             {"|"," ","|"},
             {"|","_","|"} };

            string[,] numberOne = new string[3, 3]
            {{" "," "," "},
             {" "," ","|"},
             {" "," ","|"} };

            string[,] numberTwo = new string[3, 3]
            {{" ","_"," "},
             {" ","_","|"},
             {"|","_"," "} };

            string[,] numberThree = new string[3, 3]
            {{" ","_"," "},
             {" ","_","|"},
             {"","_","|"} };

            string[,] numberFour = new string[3, 3]
            {{" "," "," "},
             {"|","_","|"},
             {"","","|"} };

            string[,] numberFive = new string[3, 3]
            {{" ","_"," "},
             {"|","_",""},
             {"","_","|"} };

            string[,] numberSix = new string[3, 3]
            {{" ","_"," "},
             {"|","_",""},
             {"|","_","|"} };

            string[,] numberSeven = new string[3, 3]
            {{" ","_"," "},
             {" "," ","|"},
             {""," ","|"} };

            string[,] numberEight = new string[3, 3]
            {{" ","_"," "},
             {"|","_","|"},
             {"|","_","|"} };

            string[,] numberNine = new string[3, 3]
            {{" ","_"," "},
             {"|","_","|"},
             {" ","_","|"} };

            IDictionary<string[,], int> blueprintValues = new Dictionary<string[,], int>();
            blueprintValues.Add(numberZero, 0);
            blueprintValues.Add(numberOne, 1);
            blueprintValues.Add(numberTwo, 2);
            blueprintValues.Add(numberThree, 3);
            blueprintValues.Add(numberFour, 4);
            blueprintValues.Add(numberFive, 5);
            blueprintValues.Add(numberSix, 6);
            blueprintValues.Add(numberSeven, 7);
            blueprintValues.Add(numberEight, 8);
            blueprintValues.Add(numberNine, 9);



            IList<string[,]> blueprintList = new List<string[,]>();

            blueprintList.Add(numberZero);
            blueprintList.Add(numberOne);
            blueprintList.Add(numberTwo);
            blueprintList.Add(numberThree);
            blueprintList.Add(numberFour);
            blueprintList.Add(numberFive);
            blueprintList.Add(numberSix);
            blueprintList.Add(numberSeven);
            blueprintList.Add(numberEight);
            blueprintList.Add(numberNine);

            IList<int> numbers = new List<int>();
            //for (int i = 0; i < fileNumbers.Count; i++)
            //{
            //    for (int j = 0; j < blueprintList.Count; j++)
            //    {

            //        Console.WriteLine(fileNumbers[i].Cast<string>().SequenceEqual(blueprintList[j].Cast<string>()));

            //        var equal =
            //        fileNumbers[i].Rank == blueprintList[j].Rank &&
            //        Enumerable.Range(0, fileNumbers[i].Rank).All(dimension => fileNumbers[i].GetLength(dimension) == blueprintList[j].GetLength(dimension)) &&
            //        fileNumbers[i].Cast<string>().SequenceEqual(blueprintList[j].Cast<string>());
            //        if (fileNumbers[i].Cast<string>().SequenceEqual(blueprintList[j].Cast<string>()))
            //        {
            //            numbers.Add(j);
            //            break;
            //        }

            //    }

            //}

            int ii = 2;
            int jj = 3;

            if(fileNumbers[ii][0,0] == blueprintList[jj][0,0])
            {
                if (fileNumbers[ii][0, 1] == blueprintList[jj][0, 1])
                {
                    if (fileNumbers[ii][0, 2] == blueprintList[jj][0, 2])
                    {
                        if (fileNumbers[ii][1, 0] == blueprintList[jj][1, 0])
                        {
                            if (fileNumbers[ii][1, 1] == blueprintList[jj][1, 1])
                            {
                                if (fileNumbers[ii][1, 2] == blueprintList[jj][1, 2])
                                {
                                    if (fileNumbers[ii][2, 0] == blueprintList[jj][2, 0])
                                    {
                                        if (fileNumbers[ii][2, 1] == blueprintList[jj][2, 1])
                                        {
                                            if (fileNumbers[ii][2, 2] == blueprintList[jj][2, 2])
                                            {
                                                Console.WriteLine("Yaaaaaaa!!");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            //for (int i = 0; i < fileNumbers.Count; i++)
            //{
            //    for(int j =0; j < 3; j++)
            //    {
            //        bool breaking = false;
            //        for (int k = 0; k < 3; k++)
            //        {
            //            string file = fileNumbers[i][j, k];
            //            string print = blueprintList[i][j, k];
            //            if (file == print)
            //            {
            //                if(j == 2 && k == 2)
            //                {
            //                    numbers.Add(i);
            //                }
            //                continue;
            //            }
            //            else
            //            {
            //                breaking = true;
            //                break;
            //            }

                //        }

                //        if(breaking)
                //        {
                //            break;
                //        }
                //    }
                //}




                Console.ReadLine();
        }
    }
}
