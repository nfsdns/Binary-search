using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace compiler

{
    public static class Scanner
    {
        public static void scanner()
        {
            string readText = File.ReadAllText(@"c:\desktop file\compiler test.txt");
            //var charactersOfFile = Regex.Replace(readText, @"\s+", string.Empty).ToCharArray();
            //foreach (var character in charactersOfFile)
            //{

            //    Console.WriteLine(character);
            //}
            foreach (var item in readText)
            {
                string[] input;
                for (int i = 0; i < readText.Length; i++)
                {
                     input = item.ToString();
                    SearchMathematicalMethodInFile(input);
                }
            
            }
            


        }

        public static void SearchMathematicalMethodInFile(string[] mathematicalMethod)
        {

          
            
            foreach (var item in mathematicalMethod)
            {
                var lines = File.ReadAllLines(@"C:\Users\lenovo\Desktop\symbol table.txt");

                var firstFound = false;
                for (int index = 0; index < lines.Length; index++)
                {
                    if (lines[index].Contains(item))
                    {
                        firstFound = true;
                        Console.WriteLine(firstFound.ToString());
                    }
                    if (lines[index].Contains(item))
                    {
                        for (int i = 0; i < lines.Length; i++)
                        {
                            Console.WriteLine(lines[i].ToString());
                        }
                      
                    }
                }
                //var mathematicalMethodList = new List<string>();
                //mathematicalMethodList.Add(item);

                //for (int i = 0; i < mathematicalMethodList.Count; i++)
                //{


                //    Console.WriteLine(mathematicalMethodList[i]);
                //}
                // read file line by line 
                
            }
        }
    }
}