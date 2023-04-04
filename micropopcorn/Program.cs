namespace micropopcorn
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Popcorn butterPop = new Popcorn
            {
                popId = 1,
                Name = "Smörpopcorn",
                PopPercentage = 0
            };
            Console.WriteLine(butterPop.Name);
            var butterPopTask = await Microwaving(butterPop);
            Console.WriteLine(butterPopTask);
        }

        public async static Task<Popcorn> Microwaving(Popcorn popcorn)
        {
            int tick = 30;
            while (true)
            {
                await Wait(tick);
                popcorn.PopPercentage += (0.55M * tick);

                if (popcorn.PopPercentage >= 99)
                {
                    Console.WriteLine("Pop done");
                    return popcorn;
                }
            }
            Console.WriteLine("Startade microwaving");
            await Wait();
            await Console.Out.WriteLineAsync("3 minuters micropop klar.");
            return popcorn;
        }
        private static async Task Wait(double delay = 1)
        {
            await Task.Delay(TimeSpan.FromSeconds(delay));
            Console.WriteLine("30 seconds wait completed.");
        }
    }

    public async static Task popcornStatus(Popcorn popcorn)
    {

    }
}