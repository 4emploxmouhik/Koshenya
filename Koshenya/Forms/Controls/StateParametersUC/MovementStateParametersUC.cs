using Koshenya.Core.States.Parameters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Koshenya.Forms.Controls.StateParametersUC
{
    internal partial class MovementStateParametersUC : UserControl, IStateParametersUC
    {
        private readonly MovementStateParameters _parameters;
        private readonly ComboBox[,] comboBoxes;

        private List<string> _animations;

        public MovementStateParametersUC()
        {
            InitializeComponent();

            comboBoxes = new ComboBox[,]
            {
                { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8 },
                { comboBox9, comboBox10, comboBox11, comboBox12, comboBox13, comboBox14, comboBox15, comboBox16 }
            };
            _parameters = new MovementStateParameters
            {
                RunningAnimations = new string[8],
                WalkingAnimations = new string[8],
                Reaction = (int)reactionNumUpDown.Value
            };
            _animations = new List<string>();
        }

        public List<string> Animations
        {
            get => _animations;
            set
            {
                _animations = value;
                UpdateComboBoxes();
            }
        }
        public StateParameters Parameters => _parameters;
        public List<string> Sounds { get; set; } 

        private void UpdateComboBoxes()
        {
            for (int i = 0; i < comboBoxes.Rank; i++)
            {
                for (int j = 0; j < comboBoxes.Length / comboBoxes.Rank; j++)
                {
                    comboBoxes[i, j].Items.Clear();
                    comboBoxes[i, j].Items.AddRange(_animations.ToArray());
                    comboBoxes[i, j].SelectedIndex = 0;
                }
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderComboxBox = (ComboBox)sender;

            for (int i = 0; i < comboBoxes.Rank; i++)
            {
                for (int j = 0; j < comboBoxes.Length / comboBoxes.Rank; j++)
                {
                    if (comboBoxes[i, j] == senderComboxBox)
                    {
                        if (i == 0)
                        {
                            _parameters.RunningAnimations[j] = (string)senderComboxBox.SelectedItem;
                            return;
                        }
                        if (i == 1)
                        {
                            _parameters.WalkingAnimations[j] = (string)senderComboxBox.SelectedItem;
                            return;
                        }
                    }
                }
            }
        }

        private void ReactionNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            _parameters.Reaction = (int)reactionNumUpDown.Value;
        }

        private void RunSpeedNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            _parameters.RunSpeed = (int)runSpeedNumUpDown.Value;
        }

        private void WalkSpeedNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            _parameters.WalkSpeed = (int)walkSpeedNumUpDown.Value;

            if (_parameters.WalkSpeed >= _parameters.RunSpeed)
            {
                _parameters.RunSpeed = _parameters.WalkSpeed + 1;
                runSpeedNumUpDown.Minimum = _parameters.RunSpeed;
                runSpeedNumUpDown.Value = _parameters.RunSpeed;
            }
            else
            {
                runSpeedNumUpDown.Minimum = _parameters.WalkSpeed + 1;
            }
        }

        private void IsWalkingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = isWalkingCheckBox.Checked;
            _parameters.IsWalking = isWalkingCheckBox.Checked;

            if (!groupBox2.Enabled)
            {
                _parameters.WalkSpeed = 0;
                runSpeedNumUpDown.Minimum = 1;
            }
            else
            {
                runSpeedNumUpDown.Minimum = walkSpeedNumUpDown.Value;
            }
        }
    }
}
