using System;

namespace Koshenya.Core.States
{
    internal class IdleState : CharacterState
    {
        private readonly AnimationClip _animation;

        private readonly int _idleClipsBeforeSleeping;
        private int _counter;

        public IdleState(Character character, AnimationClip clip, int timeBeforeSleep) : base(character)
        {
            _animation = clip;
            _idleClipsBeforeSleeping = (int)(timeBeforeSleep / _animation.Length);
            _character.AnimationPlayer.ClipEnded += AnimationPlayer_ClipEnded;
            _character.Movement.DirectionChanged += Movement_DirectionChanged;
            _character.DraggingModeChanged += Character_DraggingModeChanged;
        }

        public override void Handle()
        {
            _character.AnimationPlayer.Play(_animation);
        }

        private void Character_DraggingModeChanged(object sender, EventArgs e)
        {
            if (_character.IsDraggingModeActive)
                _character.SetState(CharacterStateType.Drag);
        }

        private void Movement_DirectionChanged(object sender, Movement.Directions e)
        {
            if (e != Movement.Directions.None)
                _character.SetState(CharacterStateType.Move);
        }

        private void AnimationPlayer_ClipEnded(object sender, AnimationClip e)
        {
            if (e.Name == _animation.Name)
            {
                if (++_counter == _idleClipsBeforeSleeping)
                {
                    _character.SetState(CharacterStateType.FallAsleep);
                    _counter = 0;
                }
            }
        }
    }
}
