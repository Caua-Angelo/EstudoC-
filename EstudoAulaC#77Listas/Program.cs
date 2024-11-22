namespace EstudoAulaC_77Listas {
    using System.Collections.Generic;
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("list count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A' || x[0] == 'a');
            Console.WriteLine("First 'A': " + s1);
            string s2 = list.FindLast(x => x[0] == 'A' || x[0] == 'a');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A' || x[0] == 'a');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A' || x[0] == 'a');
            Console.WriteLine("First position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("=============");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }
            list.RemoveRange(2,2);
            Console.WriteLine("=============");
            foreach (string obj in list) {
                Console.WriteLine(obj);

            }
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("=============");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

        }
    }
}

