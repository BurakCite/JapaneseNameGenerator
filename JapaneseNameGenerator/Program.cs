using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseNameGenerator
{
    class Program
    {
        private static string[] Alphabet = { "a", "ka", "sa", "ta", "na", "ha", "ma", "ya", "ra", "wa", "ga", "za", "da", "ba", "pa", "kya", "nya", "bya", "mya", "ja", "sha", "gya", "hya", "pya", "rya", "cha", "n", "i", "ki", "shi", "chi", "ni", "hi", "mi", "ri", "gi", "ji", "bi", "pi", "u", "ku", "su", "tsu", "nu", "fu", "mu", "yu", "ru", "gu", "zu", "bu", "pu", "kyu", "nyu", "byu", "myu", "ju", "shu", "gyu", "hyu", "pyu", "ryu", "chu", "e", "ke", "se", "te", "ne", "he", "me", "re", "ge", "ze", "de", "be", "pe", "che", "je", "she", "o", "ko", "so", "to", "no", "ho", "mo", "yo", "ro", "wo", "go", "zo", "do", "bo", "po", "cho", "kyo", "nyo", "byo", "myo", "gyo", "hyo", "pyo", "ryo", "sho" };
        private static int NameCount = 20;
        private static int MinNameLength = 2;
        private static int MaxNameLength = 5;
        static void Main(string[] args)
        {
            Random random = new Random();
            int letterIndex = -1;
            for (int i = 0; i < NameCount; i++)
            {
                string name = String.Empty;
                int nameLength = random.Next(MinNameLength, MaxNameLength + 1);
                for (int j = 0; j < nameLength; j++)
                {
                    letterIndex = random.Next(0, Alphabet.Length);
                    name += Alphabet[letterIndex];
                }
                name = name[0].ToString().ToUpper() + name.Substring(1);
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
