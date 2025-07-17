using System.Drawing;
using System.Windows.Forms;

namespace Koshenya.Core
{
    internal interface IBox
    {
        Image Frame { get; set; }
    }

    internal interface IMovementBox
    {
        Point Location { get; set; }
        Size Size { get; }
    }

    internal interface ICharacterBox : IBox, IMovementBox
    {
        Cursor Cursor { get; set; }
    }
}
