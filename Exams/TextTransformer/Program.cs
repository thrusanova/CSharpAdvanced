using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class TextTransformer
{
    public static void Main()
    {
        var CapturePattern = @"([$%&'])([^$%&']+)\1";


        StringBuilder sb = new StringBuilder();

        string input = Console.ReadLine();

        while (input != "burp")

        {
            sb.Append(input);
            input = Console.ReadLine();
        }

        string text = Regex.Replace(sb.ToString(), @"\s+", " ");
        Regex stringMatcher = new Regex(CapturePattern);
        var matches = stringMatcher.Matches(text);

        StringBuilder result = new StringBuilder();

        foreach (Match match in matches)
        {
            char specialSymbol = match.Groups[1].Value[0];
            string capturedString = match.Groups[2].Value;
            int stringLength = capturedString.Length;
            if (specialSymbol == '$')
            {
                for (int i = 0; i < stringLength; i++)
                {
                    char currentSymbol = capturedString[i];
                    char resultingChar;

                    if (i % 2 == 0)
                    {
                        resultingChar = (char)(currentSymbol + 1);

                    }
                    else
                    {
                        resultingChar = (char)(currentSymbol - 1);
                    }

                    result.Append(resultingChar);
                }
            }
                if (specialSymbol == '%')
                {
                    for (int i = 0; i < stringLength; i++)
                    {
                        char currentSymbol = capturedString[i];
                        char resultingChar;

                        if (i % 2 == 0)
                        {
                            resultingChar = (char)(currentSymbol + 2);

                        }
                        else
                        {
                            resultingChar = (char)(currentSymbol - 2);
                        }

                        result.Append(resultingChar);
                    }
                    result.Append(" ");
                }
                if (specialSymbol == '&')
                {
                    for (int i = 0; i < stringLength; i++)
                    {
                        char currentSymbol = capturedString[i];
                        char resultingChar;

                        if (i % 2 == 0)
                        {
                            resultingChar = (char)(currentSymbol + 3);

                        }
                        else
                        {
                            resultingChar = (char)(currentSymbol - 3);
                        }

                        result.Append(resultingChar);
                    }
                }

                if (specialSymbol == '\'')
                {
                    for (int i = 0; i < stringLength; i++)
                    {
                        char currentSymbol = capturedString[i];
                        char resultingChar;

                        if (i % 2 == 0)
                        {
                            resultingChar = (char)(currentSymbol + 4);

                        }
                        else
                        {
                            resultingChar = (char)(currentSymbol - 4);
                        }

                        result.Append(resultingChar);
                    }

                   
                }
                Console.WriteLine(result);
            }
        }
    }
