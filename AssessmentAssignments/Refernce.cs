using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentAssignments
{
    class Refernce
    {
        public static void VowelsConsonent()
        {
            int Vowels = 0;
            int Consonent = 0;

            Console.WriteLine("Enter a Sentence: ");
            string sentence = Console.ReadLine();

            for (int i = 1; i < sentence.Length; i++)

                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                {
                    Vowels++;
                }

                else
                {
                    Consonent++;
                }

            Console.WriteLine($"The Total number of Vowels is: {Vowels}");
            Console.WriteLine($"The Total number of Vowels is: {Consonent}");

        }
    }
}
