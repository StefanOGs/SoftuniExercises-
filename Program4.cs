using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _07._List_Manipulation_Advanced
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var companyUsers = new Dictionary<string, List<string>>();
            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                string[] input = comand.Split(" -> ");
                string companyName = input[0];
                string emplyID = input[1];
                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers[companyName] = new List<string>();
                }
                companyUsers[companyName].Add(emplyID);
            }
            foreach (var item in companyUsers)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var other in item.Value)
                {
                    Console.WriteLine($"-- {other}");
                }
            }


        }
    }
}



