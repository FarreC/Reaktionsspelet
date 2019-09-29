using System;
using System.Diagnostics;
using System.Threading;

namespace ReaktionSpel
{
    class Program
    {
        static void Main(string[] args)
        {     

            Random rand = new Random();
            var testRandom = rand.Next(3000, 10000); 
            var timer = new Stopwatch();
            var endTimer = new Stopwatch();
            
            timer.Start();
            
                Console.WriteLine("Get ready...");

                while(!Console.KeyAvailable)
                {
                    
                    if(timer.ElapsedMilliseconds == testRandom)
                    {
                        Console.WriteLine("NOW!");
                        endTimer.Start();
                         
                    }
                }
                endTimer.Stop();
                timer.Stop();
                
                if(timer.ElapsedMilliseconds > testRandom)
                {  
                    Console.WriteLine("Din tid är {0} ms", endTimer.ElapsedMilliseconds);

                }
                else
                {
                    Console.WriteLine("fusk");
                }
                

               
                
                    
                
               



            
            
        }
    }
}
