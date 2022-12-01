using System.Collections.Generic;
using cycle.Game.Casting;
using cycle.Game.Services;


namespace cycle.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class GrowTailAction : Action
    {
        private VideoService _videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public GrowTailAction()
        {
            
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            Snake cycle1 = (Snake)cast.GetFirstActor("cycle1");
            Snake cycle2 = (Snake)cast.GetFirstActor("cycle2");
            cycle1.GrowTail(1, Constants.GREEN);
            cycle2.GrowTail(1, Constants.BLUE);
        }
    }
}
