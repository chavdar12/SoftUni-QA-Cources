﻿namespace TestApp;

public class TextFilter
{
    public static string Filter(string[] bannedWords, string text)
    {
        foreach (var word in bannedWords)
            if (text.Contains(word))
                text = text.Replace(word, new string('*', word.Length));

        return text;
    }
}