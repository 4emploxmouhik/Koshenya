using System.Collections.Generic;

namespace Koshenya.Core.Extensions
{
    internal static class ListExtensions
    {
        public static Animation Get(this List<Animation> list, string name)
        {
            return list.Find(x => x.Name == name);
        }

        public static Animation[] Get(this List<Animation> list, string[] names)
        {
            Animation[] result = new Animation[names.Length];

            for (int i = 0; i < names.Length; i++)
                result[i] = list.Get(names[i]);

            return result;
        }

        public static AnimationClip Get(this List<AnimationClip> list, string name)
        {
            return list.Find(x => x.Name == name);
        }
    }
}
