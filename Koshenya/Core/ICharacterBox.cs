using System.Drawing;
using System.Windows.Forms;

namespace Koshenya.Core
{
    internal interface IAnimationBox
    {
        Image Frame { get; set; }
    }

    internal interface IMovementBox
    {
        Point Location { get; set; }
        Size Size { get; }
    }

    internal interface ICharacterBox : IAnimationBox, IMovementBox
    {
        Cursor Cursor { get; set; }
    }
}
