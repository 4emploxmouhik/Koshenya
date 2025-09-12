using System;
using System.Threading.Tasks;

namespace Koshenya.Core.States
{
    internal class DragState : CharacterState
    {
        private readonly Animation _animation;
        private readonly Animation _animationWhenSleeping;

        public DragState(Character character, Animation defaultAnim, Animation sleepingAnim) : base(character) 
        {
            _animation = defaultAnim;
            _animationWhenSleeping = defaultAnim;
            _animationWhenSleeping = sleepingAnim;
            _character.DraggingModeChanged += Character_DraggingModeChanged;
        }

        public override void Handle()
        {
            _character.AnimationPlayer.Play(_character.IsSleeping ? _animationWhenSleeping : _animation);
            _character.Movement.Stop();
        }
      
        private async void Character_DraggingModeChanged(object sender, EventArgs e)
        {
            if (!_character.IsDraggingModeActive)
            {
                if (_character.Movement.IsPatrolling)
                {
                    _character.SetState(CharacterStateType.Move);
                    _character.Movement.Start();
                }
                else if (!_character.IsSleeping)
                {
                    _character.SetState(CharacterStateType.Idle);
                    await Task.Delay(1000);
                    _character.Movement.Start();
                }
                else
                {
                    _character.SetState(CharacterStateType.Awaken);
                }
            }
        }
    }
}
