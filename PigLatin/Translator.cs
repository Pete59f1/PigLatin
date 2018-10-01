using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    public class Translator
    {
        public string Translate(string v)
        {
            string[] split = v.Split(' ');
            bool charIsUpper = false;
            for (int i = 0; i < split.Length; i++)
            {
                if (char.IsUpper(split[i][0]))
                {
                    charIsUpper = true;
                }

                if (("aeio").Contains(split[i][0]))
                {
                    split[i] = split[i] + "ay";
                }

                else if (("aeio").Contains(split[i][1]))
                {
                    char first = split[i][0];
                    string rest = "";
                    if (split[i].Length > 1)
                    {
                        rest = split[i].Substring(1);
                    }
                    split[i] = rest + first + "ay";
                }

                else if (("aeio").Contains(split[i][2]))
                {
                    string firstTwo = split[i].Substring(0, 2);
                    string rest = "";
                    if (split[i].Length > 1)
                    {
                        rest = split[i].Substring(2);
                    }
                    split[i] = rest + firstTwo + "ay";
                }

                else
                {
                    string firstThree = split[i].Substring(0, 3);
                    string rest = "";
                    if (split[i].Length > 1)
                    {
                        rest = split[i].Substring(3);
                    }
                    split[i] = rest + firstThree + "ay";
                }
                
                if (charIsUpper == true)
                {
                    split[i] = split[i].ToLower();
                    char first = char.ToUpper(split[i][0]);
                    string rest = "";
                    if (split[i].Length > 1)
                    {
                        rest = split[i].Substring(1);
                    }
                    split[i] = first + rest;
                    charIsUpper = false;
                }
            }
            return string.Join(" ", split);
        }
        public string TranslateDanish(string v)
        {
            string[] split = v.Split(' ');
            bool charIsUpper = false;
            for (int i = 0; i < split.Length; i++)
            {
                if (char.IsUpper(split[i][0]))
                {
                    charIsUpper = true;
                }

                if (("aeiouyæøå").Contains(split[i][0]))
                {
                    split[i] = split[i] + "ay";
                }

                else if (("aeiouyæøå").Contains(split[i][1]))
                {
                    char first = split[i][0];
                    string rest = "";
                    if (split[i].Length > 1)
                    {
                        rest = split[i].Substring(1);
                    }
                    split[i] = rest + first + "ay";
                }

                else if (("aeiouyæøå").Contains(split[i][2]))
                {
                    string firstTwo = split[i].Substring(0, 2);
                    string rest = "";
                    if (split[i].Length > 1)
                    {
                       rest = split[i].Substring(2);
                    }
                    split[i] = rest + firstTwo + "ay";
                }

                else
                {
                    string firstThree = split[i].Substring(0, 3);
                    string rest = "";
                    if (split[i].Length > 1)
                    {
                        rest = split[i].Substring(3);
                    }
                    split[i] = rest + firstThree + "ay";
                }

                if (charIsUpper == true)
                {
                    split[i] = split[i].ToLower();
                    char first = char.ToUpper(split[i][0]);
                    string rest = "";
                    if (split[i].Length > 1)
                    {
                        rest = split[i].Substring(1);
                    }
                    split[i] = first + rest;
                    charIsUpper = false;
                }
            }
            return string.Join(" ", split);
        }
    }
}
