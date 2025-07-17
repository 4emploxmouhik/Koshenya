namespace Koshenya.Core.States
{
    internal class MovementState : CharacterState
    {
        private readonly Animation[,] _animations;

        public MovementState(Character character, Animation[,] animations) : base(character)
        {
            _animations = animations;
            _character.Movement.DirectionChanged += Movement_DirectionChanged;
            _character.Movement.SpeedChanged += Movement_SpeeedChanged;
        }

        private void Movement_SpeeedChanged(object sender, Movement.Speeds e)
        {
            if (e != Movement.Speeds.None && _character.Movement.Direction != Movement.Directions.None)
                UpdateAnimation();
        }

        private void Movement_DirectionChanged(object sender, Movement.Directions e)
        {
            if (e == Movement.Directions.None)
                _character.SetState(CharacterStateType.Idle);
        }

        public override void Handle()
        {
            UpdateAnimation();
        }

        private void UpdateAnimation()
        {
            _character.AnimationPlayer.Play(_animations[(int)_character.Movement.Speed, (int)_character.Movement.Direction]);
        }
    }
}
