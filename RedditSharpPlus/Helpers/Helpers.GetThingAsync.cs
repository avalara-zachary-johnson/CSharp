﻿using System.Threading.Tasks;

namespace RedditSharpPlus
{
    partial class Helpers
    {
        protected static async internal Task<T> GetThingAsync<T>(IWebAgent agent, string url) where T : Things.Thing
        {
            var json = await agent.Get(url).ConfigureAwait(false);
            return Things.Thing.Parse<T>(agent, json);
        }
    }
}
