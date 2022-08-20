using System.Collections.Generic;
using System.Linq;
using System;


public class Kata
{
    public static string SpinWords(string sentence)
    {
        public static void Main(string[] args)
        {

        }
        string reversedSentence = string.Empty;
        string wer = string.Empty;
        string[] words = sentence.Split(' ');
        foreach (string St in words)
        {
            if (St.Length < 5)
            {
                wer = St;
                return wer;
            }
            if (St.Length >= 5)
            {
                reversedSentence += " ";
                for (int i = 0; i < St.Length; i++)
                {
                    wer += St[St.Length - i - 1];
                }
                return wer;
            }
            reversedSentence = String.Join(" ", wer);
        }
        System.Console.WriteLine();
        return reversedSentence;
    }
}
