using Koshenya.Core.States.Parameters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Koshenya.Forms.Controls.StateParametersUC
{
    internal partial class DragStateParametersUC : UserControl, IStateParametersUC
    {
        private readonly DragStateParameters _parameters;
        private List<string> _animations;

        public DragStateParametersUC()
        {
            InitializeComponent();

            _parameters = new DragStateParameters();
            _animations = new List<string>();
        }

        public List<string> Animations
        {
            get => _animations;
            set
            {
                _animations = value;
                animComboBox.Items.Clear();
                animComboBox.Items.AddRange(_animations.ToArray());
                animComboBox.SelectedIndex = 0;
                sleepAnimComboBox.Items.Clear();
                sleepAnimComboBox.Items.AddRange(_animations.ToArray());
                sleepAnimComboBox.SelectedIndex = 0;
            }
        }
        public StateParameters Parameters => _parameters;
        public List<string> Sounds { get; set; }

        private void AnimComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _parameters.DragAnimation = (string)animComboBox.SelectedItem;
        }

        private void SleepAnimComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _parameters.DragAnimationWhenSleeping = (string)sleepAnimComboBox.SelectedItem;
        }
    }
}
