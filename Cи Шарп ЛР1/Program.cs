﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Cи_Шарп_ЛР1_2
{
    class Program
    {
        static void Main()
        {
         
            Console.WriteLine("Введите текст");
            string str = Console.ReadLine();
            char str1;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var m in str)
            {
                str1 = char.ToLower(m); 
                if (dict.ContainsKey(str1)) 
                    dict[str1]++;
                else
                    dict.Add(str1, 1);  
            }
            foreach (var item in dict)
            {
                
                Console.WriteLine("Символ " + item.Key + "\t" + " встречается " + item.Value + " раз"+ ((item.Value > 10 && item.Value < 20) || !"234".Contains(item.Value.ToString().Last()) ? "" : "а"));
            }
            Console.ReadLine();
        }
    }
}

