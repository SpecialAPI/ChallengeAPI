using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dungeonator;

namespace ChallengeAPI
{
    /// <summary>
    /// A basic example challenge.
    /// </summary>
    public class ExampleChallengeModifier : ChallengeModifier
    {
        public void Start()
        {
            //If you want something to happen when the challenge starts, this is the place.
            ETGModConsole.Log("Example Challenge Started!");
        }

        public void Update()
        {
            //If you want something to happen every frame while it's active, this is the place.
        }

        public void OnDestroy()
        {
            //If you want something to happen when the challenge ends, this is the place.
            ETGModConsole.Log("Example Challenge Ended!");
        }

        public override bool IsValid(RoomHandler room)
        {
            //This method checks if the room is valid for this challenge. If you return true it means it's valid, if you return false it means it's not valid.
            return true;
        }
    }
}
