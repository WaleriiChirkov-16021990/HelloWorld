/*
Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.(RU: Напишите функцию, которая принимает строку из одного или нескольких слов и возвращает ту же строку, но со всеми словами из пяти или более букв в обратном порядке (точно так же, как название этого Ката). Передаваемые строки будут состоять только из букв и пробелов. Пробелы будут включены только в том случае, если присутствует более одного слова.)

spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw"
spinWords( "This is a test") => returns "This is a test"
spinWords( "This is another test" )=> returns "This is rehtona test"
*/
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

System.Console.WriteLine(Kata.SpinWords("Hey fellow warriors"));
System.Console.WriteLine(Kata.SpinWords("This is a test"));
System.Console.WriteLine(Kata.SpinWords("This is another test"));
public class Kata
{
    public static string SpinWords(string sentence)
    {
        string reversedSentence = string.Empty;
        string[] words = sentence.Split(' ');
        Console.WriteLine($"\nreserved:");
        foreach (string St in words)
        {
            if (St.Length < 5)
            {
                reversedSentence += String.Join("", St, " ");
            }
            if (St.Length >= 5)
            {
                for (int i = 0; i < St.Length; i++)
                {
                    reversedSentence += String.Join("", St[St.Length - i - 1]);
                }
                reversedSentence += " ";
            }
        }
        System.Console.WriteLine();
        return reversedSentence;
    }
}