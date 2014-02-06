using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadspringLib;

namespace headspringExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //        Console.WriteLine("fizzbuzz");
            //    else if (i % 3 == 0)
            //        Console.WriteLine("fizz");
            //    else if (i % 5 == 0)
            //        Console.WriteLine("buzz");
            //    else
            //        Console.WriteLine(i);
            //}
            HeadspringLib.DivNumber DivNum = new DivNumber();
            
            //foreach (string message in DivNum.IsDivisable(1, 100))
            //{
            //    Console.WriteLine(message);
            //}
            
            DivNum.ViewMessages += new DivNumber.SendMessagesHandler(PrintMessages);
            DivNum.RunIsDivisable(1, 10000234);

            Console.ReadLine();
        }

        public static void PrintMessages(MessagesArgs listMsg)
        {
            foreach (string messg in listMsg.messagesToShow)
            {
                Console.WriteLine(messg);
            }
        }
    }
}
