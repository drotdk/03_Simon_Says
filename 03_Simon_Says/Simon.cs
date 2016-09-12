﻿using System.Collections.Generic;

namespace _03_Simon_Says
{
    internal class Simon
    {
        

        public Simon()
        {
            

        }

        public string Echo(string word)
        {
            return word.ToLower();
        }

        public string Shout(string words)
        {
            return words.ToUpper();
        }

        public string Repeat(string word, int itt = 2)
        {
            string finalstring = "";
            for (int i = 0; i < itt; i++)
            {
                finalstring += word + " ";
            }
            return finalstring.Trim();
        }

        public string StartOfWord(string word, int amount)
        {
            string finalstring = "";

            for (int i = 0; i < amount; i++)
            {
                finalstring += word[i];
            }
            return finalstring;
        }

        public string FirstWord(string sentence)
        {
            string finalstring = "";
            bool running = true;
            int i = 0;

            while (running)
            {
                if (!char.IsWhiteSpace(sentence[i]))
                {
                    finalstring += sentence[i];
                }
                else
                {
                    running = false;
                }
                i++;
            }

            return finalstring; 
        }

        public string Titleize(string sentence)
        {
            List<string> whitelist = new List<string>();
            whitelist.Add("and");
            whitelist.Add("over");
            whitelist.Add("the");

            string[] templist = sentence.Split(); ;

            string finalstring = "";

            char[] arr = templist[0].ToCharArray();
            arr[0] = char.ToUpperInvariant(arr[0]);
            finalstring += new string(arr) + " ";

            for (int i = 1; i < templist.Length; i++)
            {
                if (whitelist.Contains(templist[i]))
                {
                    finalstring += templist[i] + " ";
                }
                else
                {
                    arr = templist[i].ToCharArray();
                    arr[0] = char.ToUpperInvariant(arr[0]);
                    finalstring += new string(arr) + " ";

                }
            }

            return finalstring.Trim();
        }



    }
}