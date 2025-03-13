using Koshenya.Core.Extensions;
using Koshenya.Properties;
using System.Threading.Tasks;

namespace Koshenya.Core.Characters.Cat
{
    internal class Cat : Character
    {
        private const int IDLE_CLIP_TICKS_TO_SLEEP = 3;
        private const int PUNCHES_TO_HISSES = 3;

        private int _idleClipPlayCounter = 0;
        private int _punchCounter = 0;

        private bool _isPunched = false;
        private bool _isSleeping = false;
        private bool _isDragging = false;

        public Cat(string color) : base(new CatAssets(color), new CatBox())
        {
            if (!assets.IsInitialized)
                assets.Initialize();

            box.SetCharacter(this);

            movement.Reaction = 24;
            movement.WalkSpeed = 3;
            movement.RunSpeed = 6;
            movement.DirectionChanged += Movement_DirectionChanged;
            movement.SpeedChanged += Movement_SpeedChanged;

            animationPlayer.ClipEnded += AnimationPlayer_ClipEnded;
            animationPlayer.AnimationEnded += AnimationPlayer_AnimationEnded;
            animationPlayer.AnimationStarted += AnimationPlayer_AnimationStarted;
            animationPlayer.Play(assets.Clips.Get("Idle"));

            animationPlayer.Start();
            movement.Start();
        }
        
        public void Punch()
        {
            if (_isSleeping) return;

            string reaction = "Meow";
            _isPunched = true;

            if (++_punchCounter == PUNCHES_TO_HISSES)
            {
                reaction = "Hisses";
                _punchCounter = 0;
            }

            if (!Settings.Default.IsMutted)
            {
                soundPlayer.SoundLocation = assets.Sounds[reaction];
                soundPlayer.Play();
            }
            animationPlayer.Play(assets.Animations.Get(reaction));
        }

        public void Sleep(bool isSleeping)
        {
            _isSleeping = isSleeping;

            if (_isSleeping)
            {
                _idleClipPlayCounter = 0;
                animationPlayer.Play(assets.Clips.Get("Sleep"));
                movement.Stop();
            }
            else
            {
                animationPlayer.Play(assets.Clips.Get("Idle"));
                movement.Start();
            }
        }

        public async void Drag(bool isDragging)
        {
            _isDragging = isDragging;

            if (_isDragging)
            {
                if (_isSleeping)
                    animationPlayer.Play(assets.Animations.Get("DraggingSleep"));
                else
                    animationPlayer.Play(assets.Animations.Get("Dragging"));

                movement.Stop();
            }
            else
            {
                if (_isSleeping)
                {
                    animationPlayer.Play(assets.Clips.Get("Awaken"));
                }
                else
                {
                    animationPlayer.Play(assets.Animations.Get("Idle"));
                    await Task.Delay(1000);
                    movement.Start();
                }
            }
        }

        public bool IsStillDragging() => _isDragging;

        private void Movement_SpeedChanged(object sender, Movement.Speeds speed)
        {
            if (speed != Movement.Speeds.Idle)
                animationPlayer.Play(assets.Animations.Get($"{movement.Speed}-{movement.Direction}"));
        }

        private void Movement_DirectionChanged(object sender, Movement.Directions direction)
        {
            if (direction != Movement.Directions.None)
            {
                animationPlayer.Play(assets.Animations.Get($"{movement.Speed}-{movement.Direction}"));
                _punchCounter = 0;
            }
            else
                animationPlayer.Play(assets.Clips.Get("Idle"));
        }

        private void AnimationPlayer_ClipEnded(object sender, AnimationClip clip)
        {
            switch (clip.Name)
            {
                case "Idle":
                    if (++_idleClipPlayCounter == IDLE_CLIP_TICKS_TO_SLEEP)
                        Sleep(true);
                    break;
                case "Sleep":
                    Sleep(false);
                    break;
                case "Awaken":
                    Sleep(false);
                    break;
            }
        }

        private void AnimationPlayer_AnimationEnded(object sender, Animation animation)
        {
            switch (animation.Name)
            {
                case "Laydown":
                    if (!Settings.Default.IsMutted)
                    {
                        soundPlayer.SoundLocation = assets.Sounds["Purring"];
                        soundPlayer.PlayLooping();
                    }
                    break;
                case "Meow":
                case "Hisses":
                    if (_isPunched)
                    {
                        animationPlayer.Play(assets.Clips.Get("Idle"));
                        _isPunched = false;
                    }
                    break;
            }
        }

        private void AnimationPlayer_AnimationStarted(object sender, Animation animation)
        {
            switch (animation.Name)
            {
                case "Standup":
                    if (!Settings.Default.IsMutted)
                        soundPlayer.Stop();
                    break;
            }
        }
    }
}
