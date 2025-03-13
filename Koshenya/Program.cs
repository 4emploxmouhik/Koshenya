using Koshenya.Core;
using Koshenya.Core.Characters.Cat;
using System;
using System.Windows.Forms;

namespace Koshenya
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Character character = new Cat("Grey");

            Application.Run(character.Box as Form);
        }
    }
}
