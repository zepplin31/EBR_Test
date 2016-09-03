using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace EBR_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("incorrect arguements passed in");
                return;
            }

            //test for string format

            string line;
            string filename = args[0];
            List<Grade> gradelist = new List<Grade>();
            StreamReader file = new StreamReader(filename);
            
            while ((line = file.ReadLine()) != null)
            {
                //check string format:
                string[] parts = line.Split(',');
                gradelist.Add(new Grade { Surname = parts[0], Firstname = parts[1], Score = Convert.ToInt32(parts[2]) } );
                gradelist.Sort();              
            }

            file.Close();

            //create output file
            string outputName = filename.Insert(filename.IndexOf("."), "-graded");

            using (StreamWriter writer = new StreamWriter(outputName))
            {
                foreach (Grade g in gradelist)
                {
                    string s = g.Surname + "," + g.Firstname + ", " + g.Score;
                    writer.WriteLine(s);
                }
            }
        }
    }
}

