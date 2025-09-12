using Koshenya.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace Koshenya.Core
{
    internal class Character
    {
        private readonly ICharacterBox _box;

        private readonly Dictionary<CharacterStateType, CharacterState> _declareStates;
        private CharacterStateType _currentStateType;
        private CharacterState _currentState;

        public Character(ICharacterBox box)
        {
            _box = box;
            _declareStates = new Dictionary<CharacterStateType, CharacterState>();

            Movement = new Movement(_box);
            AnimationPlayer = new AnimationPlayer(_box);
            SoundPlayer = new SoundPlayer();
        }

        public event EventHandler DraggingModeChanged;
        
        public string Name { get; set; }
        public Movement Movement { get; }
        public AnimationPlayer AnimationPlayer { get; }
        public SoundPlayer SoundPlayer { get; }
        public Dictionary<CharacterStateType, CharacterState> DeclareStates => _declareStates;

        public bool IsDraggingModeActive { get; private set; }
        public bool IsSleeping { get; set; }

        public void DraggingStart()
        {
            if (_declareStates.ContainsKey(CharacterStateType.Drag))
            {
                IsDraggingModeActive = true;
                _box.Cursor = Cursors.SizeAll;
                DraggingModeChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public void DraggingEnd()
        {
            if (_declareStates.ContainsKey(CharacterStateType.Drag))
            {
                IsDraggingModeActive = false;
                _box.Cursor = Cursors.Default;
                DraggingModeChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Mute()
        {
            Settings.Default.IsMutted = !Settings.Default.IsMutted;
            Settings.Default.Save();

            if (!Settings.Default.IsMutted && IsSleeping)
                SoundPlayer.PlayLooping();
            else
                SoundPlayer.Stop();
        }

        public void Patrol()
        {
            Movement.IsPatrolling = !Movement.IsPatrolling;
        }

        public void Punch()
        {
            if (_currentStateType == CharacterStateType.Idle)
                SetState(CharacterStateType.Punch);
        }

        public void SetState(CharacterStateType state)
        {
            if (_declareStates.ContainsKey(state))
            {
                _currentState = _declareStates[state];
                _currentStateType = state;
            }
            else
            {
                _currentState = _declareStates[CharacterStateType.Idle];
                _currentStateType = CharacterStateType.Idle;
            }
            
            _currentState.Handle();
        }

        public void Start()
        {
            Movement.Start();
            AnimationPlayer.Start();
        }

        public void Stop()
        {
            Movement.Stop();
            AnimationPlayer.Stop();
            SoundPlayer.Stop();
        }
    }
}
