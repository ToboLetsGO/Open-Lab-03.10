using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int number_of_chars = 0;
            foreach (var item in str)
            {
                if (item == letter)
                {
                    number_of_chars++;
                }
            }
            return number_of_chars;
        }
    }
}
