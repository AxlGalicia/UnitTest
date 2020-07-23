using System;

namespace helloworld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int test(int valor){
            if(valor>0){
                return 1;
            }else{
                return 0;
            }

        }
    }
}
