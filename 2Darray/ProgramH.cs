using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    internal class ProgramH
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(101, "HR");
            hashtable.Add(102, "Sales");
            hashtable.Add(103,"Admin");
            hashtable.Add(104, "Development");

            hashtable.Remove(104);

            foreach(DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}
