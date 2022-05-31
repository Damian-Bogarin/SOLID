using System;

namespace SustitucionDeLiskov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            T t = new S1();
            Console.WriteLine(t.GetName());

            t = new S2();
            Console.WriteLine(t.GetName());
        }

        public abstract class T
        {
            public abstract string GetName();
           
        }

        public class S1 : T
        {
            public override string GetName()
            {
                return "S1";
            }
        }

        public class S2 : T
        {
            public override string GetName()
            {
                return "S2";
            }
           
        }
    }
}
