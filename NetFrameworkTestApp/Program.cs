using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkTestApp
{
    using System.Runtime.Remoting.Contexts;
    using System.Threading;

    class Program
    {
        public delegate int BinaryOp(int x, int y);

        static void Main(string[] args)
        {
            BinaryOp delBinaryOp = new BinaryOp(Add);

            Console.WriteLine("answer: {0}", delBinaryOp.Invoke(5, 4));

            Console.ReadKey();
        }

        static int Add(int x, int y)
        {
            Thread.Sleep(5000);
            return x + y;
        }
    }
}
