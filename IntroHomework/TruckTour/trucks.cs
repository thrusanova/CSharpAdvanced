namespace TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class PetrolPump
    {
        public long fuel;
        public long distance;
        public long pumpNumber;
        public PetrolPump(long fuel,long distance,long pumpNumber)
        {
            this.fuel = fuel;
            this.distance = distance;
            this.pumpNumber = pumpNumber;
        }
    }

  class Trucks
    {
     public static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
           // long fuel = 0;
            var queue = new Queue<PetrolPump>();
            for (int i = 0; i < numbers; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                long liters = long.Parse(input[0]);
                long distance = long.Parse(input[1]);
                var pump = new PetrolPump(liters, distance, i);
                queue.Enqueue(pump);
            }
              
                bool isSolution = false;
                while (true)
                {
                var startPump = queue.Dequeue();
                queue.Enqueue(startPump);
                var fuel = startPump.fuel;
                fuel -= startPump.distance;
                long num = startPump.pumpNumber;
                while (fuel>=0)
                { 
                    var currPump = queue.Dequeue();
                    if (currPump == startPump)
                    {
                        isSolution = true;
                        //num++;
                        break;
                    }
                    queue.Enqueue(currPump);
                    fuel += currPump.fuel;
                    fuel -= currPump.distance;
                    num = currPump.pumpNumber + 1;

                }
                if (isSolution)
                {
                    Console.WriteLine(startPump.pumpNumber);
                    break;
                }
            }

            }
        }
    }

