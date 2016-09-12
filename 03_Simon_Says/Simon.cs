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

            List<string> templist = new List<string>();

            string finalstring = "", tempstring = "";
            bool running = true;
            int i = 0;

            while (running)
            {
                if (i + 1 == sentence.Length) running = false;

                if (!char.IsWhiteSpace(sentence[i]))
                {
                    tempstring += sentence[i];

                }
                else 
                {
                    templist.Add(tempstring);
                    tempstring = "";
                }
                i++;
            }

            foreach (var v in templist)
            {
                foreach (var s in whitelist)
                {
                    if (v != s)
                    {
                        char.ToUpper(v[0]);
                    }
                }
            }

            foreach (var v in templist)
            {
                finalstring += v + " ";
            }

            return finalstring;
        }



    }
}