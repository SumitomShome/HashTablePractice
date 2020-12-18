using System;
using System.Collections;
namespace HashTablePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Sumitom");
            ht.Add("2", "Aniket");
            ht.Add("3", "Rahul");
            ht.Add("4", "Anjishnu");
            ht.Add("5", "Deeptayan");
            if(ht.Contains("Sudip"))
            {
                Console.WriteLine("This name already exists");
            }
            else
            {
                ht.Add("6", "Sudip");
            }
            ICollection key = ht.Keys;
            foreach(string k in key)
            {
                Console.WriteLine(k + " : " + ht[k]);
            }
            Console.ReadKey();
        }
    }
}
