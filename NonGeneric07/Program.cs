using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGeneric07 // push to github
{
    class NonGenericDictionaryExample
    {
        public static void Main()
        {
            Hashtable students = new Hashtable();
            students.Add(1, "John");
            students.Add(2, "Emma");
            students.Add(3, 25); // mixed types allowed

            foreach (DictionaryEntry entry in students)
            {
                Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
            }
        }
    }
}
