using static Koshenya.Core.Movement;

namespace Koshenya.Core.Extensions
{
    internal static class MovementExtensions
    {
        public static string GetShortNameOfDirection(this Directions direction)
        {
            switch (direction)
            {
                case Directions.East: return "e";
                case Directions.West: return "w";
                case Directions.North: return "n";
                case Directions.South: return "s";
                case Directions.NorthEast: return "ne";
                case Directions.NorthWest: return "nw";
                case Directions.SouthEast: return "se";
                case Directions.SouthWest: return "sw";
                default: return "none";
            }
        }

        public static Directions GetDirectionByShortName(this string name)
        {
            switch (name)
            {
                case "e": return Directions.East;
                case "w": return Directions.West;
                case "n": return Directions.North;
                case "s": return Directions.South;
                case "ne": return Directions.NorthEast;
                case "nw": return Directions.NorthWest;
                case "se": return Directions.SouthEast;
                case "sw": return Directions.SouthWest;
                default: return Directions.None;
            }
        }
    }
}
