namespace VideoGames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a list and add five games
            List<VideoGame> games = new List<VideoGame>();
            games.Add(new VideoGame { Name = "Super Mario Bros.", Genre = "Platform", Rating = 4.5 });
            games.Add(new VideoGame { Name = "Mobile Legends: Bang Bang", Genre = "MOBA", Rating = 4.8 });
            games.Add(new VideoGame { Name = "Minecraft", Genre = "Sandbox", Rating = 4.7 });
            games.Add(new VideoGame { Name = "Halo: Combat Evolved", Genre = "Shooter", Rating = 2.6 });
            games.Add(new VideoGame { Name = "Stardew Valley", Genre = "Simulation", Rating = 3.9 });

            // LINQ query to create a new list with games rating 4 or higher
            var topRatedGames = (from VideoGame in games
                                 where VideoGame.Rating >= 4
                                 select VideoGame).ToList();

            // LINQ query to sort the topRatedGames list by name
            var sortedGames = (from VideoGame in topRatedGames
                               orderby VideoGame.Name
                               select VideoGame).ToList();

            // loop to display the games in sorted list
            foreach (var game in sortedGames)
            {
                Console.WriteLine(game.Name);
            }
        } //end Main method
    } //end Program class
} //end namespace