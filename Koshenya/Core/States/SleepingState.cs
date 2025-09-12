using Koshenya.Properties;
using System.Threading.Tasks;

namespace Koshenya.Core.States
{
    internal class FallAsleepState : CharacterState
    {
        private readonly AnimationClip _animation;

        public FallAsleepState(Character character, AnimationClip clip) : base(character)
        {
            _animation = clip;
            _character.AnimationPlayer.ClipEnded += AnimationPlayer_ClipEnded;
        }

        private void AnimationPlayer_ClipEnded(object sender, AnimationClip e)
        {
            if (e.Name == _animation.Name)
                _character.SetState(CharacterStateType.Sleeping);
        }

        public override void Handle()
        {
            _character.AnimationPlayer.Play(_animation);
            _character.Movement.Stop();
            _character.IsSleeping = true;
        }
    }

    internal class SleepingState : CharacterState
    {
        private readonly Animation _animation;
        private readonly string _sound;
        private readonly int _sleepTime;
        private int _time;

        public SleepingState(Character character, Animation animation, string sound, int time) : base(character)
        {
            _animation = animation;
            _sound = sound;
            _sleepTime = time;
            _time = _sleepTime;
            _character.AnimationPlayer.AnimationEnded += AnimationPlayer_AnimationEnded;
        }

        private void AnimationPlayer_AnimationEnded(object sender, Animation e)
        {
            if (e.Name == _animation.Name)
            {
                _time -= _animation.Length;

                if (_time <= 0)
                {
                    _time = _sleepTime;
                    _character.SetState(CharacterStateType.Awaken);
                }
            }
        }

        public override void Handle()
        {
            _character.SoundPlayer.SoundLocation = _sound;
            
            if (!Settings.Default.IsMutted)
                _character.SoundPlayer.PlayLooping();

            _character.AnimationPlayer.Play(_animation);
        }
    }

    internal class AwakenState : CharacterState
    {
        private readonly AnimationClip _animation;

        public AwakenState(Character character, AnimationClip animation) : base(character)
        {
            _animation = animation;
            _character.AnimationPlayer.ClipEnded += AnimationPlayer_ClipEnded;
        }

        private async void AnimationPlayer_ClipEnded(object sender, AnimationClip e)
        {
            if (e.Name == _animation.Name)
            {
                _character.SetState(CharacterStateType.Idle);
                await Task.Delay(1000);
                _character.Movement.Start();
            }
        }

        public override void Handle()
        {
            _character.SoundPlayer.Stop();
            _character.AnimationPlayer.Play(_animation);
            _character.IsSleeping = false;
        }
    }
}
