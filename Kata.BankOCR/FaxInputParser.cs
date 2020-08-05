using System;
using System.Collections.Generic;

namespace Kata.BankOCR
{
    public class FaxInputParser
    {
        public IList<List<char>> ParseInput()
        {
            string[] input = GetInputText();
            IList<List<char>> insertedFaxTemplates = new List<List<char>>();
            insertedFaxTemplates.Add(new List<char>());
            insertedFaxTemplates.Add(new List<char>());
            insertedFaxTemplates.Add(new List<char>());
            insertedFaxTemplates.Add(new List<char>());
            insertedFaxTemplates.Add(new List<char>());
            insertedFaxTemplates.Add(new List<char>());
            insertedFaxTemplates.Add(new List<char>());
            insertedFaxTemplates.Add(new List<char>());
            insertedFaxTemplates.Add(new List<char>());

            for (short i = 0; i < input.Count() - 1; i++)
            {
                for (short j = 0; j < 27; j++)
                {
                    int index = (int)Math.Floor((double)j / 3);
                    insertedFaxTemplates[index].Add(input[i][j]);
                }
            }

            return insertedFaxTemplates;
        }

        public IList<short> ConvertInputToNumbers()
        {
            var convertedNumbers = new List<short>();
            var inputList = ParseInput();
            foreach (var item in inputList)
            {
                var number;



                convertedNumbers.Add(number);
            }

        }

        private string[] GetInputText()
        {
            return System.IO.File.ReadAllLines(Configuration.FilePath);
        }
    }
}
