using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGameCodeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int cols = 22;
            int rows = 21;

            // game loop
            while (true)
            {
                int myShipCount = int.Parse(Console.ReadLine()); // the number of remaining ships
                int entityCount = int.Parse(Console.ReadLine()); // the number of entities (e.g. ships, mines or cannonballs)
                for (int i = 0; i < entityCount; i++)
                {
                    string[] inputs = Console.ReadLine().Split(' ');
                    int entityId = int.Parse(inputs[0]);
                    string entityType = inputs[1];
                    int x = int.Parse(inputs[2]);
                    int y = int.Parse(inputs[3]);
                    int arg1 = int.Parse(inputs[4]);
                    int arg2 = int.Parse(inputs[5]);
                    int arg3 = int.Parse(inputs[6]);
                    int arg4 = int.Parse(inputs[7]);
                }
                for (int i = 0; i < myShipCount; i++)
                {
                    var random = new Random();
                    // Write an action using Console.WriteLine()
                    // To debug: Console.Error.WriteLine("Debug messages...");

                    Console.WriteLine("MOVE " + ((int)random.Next(0, cols + 1)).ToString() + " " + ((int)random.Next(0, rows + 1)).ToString() + ""); // Any valid action, such as "WAIT" or "MOVE x y"
                }
            }
        }
    }
}
