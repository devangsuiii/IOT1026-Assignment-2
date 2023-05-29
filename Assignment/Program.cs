namespace Assignment
{
    /// <summary>
    /// Represents the main program class.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The entry point of the program.
        /// </summary>
        static void Main()
        {
            System.Console.WriteLine("Hello World");
            TreasureChest chest = new TreasureChest(TreasureChest.Material.Oak, TreasureChest.LockType.Intermediate, TreasureChest.LootQuality.Green);
            Console.WriteLine(chest);
        }
    }
}
