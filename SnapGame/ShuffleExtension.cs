using System;
using System.Collections.Generic;

namespace SnapGame
{
    public static class ShuffleExtension
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            Random random = new Random();
            for (var i = 0; i < list.Count; i++)
            {
                var temp = list[i];
                var index = random.Next(0, list.Count);
                list[i] = list[index];
                list[index] = temp;
            }
        }
    }
}
