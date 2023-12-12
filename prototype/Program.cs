using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            const bool DEEPCOPY = true;


            List<Multimedia> myMultimedia = new();
            myMultimedia.Add(new Picture("pic 1", new MultimediaObj("p1")));
            myMultimedia.Add(new Music("music 1", new MultimediaObj("mu1")));
            myMultimedia.Add(new Movie("mov 1", new MultimediaObj("mo1")));


            List<Multimedia> myMultimediaCopy = new();
            myMultimediaCopy.AddRange(DEEPCOPY
                ? myMultimedia.Select(i => (Multimedia)(i.Clone()))
                : myMultimedia.Select(i => (Multimedia)(i.ShallowClone())));


            Console.WriteLine("myMultimedia");
            foreach (var item in myMultimedia)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("------------------");
            Console.WriteLine("myMultimediaCopy");
            foreach (var item in myMultimediaCopy)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}