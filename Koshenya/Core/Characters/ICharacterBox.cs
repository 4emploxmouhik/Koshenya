using System.Drawing;

namespace Koshenya.Core
{
    internal interface ICharacterBox 
    {
        Image Frame { get; set; }
        Point Location { get; set; }
        Size Size { get; }

        void SetCharacter(Character character);
    }
}
