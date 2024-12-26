using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI_CD
{
    class Program
    {
        static void Main(string[] args)
        {
            Program main = new Program();
            main.PrintWard("hi");
            main.PrintWard("every",false);
            main.PrintWard(" one");
        }

        private void PrintWard(string ward, bool isWriteLine = true)
        {
            if (isWriteLine)
            {
                Console.WriteLine(ward);

            }
            else
            {
                Console.Write(ward);
            }
        }
            
        private void test()
        {

        }
        private void test2()
        {

        }
    }



   
}
