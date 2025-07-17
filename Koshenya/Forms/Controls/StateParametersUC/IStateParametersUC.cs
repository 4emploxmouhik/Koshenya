using Koshenya.Core.States.Parameters;
using System.Collections.Generic;

namespace Koshenya.Forms.Controls.StateParametersUC
{
    internal interface IStateParametersUC
    {
        StateParameters Parameters { get; }
        List<string> Animations { get; set; }
        List<string> Sounds { get; set; }
    }
}
