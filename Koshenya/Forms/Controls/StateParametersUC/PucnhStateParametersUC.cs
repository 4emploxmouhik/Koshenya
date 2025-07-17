using Koshenya.Core.States.Parameters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Koshenya.Forms.Controls.StateParametersUC
{
    internal partial class PunchStateParametersUC : UserControl, IStateParametersUC
    {
        private readonly PunchStateParameters _parameters;

        private List<string> _animations;
        private List<string> _sounds;

        public PunchStateParametersUC()
        {
            InitializeComponent();

            _parameters = new PunchStateParameters();
            _animations = new List<string>();
            _sounds = new List<string>();
        }

        public StateParameters Parameters => _parameters;

        public List<string> Animations
        {
            get => _animations;
            set
            {
                _animations = value;
                animsComboBox1.Items.Clear();
                animsComboBox1.Items.AddRange(_animations.ToArray());
                animsComboBox1.SelectedIndex = 0;
                animsComboBox2.Items.Clear();
                animsComboBox2.Items.AddRange(_animations.ToArray());
                animsComboBox2.SelectedIndex = 0;
            }
        }
        public List<string> Sounds
        {
            get => _sounds;
            set
            {
                _sounds = value;
                soundsComboBox1.Items.Clear();
                soundsComboBox1.Items.AddRange(_sounds.ToArray());
                soundsComboBox1.SelectedIndex = 0;
                soundsComboBox2.Items.Clear();
                soundsComboBox2.Items.AddRange(_sounds.ToArray());
                soundsComboBox2.SelectedIndex = 0;
            }
        }

        private void AnimsComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _parameters.DefaultReactionAnimation = (string)animsComboBox1.SelectedItem;
        }

        private void SoundsComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _parameters.DefaultReactionSound = (string)soundsComboBox1.SelectedItem;
        }

        private void AnimsComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _parameters.AggressiveReactionAnimation = (string)animsComboBox2.SelectedItem;
        }

        private void SoundsComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _parameters.AggressiveReactionSound = (string)soundsComboBox2.SelectedItem;
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _parameters.PunchesToAggressive = (int)numericUpDown.Value;
        }
    }
}
