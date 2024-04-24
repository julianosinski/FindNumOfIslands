namespace IslandExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] map =
            {
                {0,0,1,1,0},
                {0,1,1,0,0},
                {0,0,1,0,1},
                {1,0,0,0,1},
                {1,0,0,1,1}
            };
            IslandFinder islandFinder = new IslandFinder(map);
            Console.WriteLine("Num of Island found: {0}", islandFinder.NumOfIslandDFS());
        }
    }
}
