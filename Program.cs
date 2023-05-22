internal class Program
{
    private static void Main(string[] args)
    {
        Bird bird;
        while (true)
        {
            Console.Write("\nWciśnij G - golab , S - strus : ");
            char key = char.ToUpper(Console.ReadKey().KeyChar);
            switch (key)
            {
                case 'G':
                    bird = new Pigeon();
                    break;
                case 'S':
                    bird = new Ostrich();
                    break;
                default:
                    return;
            }
            Console.Write("\nIle jaj składa ptak? ");
            if (!int.TryParse(Console.ReadLine(), out int numberOfEgs)) return;
            Egg[] eggs = new bird.LayEggs(numberOfEgs);
            foreach egg in eggs)
            {
                Console.Write(eggs.Description);
            }

        }
    }
}