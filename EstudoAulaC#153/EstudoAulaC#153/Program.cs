﻿namespace EstudoAulaC_153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            SortedSet<int> c = new SortedSet<int>(a);
            c.Union(b);

            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            
           
        }



    }
}
