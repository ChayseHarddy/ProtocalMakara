using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array= new int[5];
            int totalNeed =0;
            int tracker =0;
           
            int limit =0;
            int i = 0;
            int subTotal = 0;

            while (limit < 5)
            {
               
                array[i] = Convert.ToInt32(Console.ReadLine());
                
                subTotal = array[i] + subTotal;
                if (subTotal < 0)
                {
                    tracker = 0;
                    while (true)
                    {
                        tracker++;
                        if (subTotal == tracker*-1)
                        {
                            totalNeed = totalNeed +tracker;
                            subTotal = subTotal + tracker;
                            break;
                        }
                    }
                }
               
                limit++;
                i++;
            }




            Console.WriteLine("Your required energy needed is "+ totalNeed);
            

        }
    }
}
