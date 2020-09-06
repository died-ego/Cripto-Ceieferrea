using System;
using System.Collections.Generic;

namespace Cripto_Ceiferrea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string phrase = "";
            string encryptedPhrase = "";

            Intro();
            System.Console.Write("Spell the phrase to encrypt: ");
            phrase = Console.ReadLine().ToLower();

            List<String> phraseChars = new List<string>();
            char[] phraseArray = phrase.ToCharArray();
            for(int i=0; i < phraseArray.Length; i++)
            {
                switch(phraseArray[i])
                {
                    case 'a':
                    string charA = "que";
                    phraseChars.Add(charA);
                    break;

                    case 'b':
                    string charB = "jota";
                    phraseChars.Add(charB);
                    break;

                    case 'c':
                    string charC = "eme";
                    phraseChars.Add(charC);
                    break;

                    case 'd':
                    string charD = "i";
                    phraseChars.Add(charD);
                    break;

                    case 'e':
                    string charE = "u";
                    phraseChars.Add(charE);
                    break;

                    case 'f':
                    string charF = "ce";
                    phraseChars.Add(charF);
                    break;

                    case 'g':
                    string charG = "o";
                    phraseChars.Add(charG);
                    break;

                    case 'h':
                    string charH = "ca";
                    phraseChars.Add(charH);
                    break;

                    case 'i':
                    string charI = "erre";
                    phraseChars.Add(charI);
                    break;

                    case 'j':
                    string charJ = "ips";
                    phraseChars.Add(charJ);
                    break;

                    case 'k':
                    string charK = "be";
                    phraseChars.Add(charK);
                    break;

                    case 'l':
                    string charL = "ge";
                    phraseChars.Add(charL);
                    break;

                    case 'm':
                    string charM = "a";
                    phraseChars.Add(charM);
                    break;

                    case 'n':
                    string charN = "ene";
                    phraseChars.Add(charN);
                    break;

                    case 'o':
                    string charO = "efe";
                    phraseChars.Add(charO);
                    break;

                    case 'p':
                    string charP = "dbu";
                    phraseChars.Add(charP);
                    break;

                    case 'q':
                    string charQ = "ele";
                    phraseChars.Add(charQ);
                    break;

                    case 'r':
                    string charR = "aga";
                    phraseChars.Add(charR);
                    break;

                    case 's':
                    string charS = "ze";
                    phraseChars.Add(charS);
                    break;

                    case 't':
                    string charT = "esse";
                    phraseChars.Add(charT);
                    break;

                    case 'u':
                    string charU = "de";
                    phraseChars.Add(charU);
                    break;

                    case 'v':
                    string charV = "pe";
                    phraseChars.Add(charV);
                    break;

                    case 'w':
                    string charW = "te";
                    phraseChars.Add(charW);
                    break;

                    case 'x':
                    string charX = "xis";
                    phraseChars.Add(charX);
                    break;

                    case 'y':
                    string charY = "e";
                    phraseChars.Add(charY);
                    break;

                    case 'z':
                    string charZ = "ve";
                    phraseChars.Add(charZ);
                    break;
                }
            }

            foreach(string phraseChar in phraseChars)
            {
                encryptedPhrase += phraseChar;
            }
            System.Console.Write($"This is your encrypted password: {encryptedPhrase}");
        }

        private static void Intro()
        {
            System.Console.WriteLine("======================================");
            System.Console.WriteLine("          Critpo Ceieferrea           ");
            System.Console.WriteLine("======================================");
            System.Console.WriteLine();
        }
    }
}
