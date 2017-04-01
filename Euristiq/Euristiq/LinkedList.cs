using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euristiq
{
    class LinkedList
    {
        class Language
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            List<Language> language = new List<Language>(4);
            language.Add(new Language() { Name = "C#" });
            language.Add(new Language() { Name = "Java" });
            language.Add(new Language() { Name = "JavaScript" });
            language.Add(new Language() { Name = "C++" });
            foreach(Language l in language)
            {
                Console.WriteLine(l.Name);
            }
            Console.WriteLine();
            language.Reverse();
            foreach(Language i in language)
            {
                Console.WriteLine(i.Name);
            }
            Console.ReadKey();
        }
    }
}
