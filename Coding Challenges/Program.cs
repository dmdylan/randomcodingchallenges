using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenges
{
    class Program
    {
        public static void Main(string[] args)
        {
            SubtractProductAndSum(15);
            Console.ReadLine();
        }

        void MultiplesOf3And5()
        {
            var sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

         static void FibonacciNumbers(){
           var x = 1;
           var y = 2;
           var temp = 0;
           var sum = 2;
           while (temp < 4000000){
               temp = x + y;
               x = y;
               y = temp;
               temp = x + y;
               if(temp%2 == 0)
               {
                   sum += temp;
               }
           }
           Console.WriteLine(sum);
        }

        public static int Fibonacci(int number)
        {
            if (number <= 1) return number;

            return Fibonacci(number - 2) + Fibonacci(number - 1);
        }
        public static void PrimeFactors(long n)
        {
            // Print the number of 2s that divide n 
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }

            // n must be odd at this point. So we can 
            // skip one element (Note i = i +2) 
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                // While i divides n, print i and divide n 
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }

            // This condition is to handle the case whien 
            // n is a prime number greater than 2 
            if (n > 2)
                Console.Write(n);
        }

        /*
        private static long PrimeFactor(long number)
        {
            List<long> factorList = new List<long>();
            while (number%2 == 0)
            {
                number /= 2;
            }

            for(int i = 3; i<=Math.Sqrt(number); i += 2)
            {
                while(number%i == 0)
                {
                    number /= i;
                    factorList.Add(number);
                }
            }

            if (number > 2)
                factorList.Add(number);

            factorList.Sort();

            foreach(var n in factorList) 
                Console.WriteLine(n);

            return factorList.Max();
        }
        */

        public static void Staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var spaces = new String(' ', n - i);
                var hashes = new String('#', i);
                Console.WriteLine(spaces + hashes);
            }
        }

        public static int SubtractProductAndSum(int n)
        {
            int product = 1;
            int sum = 0;
            char[] numbers = n.ToString().ToCharArray();
            

            foreach(char c in numbers)
            {
                sum += Int32.Parse(c.ToString());
                product *= Int32.Parse(c.ToString());
            }
                
            return product - sum;
        }
    }
}
