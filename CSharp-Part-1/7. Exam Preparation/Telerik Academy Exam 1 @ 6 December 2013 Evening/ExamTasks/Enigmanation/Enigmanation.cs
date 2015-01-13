﻿using System;

class Enigmanation
{
    static void Main()
    {
        string inputStr = Console.ReadLine();

        bool isBracketOpen = true;
        int finalResult = 0;
        int i = 0;
        int totalOpCount = 0;
        while (inputStr[i] != '=')
        {
            if (inputStr[i] != '(' && inputStr[i] != ')' && !Char.IsDigit(inputStr[i]))
            {
                totalOpCount++;
            }
            i++;
        }
        i = 0;
        Console.WriteLine(totalOpCount);
        int currentOpCount = 0;
        while (inputStr[i] != '=' && currentOpCount < totalOpCount)
        {

            if (inputStr[i] == '(')
            {
                isBracketOpen = true;
            }
            else if (inputStr[i] == ')')
            {
                isBracketOpen = false;
            }
            if (isBracketOpen)
            {
                if (!Char.IsDigit(inputStr[i]))
                {
                    switch (inputStr[i])
                    {
                        case '+':
                            finalResult = (inputStr[i - 1] - '0') + (inputStr[i + 1] - '0');
                            break;
                        case '-':
                            finalResult = (inputStr[i - 1] - '0') - (inputStr[i + 1] - '0');
                            break;
                        case '%':
                            finalResult = (inputStr[i - 1] - '0') % (inputStr[i + 1] - '0');
                            break;
                        case '*':
                            finalResult = (inputStr[i - 1] - '0') * (inputStr[i + 1] - '0');
                            break;
                    }
                }
            }
            i++;
            currentOpCount++;
        }
        Console.WriteLine(finalResult);
    }
}
