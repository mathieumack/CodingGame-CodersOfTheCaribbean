using System;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            int barrelX = 0;
            int barrelY = 0;

            int myShipCount = int.Parse(Console.ReadLine()); // the number of remaining ships
            int entityCount = int.Parse(Console.ReadLine()); // the number of entities (e.g. ships, mines or cannonballs)
            for (int i = 0; i < entityCount; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int entityId = int.Parse(inputs[0]);
                string entityType = inputs[1];


                int x = int.Parse(inputs[2]);
                int y = int.Parse(inputs[3]);

                // get one barrel 
                if (entityType == "BARREL")
                {
                    barrelX = x;
                    barrelY = y;
                }

                int arg1 = int.Parse(inputs[4]);
                int arg2 = int.Parse(inputs[5]);
                int arg3 = int.Parse(inputs[6]);
                int arg4 = int.Parse(inputs[7]);
            }
            for (int i = 0; i < myShipCount; i++)
            {

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");

                Console.WriteLine("MOVE " + barrelX.ToString() + " " + barrelY.ToString()); // Any valid action, such as "WAIT" or "MOVE x y"
            }
        }
    }
}