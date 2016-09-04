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

            string line;
            string filename = args[0];

            List<Grade> gradelist = new List<Grade>();
            StreamReader file = new StreamReader(filename);

            while ((line = file.ReadLine()) != null)
            {
                //check string format: basic check only - no exact specification 
                if (line.Count(f => f == ',') != 2)
                    continue;

                int j = 0;
                string[] parts = line.Split(',');
                
                //check that the number is valid
                int.TryParse(parts[2], out j);

                gradelist.Add(new Grade { Surname = parts[0], Firstname = parts[1], Score = j } );
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

