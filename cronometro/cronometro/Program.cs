using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;



namespace cronometro
{
    class Program
    {


        static void Main(string[] args)
        {

            Int16 horaCron, minCron, segCron;
            
            Console.WriteLine("menu   1)Relog  2)Cronometro");
            string s = Console.ReadLine();
            int opc = int.Parse(s); 

           switch(opc){
           
               case 1:
                   
                   Console.Clear();
                   Console.WriteLine(DateTime.Now);
                   Thread.Sleep(1000);
                  break;
           
               case 2:
                   
                   Console.Clear();

for (horaCron = 0; horaCron < 1000; horaCron++)  { 
    for (minCron = 0; minCron < 60; minCron++)  { 
        for (segCron = 0; segCron < 60; segCron++)  { 
            Console.WriteLine(horaCron.ToString("00") + "." + minCron.ToString("00") + "." + segCron.ToString("00")); System.Threading.Thread.Sleep(1000); 
    Console.Clear(); } } }

break;


           
           
           }
           Console.ReadKey();
            }
         
    


}
    }
    



