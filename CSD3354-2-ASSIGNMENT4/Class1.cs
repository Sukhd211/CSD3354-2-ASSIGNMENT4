﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CSD3354_2_ASSIGNMENT4
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program a = new Program();
            a.Beowulf = new ArrayList();
            a.ReadTextFiles();
        }

        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {

            using (StreamReader sr = new StreamReader("U:/Users/727454/beowulf.txt"))
            {
                string line;
                int counter = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Beowulf.Add(line);
                    counter++;
                }

                Console.WriteLine("Lines:" + counter);
                Console.ReadLine();
            }

        }
    }
}