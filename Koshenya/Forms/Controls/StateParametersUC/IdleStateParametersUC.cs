using Koshenya.Core.States.Parameters;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Koshenya.Forms.Controls.StateParametersUC
{
    internal partial class IdleStateParametersUC : UserControl, IStateParametersUC
    {
        private readonly IdleStateParameters _parameters;
        private List<string> _animations;

        public IdleStateParametersUC()
        {
            InitializeComponent();

            _parameters = new IdleStateParameters();
            _animations = new List<string>();
        }

        public List<string> Animations
        {
            get => _animations;
            set
            {
                _animations = value;
                defaultAnimComboBox.Items.Clear();
                defaultAnimComboBox.Items.AddRange(_animations.ToArray());
                defaultAnimComboBox.SelectedIndex = 0;
                animsComboBox.Items.Clear();
                animsComboBox.Items.AddRange(_animations.ToArray());
                animsComboBox.SelectedIndex = 0;
            }
        }
        public StateParameters Parameters => _parameters;
        public List<string> Sounds { get; set; }

        private void AddAnimButton_Click(object sender, System.EventArgs e)
        {
            string animation = (string)animsComboBox.SelectedItem;
            long time = (long)timeNumUpDown.Value;
            long timeScale;
            string timeUnit;

            switch (timeUnitComboBox.SelectedIndex) 
            {
                case 1:
                    timeScale = 1000;
                    timeUnit = "sec";
                    break;
                case 2:
                    timeScale = 60000;
                    timeUnit = "min";
                    break;
                default:
                    timeScale = 1;
                    timeUnit = "ms";
                    break;
            }
            
            time *= timeScale;
            animsListBox.Items.Add($"Animation: {animation} starts at {time / timeScale} {timeUnit}");
            _parameters.Animations.Add(animation);
            _parameters.AnimationsTimes.Add(time);
        }

        private void RemoveAnimButton_Click(object sender, System.EventArgs e)
        {
            animsListBox.Items.RemoveAt(animsListBox.Items.Count - 1);
            _parameters.Animations.RemoveAt(_parameters.Animations.Count - 1);
            _parameters.AnimationsTimes.RemoveAt(_parameters.AnimationsTimes.Count - 1);
        }

        private void TimeBeforeSleepNumUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            _parameters.TimeBeforeSleep = (int)timeBeforeSleepNumUpDown.Value * 60000;
        }

        private void DefaultAnimComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _parameters.DefaultAnimation = (string)defaultAnimComboBox.SelectedItem;
        }
    }
}
