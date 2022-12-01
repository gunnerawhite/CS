using cycle.Game.Casting;
using cycle.Game.Directing;
using cycle.Game.Scripting;
using cycle.Game.Services;


namespace cycle
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            Point start1 = new Point(Constants.MAX_X / 2, Constants.MAX_Y / 2);
            Point start2 = new Point(Constants.MAX_X / 4, Constants.MAX_Y / 4);
            Color color1 = Constants.GREEN;
            Color color2 = Constants.BLUE;

            // create the cast
            Cast cast = new Cast();
            cast.AddActor("cycle1", new Snake(start1, color1));
            cast.AddActor("cycle2", new Snake(start2, color2));

            // create the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
            // create the script
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("update", new GrowTailAction());
            script.AddAction("output", new DrawActorsAction(videoService));
            

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}
