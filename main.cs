using System;



namespace ctu
{
    static class Unit1
    {
        static int Main(string[] args)
        {
            int n;

            if ( !int.TryParse(args[0], out n)) return 1;

            //Fill array
            int[] a = FillArray(n);
            //Get size of array
            int size = a.Length;
            // Limit for looping
            int limit = size / 2;
            //Get Max Element Index
            int max = size - 1;
        
            //Array N size + 1 for swap
            int space = n + 1;
            int steps = (n/2)*3;

            Console.WriteLine(string.Format("Forward: [{0}] ", string.Join(",",a)));

            for (int i = 0; i < limit; i++)
            {
                //Copy integer to stack
                int stack = a[max - i];
                //copy Element[i] to Element[max-i]
                a[max - i] = a[i];
                //Copy stack to Element[i]
                a[i] = stack;
                //Repeat and Rince
            }

            
            Console.WriteLine(string.Format("Reverse: [{0}] ", string.Join(",",a)));

            Console.WriteLine(string.Format("O(n) n={0} steps={1}, O(1) Space={2}", n,steps,space));

            return 0;
        }

        public static int[] FillArray(int size)
        {
            //Fill array with Something
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = i + 1;
            }
            return a;

        }
    }
}











