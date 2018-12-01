using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ch19_P8_TimerApp
{
    class Program
    {
        static void PrintTime(object state)
        {
            Console.WriteLine(" Time is : {0} " , DateTime.Now.ToLongTimeString());
            Console.Write(state.ToString());
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" ******* Working with Timer Class ********* ");
            TimerCallback callback = new TimerCallback(PrintTime);

            //Timer t = new Timer(callback, "Some random info from ATT", 0, 1000);

            Timer _ = new Timer(callback, "Some random info from ATT", 0, 1000);

            Console.WriteLine(" Hit Enter to Terminate... ");
            Console.ReadLine();
        }
    }
}
