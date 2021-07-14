using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1678.Goal_parser_interpretation
{
    public class _1678_Goal_parser_interpretation
    {
        public string Interpret(string command)
        {
            var res = new char[command.Length];
            int index = 0;

            for (int i = 0; i < command.Length;)
            {
                if (command[i] == 'G')
                {
                    res[index++] = 'G';
                    i++;
                }
                else if (command[i] == '(' && command[i + 1] == ')')
                {
                    res[index++] = 'o';
                    i += 2;
                }
                else
                {
                    res[index++] = 'a';
                    res[index++] = 'l';
                    i += 4;
                }
            }

            return new string(res, 0, index);

            //command = command.Replace("(al)", "al");
            //command = command.Replace("()", "o");
        }
    }
}