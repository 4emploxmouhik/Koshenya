using Koshenya.Core.States.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Koshenya.Forms.Controls.StateParametersUC
{
    internal partial class SleepStateParametersUC : UserControl, IStateParametersUC
    {
        private readonly SleepStateParameters _parameters;

        private List<string> _animations;
        private List<string> _sounds;

        public SleepStateParametersUC()
        {
            InitializeComponent();

            _parameters = new SleepStateParameters();
            _animations = new List<string>();
            _sounds = new List<string>();
        }

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
                animsComboBox3.Items.Clear();
                animsComboBox3.Items.AddRange(_animations.ToArray());
                animsComboBox3.SelectedIndex = 0;
            }
        }
        public List<string> Sounds
        {
            get => _sounds;
            set
            {
                _sounds = value;
                soundsComboBox.Items.Clear();
                soundsComboBox.Items.AddRange(_sounds.ToArray());
                soundsComboBox.SelectedIndex = 0;
            }
        }
        public StateParameters Parameters => _parameters;

        private void AddFallAsleepAnimButton_Click(object sender, EventArgs e)
        {
            fallAsleepAnimsListBox.Items.Add(animsComboBox1.SelectedItem);
            _parameters.FallAsleepAnimations.Clear();
            _parameters.FallAsleepAnimations.AddRange(fallAsleepAnimsListBox.Items.Cast<string>());
        }

        private void RemoveFallAsleepAnimButton_Click(object sender, EventArgs e)
        {
            fallAsleepAnimsListBox.Items.RemoveAt(fallAsleepAnimsListBox.Items.Count - 1);
            _parameters.FallAsleepAnimations.RemoveAt(_parameters.FallAsleepAnimations.Count - 1);
        }

        private void AddAwakenAnimButton_Click(object sender, EventArgs e)
        {
            awakenAnimsListBox.Items.Add(animsComboBox3.SelectedItem);
            _parameters.AwakenAnimations.Clear();
            _parameters.AwakenAnimations.AddRange(awakenAnimsListBox.Items.Cast<string>());
        }

        private void RemoveAwakenAnimButton_Click(object sender, EventArgs e)
        {
            awakenAnimsListBox.Items.RemoveAt(awakenAnimsListBox.Items.Count - 1);
            _parameters.AwakenAnimations.RemoveAt(_parameters.AwakenAnimations.Count - 1);
        }

        private void AnimsComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _parameters.SleepAnimation = (string)animsComboBox2.SelectedItem;
        }

        private void SoundsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _parameters.SleepSound = (string)soundsComboBox.SelectedItem;
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int time = (int)numericUpDown.Value;

            switch (comboBox5.SelectedIndex)
            {
                case 1: time *= 1000; break;
                case 2: time *= 60000; break;
            }

            _parameters.SleepingTime = time;
        }
    }
}
