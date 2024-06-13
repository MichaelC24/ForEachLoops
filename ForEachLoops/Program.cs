namespace ForEachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nbrs =
            {
                754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
                187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
                460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
                690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
                435, 643, 809, 874, 906, 620, 328, 369, 426, 561
            };

            int highest = int.MinValue;
            int lowest = int.MaxValue;
            int sum = 0; //inits the integer to store each value in the array

            foreach (int nbr in nbrs)
            {

                if (nbr > highest)
                {
                    highest = nbr;
                }
               
                 if (lowest > nbr)
                {
                    lowest = nbr;
                }
                 sum = (sum + nbr); // takes the newest value and then adds it to the running sum.

            } 
                
                              
            Console.WriteLine($"The highest num is: {highest}. The lowest num is: {lowest} avg: {sum/nbrs.Length}");
        }
    }
}
