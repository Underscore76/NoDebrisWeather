using System;
using StardewModdingAPI;
using StardewValley;

namespace NoDebrisWeather
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.UpdateTicked += GameLoop_UpdateTicked;
        }

        private void GameLoop_UpdateTicked(object sender, StardewModdingAPI.Events.UpdateTickedEventArgs e)
        {
            if (!Context.IsWorldReady)
                return;

            if (Game1.debrisWeather != null)
            {
                Game1.debrisWeather.Clear();
            }
        }
    }
}

