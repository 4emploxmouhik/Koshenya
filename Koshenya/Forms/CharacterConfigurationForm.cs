using Koshenya.Core;
using Koshenya.Core.States.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Koshenya.Forms
{
    public partial class CharacterConfigurationForm : Form
    {
        private readonly List<string> _states;
        private StateParameters[] _statesParameters;

        public CharacterConfigurationForm()
        {
            InitializeComponent();

            _states = new List<string>()
            {
                "Idle",
                "Move"
            };
        }

        private void ManageStatesButton_Click(object sender, EventArgs e)
        {
            if (animationsListViewUC.Animations.Count == 0)
            {
                MessageBox.Show("Set the animations first.", "Something missed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_states.Count > 2)
            {
                if (soundsListViewUC.Sounds.Count == 0)
                {
                    MessageBox.Show("Set the sounds first.", "Something missed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string[] animations = animationsListViewUC.Animations.Select(x => x.Name).ToArray();
            string[] sounds = soundsListViewUC.Sounds.Select(x => x.Name).ToArray();

            using (var statesForm = new CharacterStatesConfigurationForm(animations, sounds, _states.ToArray()))
            {
                if (statesForm.ShowDialog() == DialogResult.OK)
                    _statesParameters = statesForm.StateParameters;
                else
                    _statesParameters = null;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_statesParameters == null || _statesParameters.Length == 0)
            {
                MessageBox.Show(
                    "Configure character parameters first.", 
                    "To fast, mate",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            var config = new CharacterConfiguration()
            {
                Name = characterNameTextBox.Text,
                Animations = animationsListViewUC.Animations.ToArray(),
                Sounds = soundsListViewUC.Sounds.ToArray(),
                States = _statesParameters
            };

            bool answer = DialogResult.Yes == MessageBox.Show(
                "Do you want copy original files and use them for character.", 
                "Question",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            try
            {
                CharacterConfiguration.Save(config, answer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox == idleStateCheckBox || checkBox == moveStateCheckBox)
            {
                checkBox.CheckState = CheckState.Indeterminate;
                return;
            }

            if (checkBox.Checked)
                _states.Add((string)checkBox.Tag);
            else
                _states.Remove((string)checkBox.Tag);
        }

    }
}
