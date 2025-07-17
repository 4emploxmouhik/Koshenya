using Koshenya.Properties;
using System.IO;
using System.Linq;

namespace Koshenya.Core.States
{
    internal class PunchState : CharacterState
    {
        private readonly Animation[] _animations;
        private readonly string[] _sounds;
        private readonly int _aggressivePunch;

        private readonly Stream[] _soundsStreams;

        private int _punch;

        public PunchState(Character character, Animation[] animations, string[] sounds, int punchesToAggressive) : base(character) 
        {
            _animations = animations;
            _sounds = sounds;
            _character.AnimationPlayer.AnimationEnded += AnimationPlayer_AnimationEnded;
            _character.Movement.DirectionChanged += Movement_DirectionChanged;
            _aggressivePunch = punchesToAggressive;
        }

        public PunchState(Character character, Animation[] animations, Stream[] sounds, int punchesToAggressive) : base(character)
        {
            _animations = animations;
            _soundsStreams = sounds;
            _character.AnimationPlayer.AnimationEnded += AnimationPlayer_AnimationEnded;
            _character.Movement.DirectionChanged += Movement_DirectionChanged;
            _aggressivePunch = punchesToAggressive;
        }

        private void Movement_DirectionChanged(object sender, Movement.Directions e)
        {
            if (e != Movement.Directions.None)
                _punch = 0;
        }

        private void AnimationPlayer_AnimationEnded(object sender, Animation e)
        {
            if (_animations.Contains(e))
            {
                _character.SetState(CharacterStateType.Idle);
            }
        }

        public override void Handle()
        {
            int assetsIndx = ++_punch == _aggressivePunch ? 1 : 0;

            if (_sounds != null)
                _character.SoundPlayer.SoundLocation = _sounds[assetsIndx];
            else
                _character.SoundPlayer.Stream = _soundsStreams[assetsIndx];

            if (!Settings.Default.IsMutted)
            {
                _character.SoundPlayer.Play();
            }
            _character.AnimationPlayer.Play(_animations[assetsIndx]);

            if (_punch == _aggressivePunch)
                _punch = 0;
        }
    }
}
