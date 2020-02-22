using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace jelly_the_jumping_cube_1._1
{
    class FileDemo
    {
       
        string FilePath = @"text.txt";

        public static void ReadFromFile(string FilePath){

            StreamReader reader = new StreamReader(FilePath);
            reader.ReadLine(); reader.Close();
    }

        public static void WriteToFile(string anything)
        {
            StreamWriter writer = new StreamWriter(@"text.txt");
            writer.WriteLine(anything);
        }



    }
}
