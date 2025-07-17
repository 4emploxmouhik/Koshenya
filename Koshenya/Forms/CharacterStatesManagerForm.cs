using Koshenya.Forms.Controls.StateParametersUC;
using Koshenya.Core.States.Parameters;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Koshenya.Forms
{
    public partial class CharacterStatesConfigurationForm : Form
    {
        private readonly string[] _animations;
        private readonly string[] _sounds;
        private StateParameters[] _parameters;

        public CharacterStatesConfigurationForm(string[] animations, string[] sounds, string[] states)
        {
            _animations = animations;
            _sounds = sounds;

            InitializeComponent();
            InitialCharacterStatesConfiguration(states);
        }

        public StateParameters[] StateParameters => _parameters;

        private void InitialCharacterStatesConfiguration(string[] states)
        {
            statesTabControl.TabPages.Clear();
            _parameters = new StateParameters[states.Length];

            for (int i = 0; i < states.Length; i++)
            {
                switch (states[i])
                {
                    case "Idle":
                        AddPage<IdleStateParametersUC>("Idle", i);
                        break;
                    case "Move":
                        AddPage<MovementStateParametersUC>("Move", i);
                        break;
                    case "Punch":
                        AddPage<PunchStateParametersUC>("Punch", i);
                        break;
                    case "Sleep":
                        AddPage<SleepStateParametersUC>("Sleep", i);
                        break;
                    case "Drag":
                        AddPage<DragStateParametersUC>("Drag", i);
                        break;
                }
            }
        }

        private void AddPage<T>(string state, int i) where T : IStateParametersUC
        {
            T stateUC = (T)Activator.CreateInstance(typeof(T));
            stateUC.Animations = _animations.ToList();
            stateUC.Sounds = _sounds.ToList();

            _parameters[i] = stateUC.Parameters;

            UserControl control = stateUC as UserControl;

            statesTabControl.TabPages.Add(state, state);
            statesTabControl.TabPages[state].Controls.Add(control);

            if (statesTabControl.TabPages[state].Height < control.Height)
                statesTabControl.TabPages[state].Height = control.Height;

            control.Location = new Point()
            {
                X = (statesTabControl.Width - control.Width) / 2,
                Y = 0
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
