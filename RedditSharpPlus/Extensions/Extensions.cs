﻿#pragma warning disable 1591
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace RedditSharpPlus.Extensions
{
    public static class Extensions
    {
        public static T ValueOrDefault<T>(this IEnumerable<JToken> enumerable)
        {
            if (enumerable == null)
                return default(T);
            return enumerable.Value<T>();
        }
    }
}
#pragma warning restore 1591