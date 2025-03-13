using System.Drawing;
using System.Windows.Forms;

namespace Koshenya.Core.Characters.Cat
{
    internal partial class CatBox : CharacterBox
    {
        public CatBox() : base()
        {
            MouseClick += CharacterBox_MouseClick;
            MouseDown += CharacterBox_MouseDown;
            MouseUp += CharacterBox_MouseUp;
            MouseMove += CharacterBox_MouseMove;
        }

        private void CharacterBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                (character as Cat).Punch();
        }

        private void CharacterBox_MouseMove(object sender, MouseEventArgs e)
        {
            if ((character as Cat).IsStillDragging())
            {
                Movement.GetCursorPos(out Point point);
                Location = point;
            }
        }

        private void CharacterBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                (character as Cat).Drag(false);
                Cursor = Cursors.Default;
            }
        }

        private void CharacterBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                (character as Cat).Drag(true);
                Cursor = Cursors.SizeAll;
            }
        }
    }
}
